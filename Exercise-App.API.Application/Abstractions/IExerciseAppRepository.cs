using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_App.API.Application.Abstractions
{
    public interface IExerciseAppRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
