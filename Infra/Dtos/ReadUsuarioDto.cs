using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Infra.Dtos
{
    public class ReadUsuarioDto
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public int Cpf { get; set; }  
        public long DataDeNascimento { get; set; }
        public DateTime HoraDaConsulta { get; set; } = DateTime.Now;

    }
}
