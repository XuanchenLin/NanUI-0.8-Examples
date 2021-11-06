using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetDimension.NanUI;
using NetDimension.NanUI.EmbeddedFileResource;

namespace LayerdStyleClient
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if NETCOREAPP3_1_OR_GREATER
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
#endif
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WinFormium.CreateRuntimeBuilder(env =>
            {
                env.CustomCefSettings(settings =>
                {
                    // Sets this property to true, if you are attempting to use Layerd/Acrylic style.
                    settings.WindowlessRenderingEnabled = true;
                });

                env.CustomCefCommandLineArguments(commandLine =>
                {

                });
            }, app =>
            {

                app.UseDebuggingMode();

                app.UseEmbeddedFileResource("http", "res.app.local", "wwwroot");

                app.UseMainWindow(context => new MainWindow());

            }).Build().Run();
        }
    }
}
