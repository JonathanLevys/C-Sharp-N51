using Microsoft.EntityFrameworkCore;
using SupermercadoRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SupermercadoRepositorio.BancoDados
{
    internal class SupermercadoContexto : DbContext
    {
        public DbSet<Estante> Estantes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        // dotnet tool install --global dotnet-ef

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\74531\\Documents\\SupermercadoBancoDado.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
