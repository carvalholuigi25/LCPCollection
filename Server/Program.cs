using LCPCollection.Server.Context;
using LCPCollection.Server.Filters;
using LCPCollection.Server.Interfaces;
using LCPCollection.Server.RewriterRules;
using LCPCollection.Server.Services;
using LCPCollection.Server.Hubs;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.AspNetCore.Rewrite;
using Microsoft.Extensions.FileProviders;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text.Json.Serialization;
using Serilog;
//using Newtonsoft.Json.Converters;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
.ReadFrom.Configuration(builder.Configuration)
.Enrich.FromLogContext()
.CreateLogger();

builder.Logging.ClearProviders();
builder.Logging.AddSerilog(logger);

if (builder.Configuration["DBMode"]!.Contains("SQLite", StringComparison.InvariantCultureIgnoreCase))
{
    builder.Services.AddDbContext<DBContext, DBContextSQLite>();
}
else if (builder.Configuration["DBMode"]!.Contains("PostgreSQL", StringComparison.InvariantCultureIgnoreCase))
{
    builder.Services.AddDbContext<DBContext, DBContextPostgreSQL>();
}
else if (builder.Configuration["DBMode"]!.Contains("MySQL", StringComparison.InvariantCultureIgnoreCase))
{
    builder.Services.AddDbContext<DBContext, DBContextMySQL>();
}
else
{
    builder.Services.AddDbContext<DBContext>();
}

builder.Services.AddScoped<IAnimes, AnimesService>();
builder.Services.AddScoped<IBooks, BooksService>();
builder.Services.AddScoped<IGames, GamesService>();
builder.Services.AddScoped<IMovies, MoviesService>();
builder.Services.AddScoped<ITVSeries, TVSeriesService>();
builder.Services.AddScoped<IFilesList, FilesListService>();
builder.Services.AddScoped<ISoftwares, SoftwaresService>();
builder.Services.AddScoped<IWebsites, WebsitesService>();

//builder.Services.AddControllersWithViews().AddNewtonsoftJson(opts => opts.SerializerSettings.Converters.Add(new StringEnumConverter()));
builder.Services.AddControllersWithViews().AddJsonOptions(options => {
    options.JsonSerializerOptions.WriteIndented = true;
    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
});

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
});

builder.Services.AddRazorPages();
builder.Services.AddMvc();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "LCPCollection API",
        Description = "LCPCollection API",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new OpenApiContact
        {
            Name = "Contact",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "License",
            Url = new Uri("https://example.com/license")
        }
    });

    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    options.SchemaFilter<EnumSchemaFilter>();
    options.ParameterFilter<ParameterFilter>();
    options.UseInlineDefinitionsForEnums();
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsAllowAll", builder =>
    {
        builder.AllowAnyMethod()
               .AllowAnyOrigin()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true);
    });
});


builder.Services.AddResponseCompression(opts =>
{
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(
          new[] { "application/octet-stream" });
});

builder.Services.AddSignalR();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.SerializeAsV2 = true;
    });
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.EnablePersistAuthorization();
    });

    app.UseWebAssemblyDebugging();
}
else
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseResponseCompression();
}

app.UseRewriter(new RewriteOptions().Add(new RedirectLowerCaseRule()));
app.UseCors("CorsAllowAll");
app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(builder.Environment.ContentRootPath, "Uploads")),
    RequestPath = "/Uploads"
});

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapRazorPages();
app.MapControllers();
app.MapHub<ChatHub>("/chathub");
app.MapFallbackToFile("index.html");

app.Run();
