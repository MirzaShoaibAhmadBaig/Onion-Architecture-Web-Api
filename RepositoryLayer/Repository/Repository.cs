using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        private readonly ApplicationDBContext _applicationDBContext;
        private DbSet<T> enetities;


        public Repository(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;

            enetities = _applicationDBContext.Set<T>();

        }
        public IEnumerable<T> GetAll()
        {
            return enetities.ToList();
        }

        public T GetById(int id)
        {
            return enetities.SingleOrDefault(c => c.Id==id);
        }

        public void Insert(T entity)
        {
            enetities.Add(entity);
            _applicationDBContext.SaveChanges();
        }

        public void Remove(T enetity)
        {
            enetities.Remove(enetity);
            _applicationDBContext.SaveChanges();
        }

        public void SaveChanges(T enetity)
        {
            _applicationDBContext.SaveChanges();
        }
    }
}
