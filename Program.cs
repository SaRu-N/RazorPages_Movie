namespace RazorPagesMovie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            //redirects HTTP requests to HTTPs
            app.UseHttpsRedirection();
            //enable static files
            app.UseStaticFiles();
            //adds route matching to the middleware pipeline
            app.UseRouting();
            //in this project we do not need authorization
            app.UseAuthorization();
            //configures endpoint routing for Razor Pages.
            app.MapRazorPages();
            //Runs the app
            app.Run();
        }
    }
}