using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Moving.EfDataAccess;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Moving.Api.Core
{
    public class JwtManager
    {
        private readonly MovingContext _context;
        private readonly string _issuer;
        private readonly string _secretKey;


        public JwtManager(MovingContext context, string issuer, string secretKey)
        {
            _context = context;
            _issuer = issuer;
            _secretKey = secretKey;
        }

        public string MakeToken(string email, string password)
        {
            var user = _context.Users.Include(u => u.UserRoles).ThenInclude(o => o.Role).ThenInclude(o => o.RolePermissions).ThenInclude(o => o.Permission)
                .FirstOrDefault(x => x.Email == email && x.Password == password);

            if (user == null)
            {
                return null;
            }

            var actor = new JwtActor
            {
                Id = user.Id,
                RoleName = user.UserRoles.FirstOrDefault().Role.RoleName,
                Identity = user.Email,
                Permissions = user.UserRoles.FirstOrDefault().Role.RolePermissions.Select(o => o.Permission.Name).ToList()
            };

            var claims = new List<Claim> // Jti : "", 
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString(), ClaimValueTypes.String, _issuer),
                new Claim(JwtRegisteredClaimNames.Iss, "asp_api", ClaimValueTypes.String, _issuer),
                new Claim(JwtRegisteredClaimNames.Iat, DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64, _issuer),
                new Claim("UserId", actor.Id.ToString(), ClaimValueTypes.String, _issuer),
                new Claim("ActorData", JsonConvert.SerializeObject(actor), ClaimValueTypes.String, _issuer)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_secretKey));

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var now = DateTime.UtcNow;
            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: "Any",
                claims: claims,
                notBefore: now,
                expires: now.AddDays(30),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
