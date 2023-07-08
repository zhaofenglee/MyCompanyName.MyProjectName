using Serilog.Events;
using Serilog;
using Volo.Abp;
using Microsoft.Extensions.DependencyInjection;

namespace MyCompanyName.MyProjectName
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
#if DEBUG
           .MinimumLevel.Debug()
#else
            .MinimumLevel.Information()
#endif
           .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
           .Enrich.FromLogContext()
           .WriteTo.Async(c => c.File("Logs/logs.txt"))
           .CreateLogger();

            Log.Information("Starting winform host.");
            ApplicationConfiguration.Initialize();

            var app = AbpApplicationFactory.Create<MyProjectNameModule>(options =>
            {
                options.UseAutofac();   
                options.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
            });
            app.Initialize();
            MyProjectApp.AbpApplication = app;
            Application.Run(new MainForm());
        }
    }
}