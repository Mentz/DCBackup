﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BackupTool.Service {
    public partial class DCBackupToolService: ServiceBase {
        public DCBackupToolService() {
            InitializeComponent();
        }

        private System.Timers.Timer timers;

        protected override void OnStart(string[] args) {
        }

        protected override void OnStop() {
        }
    }
}
