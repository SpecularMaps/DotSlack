using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace DotSlack.Dispatchers
{
    public abstract class Dispatcher
    {
        protected static void PostError(string message)
        {

        }

        protected static void PostResponse(string text)
        {
        }
    }
}
