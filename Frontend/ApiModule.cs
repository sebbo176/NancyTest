using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Nancy;

namespace Frontend
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            Get["/Hello"] = parameters => "Hi there! :)";
            Get["/"] = p => "Battlestation operational";
        }
    }
}