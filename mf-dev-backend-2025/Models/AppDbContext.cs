using Microsoft.EntityFrameworkCore;

namespace mf_dev_backend_2025.Models
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<Veiculo> Veiculos { get; set; } // Representa a tabela "Veiculos" no banco de dados, toda tabela nova, precisa criar a referencia aqui
    }
}
