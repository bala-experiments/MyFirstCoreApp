var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Creating middlewares using app.Use() method

//Middleware 1
app.Use(async(HttpContext context,RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello\t");
    await next(context);

});

//Middleware 2

app.Use(async(HttpContext context,RequestDelegate next) => 
{ 
    await context.Response.WriteAsync("World");
});    

app.Run();
