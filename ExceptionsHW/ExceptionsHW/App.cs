using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHW
{
    internal class App
    {
        public void Run()
        {
            FileService fileService = new FileService();
            Logger logger = new Logger(fileService);
            Actions actions = new Actions(logger);
            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int actionIndex = random.Next(1, 4);
                try
                {
                    switch (actionIndex)
                    {
                        case 1:
                            actions.StartMethod();
                            break;
                        case 2:
                            actions.SkippedLogic();
                            break;
                        case 3:
                            actions.BrokeLogic();
                            break;
                    }
                }
                catch (BusinessException ex)
                {
                    logger.Log("Warning", "Action got this custom Exception: " + ex.Message);
                }
                catch (Exception ex)
                {
                    logger.Log("Error", "Action failed by reason: " + ex.Message);
                }
            }
        }
    }
}
