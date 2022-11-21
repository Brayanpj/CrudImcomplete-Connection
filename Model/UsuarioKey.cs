using Microsoft.EntityFrameworkCore;
using ProjectByteBank.Infra.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Model
{
    public class UsuarioKey
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Id do usuário é obrigatório")]
        [StringLength(50, ErrorMessage = "O Id do usuário não pode exceder 2 caracteres")]
        public string NomeCompleto { get; set; }
        [Required(ErrorMessage = "O campo Nome Completo é obrigatório")]
        [Range(1, 30, ErrorMessage = "O Nome Completo não pode exceder 30 caracteres")]
        public int Idade { get; set; }
        public string Genêro { get; set; }
        public int Cpf { get; set; }
        public long DataDeNascimento { get; set; } 
      

    }
}
