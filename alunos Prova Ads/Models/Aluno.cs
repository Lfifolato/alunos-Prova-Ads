using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace alunos_Prova_Ads.Models
{   
    [Table("Alunos")]
    public class Aluno
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Nome Obrigatorio")]
        [Display(Name = "Nome:")]
        public string nome { get; set; }

        [Required(ErrorMessage = "CPF Obrigatorio")]
        [Display(Name = "CPF:")]
        public string cpf { get; set; }

        [Required(ErrorMessage = "Curso Obrigatorio")]
        [Display(Name = "Curso:")]
        public string curso { get; set; }

        [Required(ErrorMessage = "Data Obrigatorio")]
        [Display(Name = "Idade")]
        public int idade { get; set; }

        [Required(ErrorMessage = "Curso Obrigatorio")]
        [Display(Name = "Nome da Faculdade:")]
        public string nomeFaculdade { get; set; }

    }
}
