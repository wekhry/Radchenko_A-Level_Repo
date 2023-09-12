using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Starter
    {
        private Actions actions;
        private Logger logger;

        public Starter()
        {
            actions = new Actions();
            logger = Logger.GetInstance();
        }

        public void Run()
        {
            logger.Initialize("log.txt");

            for (int i = 0; i < 100;  i++)
            {
                int randomMethod = new Random().Next(1, 4);

                Result result;
                switch(randomMethod)
                {
                    case 1:
                        result = actions.MethodStart();
                        break;
                    case 2:
                        result = actions.MethodSkipLogic();
                        break;
                    case 3:
                        result = actions.MethodLogicBroke();
                        break;
                    default:
                        result = new Result
                        {
                            Status = false,
                            ErrorMessage = "I broke a logic"
                        };
                        break;
                }

                if(!result.Status)
                {
                    logger.LogError($"Action failed because of: {result.ErrorMessage}");
                }
            }

            List<string> logs = logger.GetLogs();
            StringBuilder logTextBuilder = new StringBuilder();
            for(int i = 0; i < logs.Count; i++)
            {
                logTextBuilder.AppendLine(logs[i]);
            }
            string logText = logTextBuilder.ToString();
            File.WriteAllText("log.txt", logText);
        }
    }
}
