using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BackupTool.Service {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        static void Main() {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new DCBackupToolService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
