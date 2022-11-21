using Microsoft.EntityFrameworkCore;
using Pro.Listas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectByteBank.Infra.Context
{
    public class DataContext :DbContext
    { 
        public DataContext(DbContext options) : base()
        {

        } 
        public DbSet<ListaDeUsuáriosETransaçõesCadastradas> UsuarioKey { get; set; }
        
    }
}
