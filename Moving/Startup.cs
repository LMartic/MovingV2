using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Moving.Implementation.Logging;
using Moving.Api.Core;
using Moving.Application;
using Moving.Application.Email;
using Moving.Core;
using Moving.EfDataAccess;
using Moving.Implementation.Email;
using Moving.Implementation.Queries;
using Moving.Implementation.Extensions;

namespace Moving
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettings = new AppSettings();

            Configuration.Bind(appSettings);
            services.AddUsesCases();
            services.AddTransient<MovingContext>();
            services.AddHttpContextAccessor();
            services.AddApplicationActor();
            services.AddTransient<IUseCaseLogger, DatabaseUseCaseLogger>();
            services.AddJwt(appSettings);
            var appSetting = Configuration.GetSection("EmailSettings");
            services.Configure<EmailSettings>(appSetting);
            services.AddTransient<IEmailSender, SmtpEmailSender>();
            services.AddControllers();
            services.AddAutoMapper(typeof(EfGetCustomersQuery).Assembly);
            services.AddAutoMapper(typeof(EfGetJobsQuery).Assembly);
            services.AddAutoMapper(typeof(EFGetRolesQuery).Assembly);

            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Nedelja Latest", Version = "v1" });
            //    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            //    {
            //        Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
            //          Enter 'Bearer' [space] and then your token in the text input below.
            //          \r\n\r\nExample: 'Bearer 12345abcdef'",
            //        Name = "Authorization",
            //        In = ParameterLocation.Header,
            //        Type = SecuritySchemeType.ApiKey,
            //        Scheme = "Bearer"
            //    });

            //    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
            //    {
            //        {
            //            new OpenApiSecurityScheme
            //              {
            //                Reference = new OpenApiReference
            //                  {
            //                    Type = ReferenceType.SecurityScheme,
            //                    Id = "Bearer"
            //                  },
            //                  Scheme = "oauth2",
            //                  Name = "Bearer",
            //                  In = ParameterLocation.Header,

            //                },
            //                new List<string>()
            //              }
            //        });
            //});
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Moving", Version = "1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(x =>
            {
                x.AllowAnyOrigin();
                x.AllowAnyMethod();
                x.AllowAnyHeader();
            });

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger");
                c.RoutePrefix = "swagger/ui";
            });

            app.UseRouting();
            app.UseStaticFiles();
            app.UseMiddleware<GlobalExceptionHandler>();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
