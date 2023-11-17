using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Security.Cryptography;

namespace SystemBarWeb.Models
{
    public class Mesa
    {
        public enum StatusMesa
        {
            Livre = 1,
            Ocupado = 2, 
            Reservada = 3,
            Bloqueada = 99
        }
        [Required(ErrorMessage = "Número da mesa Obrigatório")]
        [Display(Name ="Número")]

        public int Numero { get; set; }

        public StatusMesa Status { get; set; }

        public DateTime? DataAbertura { get; set; }

    }
}
