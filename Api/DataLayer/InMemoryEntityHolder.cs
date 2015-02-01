using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class InMemoryEntityHolder : IInMemoryEntityHolder
    {
        private List<DomainEntity> _dataList;
        
        public InMemoryEntityHolder()
        {
            _dataList = new List<DomainEntity>();
        }

        public DomainEntity Add(DomainEntity entity)
        {
            _dataList.Add(entity);
            return entity;
        }

        public List<DomainEntity> GetAll()
        {
            return _dataList;
        }

        public DomainEntity GetById(string id)
        {
            return _dataList.SingleOrDefault(c => c.Id == id);
        }
    }
}
