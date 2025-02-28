using System.Text.Json.Serialization;
using InstantRemote.Api.Extensions;
using InstantRemote.Api.Extensions.Swagger;
using InstantRemote.Core.Helpers;
using InstantRemote.Core.Helpers.ControllerModelConvention;

namespace InstantRemote.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddInyeccionDependencias(Configuration);
            services.AddMemoryCache();
            services.AddControllers(config => { config.Conventions.Add(new ControllerModelConvention());})
                    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));
            services.AddServiceSwagger();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();


            app.UseHttpsRedirection();
         //   app.UseMiddleware<InspectorMensajesMiddleware>();
            app.UseRouting();
            app.UseCors(Constants.OriginsPolicy);
            app.AddCustomsMiddelwares();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
            app.UseSwagger();
            app.UseSwaggerUI(c => { c.AddSwaggerEndpointsPath(Configuration); });
        }
    }
}
