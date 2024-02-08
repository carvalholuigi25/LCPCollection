using LCPCollection.Auth.Data;
using LCPCollection.Auth.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace LCPCollection.Auth
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddCascadingAuthenticationState();
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            builder.Services.AddRazorPages();

            Console.WriteLine(Convert.ToBoolean(builder.Configuration.GetSection("SendGridEmailerEnabled").Value));

            if(Convert.ToBoolean(builder.Configuration.GetSection("SendGridEmailerEnabled").Value) == true) {
                builder.Services.AddTransient<IEmailSender, EmailSender>();
                builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);
            }

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = IdentityConstants.ApplicationScheme;
                options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
            })
            .AddMicrosoftAccount(options =>
            {
                options.ClientId = builder.Configuration["Authentication:Microsoft:ClientId"]!;
                options.ClientSecret = builder.Configuration["Authentication:Microsoft:ClientSecret"]!;
                options.CallbackPath = "/signin-microsoft";
            })
            .AddGoogle(options =>
            {
                options.ClientId = builder.Configuration["Authentication:Google:ClientId"]!;
                options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"]!;
                options.CallbackPath = "/signin-google";
            })
            .AddFacebook(options =>
            {
                options.AppId = builder.Configuration["Authentication:Facebook:AppId"]!;
                options.AppSecret = builder.Configuration["Authentication:Facebook:AppSecret"]!;
                options.CallbackPath = "/signin-facebook";
            })
            .AddGitHub(options =>
            {
                options.ClientId = builder.Configuration["Authentication:Github:ClientId"]!;
                options.ClientSecret = builder.Configuration["Authentication:Github:ClientSecret"]!;
                options.CallbackPath = "/signin-github";
            })
            .AddReddit(options => {
                options.ClientId = builder.Configuration["Authentication:Reddit:ClientId"]!;
                options.ClientSecret = builder.Configuration["Authentication:Reddit:ClientSecret"]!;
                options.CallbackPath = "/signin-reddit";
            })
            .AddTwitter(options => {
                options.ConsumerKey = builder.Configuration["Authentication:Twitter:ConsumerAPIKey"]!;
                options.ConsumerSecret = builder.Configuration["Authentication:Twitter:ConsumerSecret"]!;
                options.CallbackPath = "/signin-twitter";
            })
            .AddDiscord(options => {
                options.ClientId = builder.Configuration["Authentication:Discord:ClientId"]!;
                options.ClientSecret = builder.Configuration["Authentication:Discord:ClientSecret"]!;
                options.CallbackPath = "/signin-discord";
            }).AddCookie();

            builder.Services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(7);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            builder.Services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromDays(7);

                options.LoginPath = "/Identity/Account/Login";
                options.LogoutPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseAntiforgery();
            app.MapRazorPages();

            app.Run();
        }
    }
}
