﻿using System.Linq;
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
            Get["domain/{id}"] = p => inMemoryEntityHolder.GetById(p.id) == null ? "Entity not found" : FormatterExtensions.AsJson(Response, inMemoryEntityHolder.GetById(p.id));
            Post["domain/"] = p => Response.AsJson(inMemoryEntityHolder.Add(this.Bind<DomainEntity>()), HttpStatusCode.Accepted);
        }
    }
}