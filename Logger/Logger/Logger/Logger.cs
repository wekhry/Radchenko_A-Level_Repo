using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Logger
    {
        private static Logger instance;
        private List<string> logs;
        private string logFilePath;

        private Logger() { }

        public static Logger GetInstance()
        {
            if(instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Initialize(string filePath)
        {
            logFilePath = filePath;
            logs = new List<string>();
        }

        private void Log(string message, string logType)
        {
            string log = $"{DateTime.Now}: {logType}: {message}";
            Console.WriteLine(log);
            logs.Add(log);
        }

        public void LogError(string message)
        {
            Log("Error", message);
        }

        public void LogWarning(string message)
        {
            Log("Warning", message);
        }

        public void LogInfo(string message)
        {
            Log("Info", message);
        }

        public List<string> GetLogs() 
        {
            return logs;
        }
    }
}
