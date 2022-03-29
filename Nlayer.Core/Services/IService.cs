using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Services
{
    public  interface IService<T> where T : class
    {

        Task<T> GetByIdAsync(int id); //ID ye göre ürünleri asenkron dön ..

        Task<IEnumerable<T>> GetAllAsync(); //expression alıyordu kaldrdık .. Çünkü where işlemi işimi görüyor ..
      

        IQueryable<T> Where(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity); //Ekleme işlemi .. //gERİYE EKLENEN entitiy dön ..

        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities); //Bir ürünü birden fazlada kayadedebilrim ..
        Task RemoveRangeAsync(IEnumerable<T> entities);

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); //Bu ürün var mı yok mu diye ?

        Task UpdateAsync(T entity); //Güncelleme işlemi

        Task RemoveAsync(T entity); //Silme İşlemi



    }
}
