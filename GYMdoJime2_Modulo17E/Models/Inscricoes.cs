using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GYMdoJime2_Modulo17E.Models
{
    public class Inscricoes
    {
        [Key]
        public int IdInscricoes { get; set; }


        [ForeignKey("IDUtilizador")]
        [Required(ErrorMessage = "Tem de indicar o utilziador")]
        [DisplayName("Nome do utilizador")]
        public int idutilizadores { get; set; }
        public Utilizadores IDUtilizador { get; set; }



        [ForeignKey("MarcacoesID")]
        [Required(ErrorMessage = "Tem de indicar a aula")]
        [DisplayName("Aula escolhida")]
        public int idmarcacoes { get; set; }
        public Marcacoes MarcacoesID { get; set; }
    }
}