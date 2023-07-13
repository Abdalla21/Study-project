using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace WebApplication4.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MultipleMiddleware
    {
        private readonly RequestDelegate _next;

        public MultipleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("\n\n" + (10 * 5));
            await _next(context);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MultipleMiddlewareExtensions
    {
        public static IApplicationBuilder UseMultipleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MultipleMiddleware>();
        }
    }
}
