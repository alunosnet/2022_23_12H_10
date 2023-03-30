using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYMdoJime2_Modulo17E.Models
{
    public class TipoAula
    {

        [Key]
        public int TipoAulaID { get; set; }

        [Required(ErrorMessage ="Tem de preencher o ntipo de aula")]
        [StringLength(20, ErrorMessage ="Nao existe uma aula com esse numero de letras")]
        [DisplayName("Tipo de aula")]
        public string NomeAula { get; set; }
    }
}