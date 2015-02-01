using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Api
{
    public class ServerModule : NancyModule
    {
        public ServerModule()
        {
            Get["/Hello"] = parameters => "Hi there! :)";
        }
    }
}
