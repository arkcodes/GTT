﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GathererTimeTable {
    static class Program {
        [STAThread]
        static void Main() {
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Thread.GetDomain().UnhandledException += new UnhandledExceptionEventHandler(Program_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Main());
        }

        static void Program_UnhandledException(object sender,UnhandledExceptionEventArgs e) {
            Exception ex = e.ExceptionObject as Exception;
            if(ex != null) {
                ShowError(ex,"UnhandledException");
            }
        }

        static void Application_ThreadException(object sender,System.Threading.ThreadExceptionEventArgs e) {
            ShowError(e.Exception,"ThreadException");
        }

        public static void ShowError(Exception ex,string title) {
            MessageBox.Show("プログラム中で補足されなかったエラーが発生しました。詳細はエラーログをごらん下さい。",title);

            StreamWriter stream = new StreamWriter("error.txt",true);
            stream.WriteLine("[" + title + "]");
            stream.WriteLine("[message]\r\n" + ex.Message);
            stream.WriteLine("[source]\r\n" + ex.Source);
            stream.WriteLine("[stacktrace]\r\n" + ex.StackTrace);
            stream.WriteLine();
            stream.Close();
            Application.Exit();
        }
    }
}
