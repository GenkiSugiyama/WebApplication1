internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //MVCサービスの登録
        builder.Services.AddMvc();

        var app = builder.Build();

        //最新の ASP.NET Core MVC だと MapDefaultControllerRoute() じゃなくてこっち？ 
        app.MapDefaultControllerRoute();

        app.Run(async(context) =>
        {
            await context.Response.WriteAsync(
                "I'd rather say there are no configured routes here.");
        });
    }
}