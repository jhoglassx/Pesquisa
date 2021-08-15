using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pesquisa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.DataContext
{
    public class EnqueteConfiguration : IEntityTypeConfiguration<Enquete>
    {
        public void Configure(EntityTypeBuilder<Enquete> builder)
        {
            //builder.HasOne(p => p.FaixaIdade).WithOne().IsRequired().OnDelete(DeleteBehavior.NoAction);
            //builder.HasOne(p => p.FaixaSalario).WithOne().IsRequired().OnDelete(DeleteBehavior.NoAction); ;
            //builder.HasOne(p => p.ConvenioList).WithOne().IsRequired().OnDelete(DeleteBehavior.NoAction); ;
            //builder.HasOne(p => p.MotivoEmprestimo).WithOne().IsRequired().OnDelete(DeleteBehavior.NoAction); ;
        }
    }
}
