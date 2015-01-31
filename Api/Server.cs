using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Api
{
    public class Server : NancyModule
    {
        public Server()
        {
            Get["/Hello"] = p => "Hi there";
        }
    }
}
