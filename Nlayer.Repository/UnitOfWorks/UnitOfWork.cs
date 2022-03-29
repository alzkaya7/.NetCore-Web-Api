using Nlayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Repository.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;

        //Constructor tanımlamalarını kesinlike yap .. gözden kaçırırısan hata veriyor ..
        public UnitOfWork(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
        {
            _dbContext.SaveChanges(); 
        }

        public async Task CommitAsync()
        {
           await _dbContext.SaveChangesAsync();
        }
    }
}
