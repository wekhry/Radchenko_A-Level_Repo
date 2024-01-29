using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHW
{
    internal class Logger
    {
        private FileService fileService;

        public Logger(FileService fileService)
        {
            this.fileService = fileService;
        }

        public void Log(string logType, string message)
        {
            string logTime = DateTime.Now.ToString("MM_dd_yyyy_hh_mm_ss_fff_tt");
            string log = $"{logTime}:{logType}:{message}";
            Console.WriteLine(log);
            fileService.WriteToFile($"{logTime}.txt", log);
        }
    }
}
