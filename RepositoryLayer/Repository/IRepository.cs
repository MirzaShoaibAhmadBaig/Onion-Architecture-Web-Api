using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
   public interface IRepository<T> where T:BaseEntity
    {

        IEnumerable<T> GetAll();

        T GetById(int id);

        void Insert(T entity);
        void Remove(T enetity);

        void SaveChanges(T enetity);






    }
}
