using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GYMdoJime2_Modulo17E.Data
{
    public class GYMdoJime2_Modulo17EContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public GYMdoJime2_Modulo17EContext() : base("name=GYMdoJime2_Modulo17EContext")
        {
        }

        public System.Data.Entity.DbSet<GYMdoJime2_Modulo17E.Models.Treinadores> Treinadores { get; set; }

        public System.Data.Entity.DbSet<GYMdoJime2_Modulo17E.Models.Salas> Salas { get; set; }

        public System.Data.Entity.DbSet<GYMdoJime2_Modulo17E.Models.TipoAula> TipoAulas { get; set; }

        public System.Data.Entity.DbSet<GYMdoJime2_Modulo17E.Models.Marcacoes> Marcacoes { get; set; }

        public System.Data.Entity.DbSet<GYMdoJime2_Modulo17E.Models.Utilizadores> Utilizadores { get; set; }

        public System.Data.Entity.DbSet<GYMdoJime2_Modulo17E.Models.Inscricoes> Inscricoes { get; set; }
    }
}
