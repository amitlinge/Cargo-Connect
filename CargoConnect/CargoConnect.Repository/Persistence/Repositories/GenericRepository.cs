using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoConnect.Infrastructure.Persistence.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using CargoConnect.Application.Interfaces.Repositories;

namespace CargoConnect.Infrastructure.Persistence.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly CargoConnectDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(CargoConnectDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<bool> CreateAsync(T entity)
        {
            if(entity != null)
            {
                await _dbSet.AddAsync(entity);
                return (await _context.SaveChangesAsync() > 0);
            }
            return false;
            
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            if(entity != null)
            {
                _dbSet.Remove(entity);
                return await _context.SaveChangesAsync() > 0;
            }
            return false;
        }

        public async Task<List<T>> GetAllAsync()
        {
            var enitities = await _dbSet.ToListAsync();
            return enitities;
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _dbSet.FindAsync(id);
            return entity!;
        }

        public Task<bool> UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
