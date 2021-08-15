using Microsoft.EntityFrameworkCore;
using Pesquisa.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<FaixaSalario> FaixaSalario { get; set; }
        public DbSet<MotivoEmprestimo> MotivoEmprestimos { get; set; }
        public DbSet<ConvenioList> ConvenioLists { get; set; }
        public DbSet<FaixaIdade> FaixaIdades { get; set; }
        public DbSet<Enquete> Enquetes { get; set; }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.ApplyConfiguration(new EnqueteConfiguration());
        //}

    }
}
