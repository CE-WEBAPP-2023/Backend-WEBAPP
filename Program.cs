using NSwag;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddOpenApiDocument(options =>
{
    options.PostProcess = document =>
    {
        document.Info = new OpenApiInfo
        {
            Version = "v0.0.1",
            Title = "Food-King Backend API",
            Description = "An ASP.NET Web API for managing Food-King's backend services.",
            // TermsOfService = "https://example.com/terms",
            Contact = new OpenApiContact
            {
                Name = "Organization GitHub",
                Url = "https://github.com/orgs/CE-WEBAPP-2023"
            }
            // License = new OpenApiLicense
            // {
            //     Name = "Example License",
            //     Url = "https://example.com/license"
            // }
        };
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi3();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
