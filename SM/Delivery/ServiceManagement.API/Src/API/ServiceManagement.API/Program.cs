//using _4EPlatform.PermissionsChecker;
using _4EPlatform.PermissionsGroupingChecker;
using _4EPlatform.PremessionRegister;
using _4EPlatForm.Infrastrucure.Extention;
using _4EPlatform_ServiceManagement.GrpClientsConfig;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Net;

var builder = WebApplication.CreateBuilder(args);
try
{
    var logger = new LoggerConfiguration()
              .ReadFrom.Configuration(builder.Configuration)
              .Enrich.FromLogContext()
              .CreateLogger();
    builder.Host.UseSerilog(logger);
    // Add services to the container.

    // grpc
    builder.Services.AddGrpc();
    builder.Services.AddGrpcReflection();

    builder.WebHost.ConfigureKestrel(options =>
    {
        options.Listen(IPAddress.Any, 7201, o => o.Protocols = HttpProtocols.Http2);

        // ADDED THIS LINE to fix the problem
        options.Listen(IPAddress.Any, 5217, o => o.Protocols = HttpProtocols.Http1);

    });
    builder.Services.AddUserManagementGrpcClients(builder.Configuration["GrpcServiceSettings:UserManagementUrl"]);
    //builder.Services.AddScoped<PermissionsCheckerMiddleware, PermissionsCheckerMiddleware>();
    builder.Services.AddControllers();

    // Add unit of work & GRepo
    builder.Services.AddUnitOfWorkRepository();
    builder.Services.AddUnitOfWorkRepositry();
    //builder.Services.AddCorsConfig();
    builder.Services.AddDiServices();
    builder.Services.AddDbConfig(builder.Configuration);
    builder.Services.AddHostedService<AddPermissionsMiddleware>();
    builder.Services.AddScoped<PermissionsGroupingCheckerMiddleware, PermissionsGroupingCheckerMiddleware>();

    // Add grpc config to serviceCollection
    builder.Services.AddGrpc();
    //builder.Services.AddGrpcReflection();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    #region Swagger
    builder.Services.AddSwaggerGen(c =>
    {

        c.AddSecurityDefinition(
        "token",
        new OpenApiSecurityScheme
        {
            Type = SecuritySchemeType.Http,
            BearerFormat = "JWT",
            Scheme = "Bearer",
            In = ParameterLocation.Header,
            Name = HeaderNames.Authorization
        }
            );
        c.AddSecurityRequirement(
        new OpenApiSecurityRequirement
        {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "token"
                            },
                        },
                        Array.Empty<string>()
                    }
        }
            );
    });
    #endregion

    builder.Services.AddAuthentication("Bearer")
          .AddJwtBearer("Bearer", options =>
          {
              // the name of your api resources   
              options.Audience = "UserManagementServer";
              /// identity server url                    
              options.Authority = builder.Configuration.GetValue<string>("IdentityUrl");
              options.RequireHttpsMetadata = false;
          });

    builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("ResourceOwnerPolicy", policy =>
        {
            policy.AddAuthenticationSchemes("Bearer");
            policy.RequireClaim("scope", "4EMicroServices"); // Require scope associated with Resource Owner Password token
        });

        options.AddPolicy("ClientCredentialsPolicy", policy =>
        {
            policy.AddAuthenticationSchemes("Bearer");
            policy.RequireClaim("scope", "CPAggregatorAPI"); // Require scope associated with Client Credentials token
        });
    });
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowCors",
            builder =>
            {
                builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .WithOrigins("http://localhost:3000")
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials();
            });
    });

    var app = builder.Build();

    app.UseMiddleware<GlobalExceptionHandler>();

    // Configure the HTTP request pipeline.

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }


    app.ApplyAutoMigration();

    // Add GrpcServices 
    app.AddMapGrpcServices();

    //app.UseHttpsRedirection();
    app.UseCors("AllowCors");
    app.UseAuthentication();
    app.UseAuthorization();
    //app.UseMiddleware<PermissionsCheckerMiddleware>();
    app.UseMiddleware<PermissionsGroupingCheckerMiddleware>();
    app.UseSerilogRequestLogging();

    app.MapControllers();

    app.Run();
}
catch (Exception ex) when (

// https://github.com/dotnet/runtime/issues/60600
ex.GetType().Name is not "StopTheHostException"
    // HostAbortedException was added in .NET 7, but since we target .NET 6 we
    // need to do it this way until we target .NET 8
    && ex.GetType().Name is not "HostAbortedException")
{
    Console.WriteLine(ex.Message);
    Log.Fatal(ex, "Unhandled exception");
}