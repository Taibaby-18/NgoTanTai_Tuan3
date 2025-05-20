using Microsoft.EntityFrameworkCore;
using NgoTanTai_Tuan3.Models;

namespace NgoTanTai_Tuan3.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;
        public EFCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            // return await _context.Products.ToListAsync();
            return await _context.categories.ToListAsync();
        }
        public async Task<Category> GetByIdAsync(int id)
        {
            // return await _context.Products.FindAsync(id);
            // lấy thông tin kèm theo category
            return await _context.categories.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task AddAsync(Category category)
        {
            _context.categories.Add(category);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Category category)
        {
            _context.categories.Update(category);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var category = await _context.categories.FindAsync(id);
            _context.categories.Remove(category);
            await _context.SaveChangesAsync();
        }
    }
}
