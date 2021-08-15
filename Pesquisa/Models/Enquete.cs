using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pesquisa.Models
{
    [Table("Enquete")]
    public class Enquete
    {

        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }

        [Column("Email")]
        public string Email { get; set; }

        [Column("FaixaSalarioId")]
        [Display(Name = "Faixas de Salario", Description = "")]
        public int FaixaSalarioId { get; set; }
        public virtual FaixaSalario FaixaSalario { get; set; }

        [Column("MotivoEmprestimoId")]
        [Display(Name = "Notivo do Emprestimo", Description = "")]
        public int MotivoEmprestimoId { get; set; }
        public virtual MotivoEmprestimo MotivoEmprestimos { get; set; }

        [Column("ConvenioListId")]
        [Display(Name = "Convenio", Description = "")]
        public int ConvenioListId { get; set; }
        public virtual ConvenioList ConvenioList { get; set; }

        [Column("FaixaIdadeId")]
        [Display(Name = "Faixa de idade", Description = "")]
        public int FaixaIdadeId { get; set; }
        public virtual FaixaIdade FaixaIdades { get; set; }

    }
}
