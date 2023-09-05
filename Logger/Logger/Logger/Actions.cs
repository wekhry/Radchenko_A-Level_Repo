using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    internal class Actions
    {
        private Logger logger;

        public Actions()
        {
            logger = Logger.GetInstance();
        }

        public Result MethodStart()
        {
            logger.LogInfo("Start method: MethodStart");
            return new Result
            {
                Status = true
            };
        }

        public Result MethodSkipLogic()
        {
            logger.LogWarning("Skipped logic in the method: MethodSkipLogic");
            return new Result
            {
                Status = true
            };
        }

        public Result MethodLogicBroke()
        {
            logger.LogError("I broke a logic");
            return new Result
            {
                Status = false,
                ErrorMessage = "I broke a logic"
            };
        }
    }
}
