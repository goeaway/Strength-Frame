using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_App.API.Application.Abstractions
{
    public interface IExerciseAppRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();

        T Get(int id);
        Task<T> GetAsync(int id);

        void Insert(T entity);
        Task InsertAsync(T entity);

        void Update(T entity);
        Task UpdateAsync(T entity);

        void Delete(int id);
        Task DeleteAsync(int id);
    }
}
