using System.Collections.Generic;
using DataLayer;
using Nancy;
using Nancy.ModelBinding;

namespace Frontend
{
    public class DomainModule : NancyModule
    {
        private List<DomainEntity> entityList;

        public DomainModule()
        {
            if(entityList == null)
                entityList = new List<DomainEntity>();

            Get["domain/"] = p =>
            {
                entityList.Add(new DomainEntity
                {
                    Description = "Description of the object",
                    Name = "Name of the object"
                });
                return Response.AsJson(entityList);

            };

            Post["domain/"] = p =>
            {
                var domainObject = this.Bind<DomainEntity>();
                entityList.Add(domainObject);

                return Response.AsJson(entityList, HttpStatusCode.Accepted);
            };
        }
    }
}