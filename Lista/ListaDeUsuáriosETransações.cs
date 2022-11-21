using Aspose.Cells;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Azure.Cosmos.Serialization.HybridRow;
using Microsoft.EntityFrameworkCore;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Listas
{
    public class ListaDeUsuáriosETransaçõesCadastradas : DbContext
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public int Idade { get; set; }
        public string Gênero { get; set; }
        public long Cpf { get; set; }
        public long DataDeNascimento { get; set; }
        public int Valor { get; set; }
        public string Tipo { get; set; }
        public long DataDaTransação { get; set; }
        public string Devedor { get; set; }
        public string Credor { get; set; }
    }
    
    


}
       
 




