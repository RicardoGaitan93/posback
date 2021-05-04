using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pos.Api.CrossCutting;
using Pos.Api.DataAccess;
using Pos.Api.DataAccess.Contracts;

namespace Pos.Api
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
            services.AddScoped<IPosDBContext, PosDBContext>();
            services.AddDbContext<PosDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("POSConnDB")));
            IoCRegister.AddRegistration(services);
            services.AddControllers();
            //Allow Cors RG
            //https://www.youtube.com/watch?v=MBpH8sGqrMs
            services.AddCors(options => options.AddDefaultPolicy(
                builder => builder.AllowAnyOrigin()
                ));
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

            //Allow Cors RG
            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
