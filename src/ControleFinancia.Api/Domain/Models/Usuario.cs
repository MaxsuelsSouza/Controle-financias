using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinancia.Api.Domain.Models
{
    public class Usuario
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "campo obrigatorio!")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "campo obrigatorio!")]
        public string Senha { get; set; } = string.Empty;
        [Required]
        public DateTime DataCadastro { get; set; }
        public DateTime? DataInativaçao { get; set; }
    }
}