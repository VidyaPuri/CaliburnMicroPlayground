using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaliburnMicroTutorial
{
    public class GreetingsMessageProvider
    {
        public string Message { get; set; } = "Startup Message";
        public string Get()
        {
            return Message;
        }
    }
}
