using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorSkill.DependencyInjection
{
    class FoodService
    {
        private ILogger _logger;
        public FoodService(ILogger logger)
        {
            _logger = logger;
        }
        public void WriteMenu()
        {
            _logger.Log("Menu");
        }
    }
}
