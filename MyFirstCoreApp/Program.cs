var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");


//app.Run() used for middleware component execution,
//but its terminating component
//Middleware 2 will not be executed.

//Middleware 1
app.Run(async(HttpContext context) =>
{
    context.Response.Headers["MyKey"] = "Kry007";
    context.Response.Headers["Server"] = "Server007";
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("<h1>Hello</h1>");   
}  
    
);

//Midleware 2
app.Run(async(HttpContext context) =>
{
    await context.Response.WriteAsync("Bala");
});


app.Run();
