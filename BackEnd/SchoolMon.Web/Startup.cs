using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SchoolMon.Application.Interfaces;
using SchoolMon.Application.Services;
using SchoolMon.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolMon.Web
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

            //services.AddControllers();
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SchoolMon.Web", Version = "v1" });
            });
            services.AddControllers().AddNewtonsoftJson();
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseReponsitory<>));
            services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));

            services.AddScoped<IQuestionReponsitory, QuestionReponsitory>();
            services.AddScoped<IQuestionService, QuestionService>();

            services.AddScoped<IEvalutionCardRepository, EvalutionCardRepo>();
            services.AddScoped<IEvalutionCardService, EvalutionCardService>();

            services.AddScoped<IChildrenRepo, ChildrenRepo>();
            services.AddScoped<IChildrenService, ChildrenService>();

            services.AddScoped<IQuestionTypeRepo, QuestionTypeReponsitory>();
            services.AddScoped<IQuestionTypeService, QuestionTypeService>();

            services.AddScoped<IEvalutionSubmitRepo, EvalutionSubmitRepo>();
            services.AddScoped<IEvalutionSubmitService, EvalutionSubmitService>();


            services.AddScoped<IAccountRepo, AccountRepo>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IEvalutionService, EvalutionService>();
            services.AddScoped<IEvalutionRepo, EvalutionRepo>();

            services.AddScoped<IClassChildrenService, ClassChildrenService>();
            services.AddScoped<IClassChildrenRepo, ClassChildrenRepo>();
          
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SchoolMon.Web v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCors(option => option.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader());
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
