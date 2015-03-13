using System;
using System.Collections.Generic;
using System.Text;
using log4net.Core;

namespace ConsoleLogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            logTest();
            logFileTest();
        }

        private static void logTest()
        {
            log4net.ILog log = log4net.LogManager.GetLogger("ConsoleApp.LoggingExample");

            log.Info("hello world!");
        }

        private static void logFileTest()
        {
            log4net.ILog log = log4net.LogManager.GetLogger("LoggingExample");

            log.Info("hello world!");
        }
    }
}
