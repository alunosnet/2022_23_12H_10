using GYMdoJime2_Modulo17E.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GYMdoJime2_Modulo17E.Helper
{
    public static class Utils
    {
        public static string UserId(this HtmlHelper htmlHelper, System.Security.Principal.IPrincipal utilizador)
        {
            string iduser = "";

            using (var context = new GYMdoJime2_Modulo17EContext())
            {
                var consulta = context.Database.SqlQuery<int>("SELECT IDUtilizador FROM Utilizadores where nome = @p0",
                    utilizador.Identity.Name);
                if (consulta.ToList().Count > 0)
                {
                    iduser = consulta.ToList()[0].ToString();
                }
            }
            return iduser;
        }
    }
}