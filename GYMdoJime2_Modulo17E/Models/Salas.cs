using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GYMdoJime2_Modulo17E.Models
{
    public class Salas
    {

        [Key]
        public int SalaID { get; set; }
        
        [Required(ErrorMessage ="Tem de preencher qual o nome da sala")]
        [DisplayName("Sala")]
        public string NomeSala { get; set; }

        
        [DisplayName("Estado da sala")]
        public bool EstadoSala { get; set; }

        public Salas()
        {
            EstadoSala = true;
        }
    }
}