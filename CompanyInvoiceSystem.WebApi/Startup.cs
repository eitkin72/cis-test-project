using CompanyInvoiceSystem.Entities;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Classes;
using CompanyInvoiceSystem.WebApi.BuisnessLogic.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CompanyInvoiceSystem.WebApi
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
            services.AddCors();

            services.AddDbContext<ApplicationContext>(opt => 
                    opt.UseSqlServer(
                        Configuration.GetConnectionString("sqlConnection") 
                        ,options => options.MigrationsAssembly("CompanyInvoiceSystem.WebApi")
                    )
                );

            services.AddScoped<ICompanyManager, CompanyManager>();
            services.AddScoped<IInvoiceManager, InvoiceManager>();

            services.AddControllers()
                .AddNewtonsoftJson(o => 
                    o.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            ////////services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            ////////{
            ////////    builder.AllowAnyOrigin()
            ////////           .AllowAnyMethod()
            ////////           .AllowAnyHeader();
            ////////}));

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

            app.UseCors(
               options => options.WithOrigins("http://localhost:8081").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin()                
               );

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });        
        }
    }
}
