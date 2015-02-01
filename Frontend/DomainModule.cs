using System.Linq;
using DataLayer;
using Nancy;
using Nancy.ModelBinding;

namespace Frontend
{
    public class DomainModule : NancyModule
    {
        public DomainModule(IInMemoryEntityHolder inMemoryEntityHolder)
        {
            Get["domain/"] = p => !inMemoryEntityHolder.GetAll().Any() ? "No entities at this thime, try posting some!" : Response.AsJson(inMemoryEntityHolder.GetAll());
            Post["domain/"] = p => Response.AsJson(inMemoryEntityHolder.Add(this.Bind<DomainEntity>()), HttpStatusCode.Accepted);
        }
    }
}