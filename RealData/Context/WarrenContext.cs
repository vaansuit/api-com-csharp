using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealData.Model;

namespace RealData.Context
{
    public class WarrenContext : DbContext
    {
        #region Props
        public DbSet<Animal> Animais { get; set; } //Animais ficou o nome da tabela
        public DbSet<Planta> Planta { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host= localhost; Port= 5434; Database= postgres; Password= 123; UserId=postgres;");
        }
    }
}
