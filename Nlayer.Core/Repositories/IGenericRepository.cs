using System.Linq.Expressions;

namespace Nlayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {

        Task<T> GetByIdAsync(int id); //ID ye göre ürünleri asenkron dön ..

        IQueryable<T> GetAll();

        //productsRepository.where(x=>x.id>5).orderBy.TolistAsync();

        //Yukarıdaki where kısmı için expression sorgusu yazıldı .. 
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
      
        Task AddAsync (T entity); //Ekleme işlemi ..

        Task AddRangeAsync(IEnumerable<T> entities); //Bir ürünü birden fazlada kaydedebilrim ..
        void RemoveRange(IEnumerable<T> entities); //Böyle çoklu işlemlerde IEnumarable geri dönüş kullanırım..

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression); //Bu ürün var mı yok mu diye ?

        void Update(T entity); //Güncelleme işlemi

        void Remove(T entity); //Silme İşlemi

      


    }
}
