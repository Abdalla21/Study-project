namespace WebApplication4.Middlewares
{
    public class CustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync(" \n\nFirst Custom MiddleWare");
            //await next(context);
            await context.Response.WriteAsync(" \n\nSecond Custom MiddleWare");
        }
    }

    public static class CustomMiddlewareExt
    {
        public static IApplicationBuilder CustomMiddlewareFuncExt(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CustomMiddleware>();
        }
    }
}
