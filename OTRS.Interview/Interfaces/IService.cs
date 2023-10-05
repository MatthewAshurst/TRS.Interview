using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTRS.Interview.Interfaces
{
    public interface IService<T> where T : IEntity
    {
        void Add(T entity);

        void Remove(int entityId);
    }
}
