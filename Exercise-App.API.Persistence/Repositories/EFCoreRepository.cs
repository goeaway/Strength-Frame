using Exercise_App.API.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_App.API.Application.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Exercise_App.API.Persistence.Repositories
{
    public class EFCoreRepository<T> : IExerciseAppRepository<T> where T : class
    {
        private readonly ExerciseAppContext _context;
        private readonly DbSet<T> table;

        public EFCoreRepository(ExerciseAppContext context)
        {
            _context = context;
            table = _context.Set<T>();
        }

        public void Delete(int id)
        {
            try
            {
                var existing = table.Find(id);
                table.Remove(existing);

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new RepositoryException($"Exception occured when trying to delete {typeof(T).Name} with id: {id}", e);
            }
        }

        public Task DeleteAsync(int id)
        {
            return Task.Run(() => Delete(id));
        }

        public T Get(int id)
        {
            try
            {
                return table.Find(id);
            }
            catch (Exception e)
            {
                throw new RepositoryException($"Exception occured when trying to get {typeof(T).Name} with id: {id}", e);
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return table.ToList();
            }
            catch (Exception e)
            {
                throw new RepositoryException($"Exception occured when trying to get all of {typeof(T).Name}", e);
            }
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            return Task.Run(() => GetAll());
        }

        public Task<T> GetAsync(int id)
        {
            return Task.Run(() => Get(id));
        }

        public void Insert(T entity)
        {
            try
            {
                table.Add(entity);

                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new RepositoryException($"Exception occured when trying to insert {typeof(T).Name}", e);
            }
        }

        public Task InsertAsync(T entity)
        {
            return Task.Run(() => Insert(entity));
        }

        public void Update(T entity)
        {
            try
            {
                table.Attach(entity);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new RepositoryException($"Exception occured when trying to update {typeof(T).Name}", e);
            }
        }

        public Task UpdateAsync(T entity)
        {
            return Task.Run(() => Update(entity));
        }
    }
}
