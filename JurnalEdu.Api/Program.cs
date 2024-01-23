using JurnalEdu.Api.Extensions;

namespace JurnalEdu.Api;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        #region Service Collection

        builder.Services.AddDB(builder.Configuration);
        builder.Services.AddSwaggerServices();


        #endregion

        var app = builder.Build();

        #region Application Builder

        app.AddSwaggerBuilder();






        #endregion

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}
