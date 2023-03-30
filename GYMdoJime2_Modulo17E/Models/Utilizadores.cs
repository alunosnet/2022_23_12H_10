using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYMdoJime2_Modulo17E.Models
{
    public class Utilizadores
    {
        [Key]
        public int IDUtilizador { get; set; }

        [Required(ErrorMessage ="Tem de preencher o nome do utilizador")]
        [DisplayName("Nome do utilizador")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Tem de preencher o nome do utilizador")]
        [DisplayName("Email do utilizador")]
        public string email { get; set; }

        [Required(ErrorMessage = "Tem de preencher o nome do utilizador")]
        [DisplayName("Idade do utilizador")]
        public string idade { get; set; }

        [Required(ErrorMessage = "Tem de preencher o nome do utilizador")]
        [DisplayName("Perfil do utilizador")]
        public int perfil { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> perfis { get; set; }




    }
}