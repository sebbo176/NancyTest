using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace Server
{
    public class ApiModule: NancyModule
    {
        public ApiModule()
        {
            Get["/"] = p => "Hi there";
        }
    }
}