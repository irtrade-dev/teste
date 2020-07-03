using IRTrade.Teste.Models.Empresas;
using IRTrade.Teste.Models.Fornecedores;
using Microsoft.EntityFrameworkCore;

namespace IRTrade.Teste.Data
{
    public class TestDbContext : DbContext
    {
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {

        }
    }
}