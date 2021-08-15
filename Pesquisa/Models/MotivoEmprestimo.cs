using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.Models
{
    [Table("MotivoEmprestimo")]
    public class MotivoEmprestimo
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("EmprestimoMotivo")]
        [Display(Name = "Motivo do Emprestimo", Description = "")]
        public string EmprestimoMotivo { get; set; }

    }
}
