using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Moving.Application.Commands;
using Moving.Application;
using Moving.Application.Commands;
using Moving.Application.Queries;
using Moving.Core;
using Moving.EfDataAccess;
using Moving.Implementation.Commands;
using Moving.Implementation.Queries;
using Moving.Implementation.Validators;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moving.Implementation.Extensions;

namespace Moving.Api.Core
{
    public static class ContainerExtensions
    {
        public static void AddUsesCases(this IServiceCollection services)
        {
            services.AddTransient<ICreateCustomerCommand, EfCreateCustomerCommand>();
            services.AddTransient<ICreateJobReviewCommand, EfCreateJobReviewCommand>();
            services.AddTransient<ICreateJobCommand, EfCreateJobCommand>();
            services.AddTransient<ICreateJobImageCommand, EfCreateJobImageCommand>();
            services.AddTransient<IDeleteJobReviewCommand, EfDeleteJobReviewCommand>();
            services.AddTransient<IDeleteCustomerCommand, EfDeleteCustomerCommand>();
            services.AddTransient<IUpdateCustomerCommand, EfUpdateCustomerCommand>();
            services.AddTransient<IUpdateJobCommand, EfUpdateJobCommand>();
            services.AddTransient<IUpdateUserCommand, EfUpdateUserCommand>();
            services.AddTransient<IRegisterUserCommand, EfRegisterUserCommand>();
            services.AddTransient<IGetCustomersQuery, EfGetCustomersQuery>();
            services.AddTransient<IGetJobsQuery, EfGetJobsQuery>();
            services.AddTransient<IGetUseCaseQuery, EfGetUseCaseLogsQuery>();
            services.AddTransient<ICreateRoleCommand, EfCreateRoleCommand>();
            services.AddTransient<IUpdateRoleCommand, EfUpdateRoleCommand>();
            services.AddTransient<IGetRolesQuery, EFGetRolesQuery>();
            services.AddTransient<IGetJobReviewsQuery, EfGetJobReviewQuery>();

            services.AddTransient<UseCaseExecutor>();
            services.AddTransient<CreateCustomerValidator>();
            services.AddTransient<UpdateCustomerValidator>();
            services.AddTransient<CreateJobValidator>();
            services.AddTransient<UpdateJobValidator>();
            services.AddTransient<CreateJobImageValidator>();
            services.AddTransient<RegisterUserValidator>();
            services.AddTransient<CreateRoleValidator>();
            services.AddTransient<UpdateRoleValidator>();
            services.AddTransient<UpdateUserValidator>();
            services.AddTransient<CreateJobReviewValidator>();
        }

        public static void AddApplicationActor(this IServiceCollection services)
        {
            services.AddTransient<IApplicationActor>(x =>
            {
                var accessor = x.GetService<IHttpContextAccessor>();

                var user = accessor.HttpContext.User;

                if (user.FindFirst("ActorData") == null)
                {
                    return new AnonymousActor();
                }

                var actorString = user.FindFirst("ActorData").Value;

                var actor = JsonConvert.DeserializeObject<JwtActor>(actorString);

                return actor;

            });
        }

        public static void AddJwt(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddTransient<JwtManager>(x =>
            {
                var context = x.GetService<MovingContext>();

                return new JwtManager(context, appSettings.JwtIssuer, appSettings.JwtSecretKey);
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
          .AddJwtBearer(x =>
          {
              x.RequireHttpsMetadata = false;
              x.SaveToken = true;
              x.TokenValidationParameters = new TokenValidationParameters
              {
                  ValidateIssuerSigningKey = true,
                  IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appSettings.JwtSecretKey)),
                  ValidateIssuer = false,
                  ValidateAudience = false
              };
          });
        }
    }
}
