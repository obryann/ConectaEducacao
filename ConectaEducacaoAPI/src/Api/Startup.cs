using Api.Application.Repository;
using Api.Application.UseCase;
using Api.Application.UseCase.Aluno;
using Api.Application.UseCase.Disciplina;
using Api.Infra;
using Api.Infra.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace Api
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ConectaEducacao", Version = "v1" });
            });
            services.AddScoped<IAlunoAdicionarUSeCase, AlunoAdicionarUseCase>();
            services.AddScoped<IAlunoReadOnlyRepository, AlunoRepository>();
            
            services.AddScoped<IDisciplinaAdicionarUseCase, DisciplinaAdicionarUseCase>();
            services.AddScoped<IDisciplinaReadOnlyRepository, DisciplinaRepository>();

            if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("POSTGRES_LOG_CONN")))
            {
                var context = new Context();
                context.Database.Migrate();
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "V1");
            });
        }
    }
}
