using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHW
{
    internal class Actions
    {
        private Logger logger;

        public Actions(Logger logger)
        {
            this.logger = logger;
        }

        public void StartMethod()
        {
            logger.Log("Info", "Start method: StartMethod");
        }

        public void SkippedLogic()
        {
            logger.Log("Error", "Action got this custom Exception: Skipped logic in method");
            throw new BusinessException("Skipped logic in method");
        }

        public void BrokeLogic()
        {
            logger.Log("Error", "Action failed by reason: I broke the logic");
            throw new Exception("I broke the logic");
        }
    }
}
