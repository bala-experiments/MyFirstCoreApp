namespace MyFirstCoreApp.CustomMiddleware
{
    public class CustMiddleware1 : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Custom Middleware");
            await next(context);

        }
    }
}
