using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsLogDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            log.Error("error", new Exception("发生了一个异常"));
            //记录严重错误
            log.Fatal("fatal", new Exception("发生了一个致命错误"));
            //记录一般信息
            log.Info("hellow world!");
            //记录调试信息
            log.Debug("debug");
            //记录警告信息
            log.Warn("warn");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStart(string.Format("{0}\\log\\log-file.txt", Application.StartupPath));
        }

        public static bool ProcessStart(string filePath)
        {
            ProcessStartInfo info = new ProcessStartInfo(filePath);
            info.CreateNoWindow = false;
            info.ErrorDialog = true;
            info.UseShellExecute = true;
            try
            {
                Process.Start(info);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}