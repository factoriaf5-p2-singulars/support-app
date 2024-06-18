using Microsoft.EntityFrameworkCore;
using SupportApp.Data;
using SupportApp.Filters;
using SupportApp.Middlewares;
using SupportApp.Repositories.Implementations;
using SupportApp.Repositories.Interfaces;

namespace SupportApp;

public class Startup
{
    public Startup(IHostEnvironment env)
    {
        // Configuration = configuration;
        var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
            .AddEnvironmentVariables();
        Configuration = builder.Build();
    }
    
    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        });
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
        services.AddControllers();
        services.AddScoped<ISupportProjectRepository, SupportProjectRepository>();
        services.AddScoped<ISupportWorkForceRepository, SupportWorkForceRepository>();
        services.AddScoped<ISupportTaskRepository, SupportTaskRepository>();
        services.AddScoped<IProjectTaskRepository, ProjectTaskRepository>();
        // services.AddControllers(options =>
        // {
        //     options.Filters.Add<ValidationFilter>();
        // });
        services.AddAutoMapper(typeof(Program));
    }

    public void Configure(IApplicationBuilder app, IHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // app.MapControllers();
        app.UseMiddleware<ErrorHandlingMiddleware>();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseEndpoints(endpoints => endpoints.MapControllers());
        
    }
}

