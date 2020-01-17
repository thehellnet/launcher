using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using TheHellNet.Launcher.Window;

namespace TheHellNet.Launcher
{
    public class Launcher : Application
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof(Launcher));

        private readonly MainWindow _mainWindow = new MainWindow();

        [STAThread]
        public static void Main()
        {
            var launcher = new Launcher();

            try
            {
                launcher.Run();
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            _mainWindow.Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _mainWindow.Close();

            base.OnExit(e);
        }
    }
}
