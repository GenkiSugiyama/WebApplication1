internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        //MVC�T�[�r�X�̓o�^
        builder.Services.AddMvc();

        var app = builder.Build();

        //�ŐV�� ASP.NET Core MVC ���� MapDefaultControllerRoute() ����Ȃ��Ă������H 
        app.MapDefaultControllerRoute();

        app.Run(async(context) =>
        {
            await context.Response.WriteAsync(
                "I'd rather say there are no configured routes here.");
        });
    }
}