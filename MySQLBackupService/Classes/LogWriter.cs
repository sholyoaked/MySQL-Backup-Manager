﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLBackupService.Classes
{
    class LogWriter : IWriter
    {
        private StreamWriter writer = null;

        public void OpenWriter()
        {
            if (writer == null)
            {
                string logFilePath = AppDomain.CurrentDomain.BaseDirectory + "Log.txt";
                writer = File.AppendText(logFilePath);
            }
            else
            {
                CloseWriter();
                OpenWriter();
            }
        }

        public void Write(string data)
        {
            if (writer != null)
            {
                DateTime dateTime = DateTime.Now;
                writer.WriteLine(string.Format("{0}/{1}/{2} {3}:{4}:{5} - ERROR - {6}", dateTime.Day, dateTime.Month, dateTime.Year, dateTime.Hour, dateTime.Minute, dateTime.Second, data));
            }
        }

        public void CloseWriter()
        {
            if (writer != null)
            {
                writer.Close();
                writer = null;
            }
        }
    }
}