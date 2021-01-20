using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    //a classe context implementa a interface DbContext
    //que sobreescreve o metodo OnConfiguring esse metodo é responsavel por configurar
    //o entityFramework
    public class Context:DbContext

    {
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opt)
        {
            opt.UseSqlServer(connectionString:@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=true");
        }
    }
}
