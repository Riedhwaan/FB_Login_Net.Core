using Microsoft.AspNetCore.Authentication.Cookies;

namespace FB_Login_Net.Core.Pages
{
    public class Startup
    {// Startup.cs

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services, WebApplication app)
        {
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(options =>
            {
                options.LoginPath = "/account/facebook-login"; // Must be lowercase
            })
            .AddFacebook(options =>
            {
                options.AppId = "5498869193469008";
                options.AppSecret = "592ebefd8de3e3e53627d79035d8fecd";





                // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
                public static void Configure(IApplicationBuilder app, IWebHostEnvironment env);

                {

                    // Must be before UseEndPoints
                    app.UseAuthentication();
                    app.UseAuthorization();


                }
            }