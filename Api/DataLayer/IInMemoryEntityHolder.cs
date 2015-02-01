using System.Collections.Generic;

namespace DataLayer
{
    public interface IInMemoryEntityHolder
    {
        DomainEntity Add(DomainEntity entity);
        List<DomainEntity> GetAll();
        DomainEntity GetById(string id);
    }
}