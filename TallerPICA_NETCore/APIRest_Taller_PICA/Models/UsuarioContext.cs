using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIRest_Taller_PICA.Models
{
    public class UsuarioContext :DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            :base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
