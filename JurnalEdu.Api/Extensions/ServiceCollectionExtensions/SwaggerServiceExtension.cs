using Microsoft.OpenApi.Models;
using System.Reflection;

namespace JurnalEdu.Api.Extensions
{
    public static class SwaggerServiceExtension
    {
        public static void AddSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.CustomSchemaIds(x => x.FullName);
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "JurnalEdu.WebApi", Version = "v1" });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. <br />
                                    Enter 'Bearer' [space] and then your token in the text input below. <br /><br />
                                    Example: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,
                        },
                        new List<string>()
                      }
                    });

                c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                c.IncludeXmlComments(xmlPath);
                //#if !DEBUG
                //                if (!string.IsNullOrEmpty(AppSettings.Instance.Swagger.Prefix))
                //                    c.DocumentFilter<PathPrefixInsertDocumentFilter>(AppSettings.Instance.Swagger.Prefix);
                //#endif
            });

            //services.AddSwaggerGenNewtonsoftSupport();
        }
    }
}
