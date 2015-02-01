using Nancy;

namespace Frontend
{
    public class ApiModule : NancyModule
    {
        public ApiModule()
        {
            Get["/Hello"] = p => "Hi there! :)";
            Get["/"] = p => "Battlestation operational";


        }
    }
}