using LivrariaCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaCrud.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {
        }

        public DbSet<EmprestimoModel> Emprestimo { get; set; }
    }
}
