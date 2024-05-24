var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

//app.MapGet("/", () => "Hello World!");

app.UseRouting();

app.MapRazorPages();

app.Run();
