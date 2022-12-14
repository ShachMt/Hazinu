using BLHazinu;
using EmailService;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hazinu
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
            //var emailConfig = Configuration
            //.GetSection("EmailConfiguration")
            //.Get<EmailConfiguration>();
            //services.AddSingleton(emailConfig);

            services.AddControllers();
            services.AddScoped<IUserBL, UserBL>();
            services.AddScoped<IEmployeesBL, EmployeesBL>();
            services.AddScoped<IApplyBL, ApplyBL>();
            services.AddScoped<IJobsBL, JobsBL>();
            services.AddScoped<IAddressBL, AddressBL>();
            services.AddScoped<ITheCauseReferralBL, TheCauseReferralBL>();
            services.AddScoped<ITaskBL, TaskBL>();
            services.AddScoped<IStylesInstitutionBL, StylesInstitutionBL>();
            services.AddScoped<IInstitutionsCategoryBL, InstitutionsCategoryBL>();
            services.AddScoped<IStatusBL, StatusBL>();
            services.AddScoped<ISectorBL, SectorBL>();
            services.AddScoped<IFilesBL, FilesBL>();
            services.AddScoped<IDetailsAskerBL, DetailsAskerBL>();
            services.AddScoped<IEducationalInstitutionBL, EducationalInstitutionBL>();
            services.AddScoped<IAgeRangeBL, AgeRangeBL>();
            services.AddScoped<IEducationalInstitutionsApplicantBL, EducationalInstitutionsApplicantBL>();
            services.AddScoped<IMatureCharacterBL, MatureCharacterBL>();
            services.AddScoped<IPatientDetailsBL, PatientDetailsBL>();
            services.AddScoped<ITreatmentDetailsBL, TreatmentDetailsBL>();


            





            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Hazinu.API", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policyBuilder => policyBuilder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()
                        );

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("v1/swagger.json", "Hazinu.API v1"));
            }

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
