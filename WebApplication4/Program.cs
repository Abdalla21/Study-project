//using WebApplication4.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

#region Comments

/*
//app.UseSumMiddleware();

//app.UseMultipleMiddleware();

//app.UseSubtractMiddleware();


//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("First MiddleWare");
//    await next(context);
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("\n\nSecond MiddleWare");
//    await next(context);
//});

////app.CustomMiddlewareFuncExt();
////app.UseExistedMiddleware();

//app.UseWhen((context) => context.Request.Query.ContainsKey("auth") && context.Request.Query["auth"] == "true",
//    app =>
//    {
//        app.Use(async (context, next) =>
//        {
//            await context.Response.WriteAsync("\n\nUse When");
//            await next(context);
//        });
//    });
*/

#endregion

app.Run();