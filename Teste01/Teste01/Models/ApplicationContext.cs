using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Teste01.Models
{
    public class ApplicationContext : DbContext
    {
        // Defina um DbSet para cada modelo (entidade) que deseja armazenar no banco de dados
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Configurar o provedor de banco de dados e a string de conexão
                optionsBuilder.UseSqlServer("sua_string_de_conexao");
            }
        }
}