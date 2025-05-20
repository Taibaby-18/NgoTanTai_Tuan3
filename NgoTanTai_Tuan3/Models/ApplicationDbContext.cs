using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NgoTanTai_Tuan3.Models
{
    // khai báo những lớp dữ liệu sẽ đc ánh xạ và DB
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>//DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Khai báo những lớp đã có trong database
        public DbSet<Product> products { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet <ProductImage> productImages { get; set; }
        // khai báo thêm các bảng nếu có 
    }
}
