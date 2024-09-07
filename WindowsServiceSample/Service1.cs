using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsServiceSample
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Log("Windows Service Start!");

            Timer timer = new Timer();
            timer.Interval = 5000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Log("imer_Elapsed");
        }

        protected override void OnStop()
        {
            Log("Windows Service Stop!");
        }

        private void Log(string message)
        {
            string path = @"C:\Users\chegeni\Desktop\C#Projects\Log\log.txt";
            System.IO.File.AppendAllLines(path, new List<string> { $"{message} + {DateTime.Now}"});

        }
    }
}
