using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace WindowsServiceSample
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();

            {
                //... Installer code here
                this.AfterInstall += new InstallEventHandler(ServiceInstaller_AfterInstall);
            }

            void ServiceInstaller_AfterInstall(object sender, InstallEventArgs e)
            {
                ServiceInstaller serviceInstaller = (ServiceInstaller)sender;

                using (ServiceController sc = new ServiceController(serviceInstaller1.ServiceName))
                {
                    sc.Start();
                }
            }
        }
    }
}


