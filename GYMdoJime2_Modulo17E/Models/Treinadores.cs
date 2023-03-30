using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace GYMdoJime2_Modulo17E.Models
{
    public class Treinadores
    {
        [Key]
        public int TreinadoresID { get; set; }

        [Required(ErrorMessage = "Tem de preencher o Nome do treinador")]
        [UIHint("Preencha com o nome do treinador")]
        [DisplayName("Nome do Treinador")]
        [MinLength(3, ErrorMessage = "O nome tem de ter 3 caracteres ")]
        [StringLength(80, ErrorMessage = "O nome nao deve ser muito grande ")]
        public string TreinadoresName { get; set; }

        [Required(ErrorMessage = "Tem de preencher a idade do treinador")]
        [UIHint("Preencha a idade do treinador")]
        [DisplayName("Idade do Treinador")]
        [MaxLength(2, ErrorMessage = "A idade tem de ter dois digitos ")]
        public string TreinadoresIdade { get; set; }


        [Required(ErrorMessage = "Tem de preencher o email do treinador")]
        [UIHint("Preencha o email do treinador")]
        [DisplayName("Email do treinador")]
        [DataType(DataType.EmailAddress)]
        public string TreinadoresEmail { get; set; }


        //[MinLength(9)]
        //[MaxLength(9)]
        [Required(ErrorMessage ="Tem de preencher o telefone do treinador")]
        [UIHint("Preencha o telefone do treinador")]
        [DisplayName("Contacto do treinador")]
        [StringLength(9, ErrorMessage ="O telefone tem de ser somente 9 digitos")]
        public string TreinadoresTelefone { get; set; }



        
        public bool TreinadoresEstado { get; set; }
        public Treinadores()
        {
            TreinadoresEstado = true;
        }



        
        



    }
}