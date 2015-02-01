using Nancy;

namespace Frontend
{
    public class HelloModule : NancyModule
    {
        public HelloModule()
        {
            Get["/Hello"] = p => "Hi there! :)";
            Get["/"] = p => "Battlestation operational";
        }
    }
}