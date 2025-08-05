using BlazorServerDemo2.Components;
using BlazorServerDemo2.Services;

namespace BlazorServerDemo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddHttpClient("CatClient", client =>
            {
                client.BaseAddress = new Uri("https://api.api-ninjas.com");
                client.DefaultRequestHeaders.Add("X-Api-Key", "BerNpN0ASoHnAQFRJrZbzOmPzrPnEoltWf22zocf");
            });

            builder.Services.AddScoped<ICatService, CatService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
