using System.Collections.Generic;

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
    }
}
