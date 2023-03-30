using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace GYMdoJime2_Modulo17E.Models
{
    public class Marcacoes
    {
        [Key]
        //idmarcacao
        public int MarcacoesID { get; set; }

        [Required(ErrorMessage ="Tem de preencher a data e a hora da aula")]
        [DisplayName("Data e hora da aula")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        
        //horaData
        public DateTime? MarcacoesDataHora { get; set; }

        //Chave estrangeira
        //Treinador
        [ForeignKey("TreinadoresID")]
        [DisplayName("Treinadores")]
        [Required(ErrorMessage = "Tem de indicar o treinador")]
        public int Treinadores { get; set; }
        public Treinadores TreinadoresID { get; set; }


        //sala
        [ForeignKey("SalaID")]
        [Required(ErrorMessage = "Tem de indicar a sala")]
        [DisplayName("Sala das marcacoes")]
        public int Sala { get; set; }
        public Salas SalaID { get; set; }

        //tipoAula
        [ForeignKey("TipoAulaID")]
        [DisplayName("Tipo de aula")]
        [Required(ErrorMessage = "Tem de indicar o tipo de aula")]
        public int TipoAula { get; set; }
        public TipoAula TipoAulaID { get; set; }


       public Marcacoes()
        {
            MarcacoesDataHora = DateTime.Now;

        }


       
    }
}