using MyFirstCoreApp.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);

//Registering the custom middleware service
builder.Services.AddTransient<CustMiddleware1>();

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
    await next(context);
});

//Middleware 3
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("\nMiddleware 3");
    await next(context);
});

//Adding Custom middleware
app.UseMiddleware<CustMiddleware1>();

//Middleware 4 
//app.Use() either can act as terminating component or navigating to next
//app.Use(async (HttpContext context, RequestDelegate next) =>
//{
//    await context.Response.WriteAsync("\nMiddleware 4");    
//});

app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("\nMiddleware 4");
});

app.Run();
