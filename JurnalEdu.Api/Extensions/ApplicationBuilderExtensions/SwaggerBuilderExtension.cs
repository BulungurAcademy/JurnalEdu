namespace JurnalEdu.Api.Extensions
{
    public static class SwaggerBuilderExtension
    {
        public static void AddSwaggerBuilder(this IApplicationBuilder builder)
        {
            //if (builder.Environment.IsDevelopment())
            //{
                builder.UseSwagger();
                builder.UseSwaggerUI(c =>
                {
                    c.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                });
            //}
        }
    }
}
