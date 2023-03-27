var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.Run(async(HttpContext context) =>
{
    context.Response.Headers["MyKey"] = "Kry007";
    context.Response.Headers["Server"] = "Server007";
    context.Response.Headers["Content-Type"] = "text/html";
    await context.Response.WriteAsync("<h1>Hello</h1>");   
}  
    
    );

app.Run();
