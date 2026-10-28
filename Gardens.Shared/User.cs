using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Gardens.Shared
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de usuario")]
        [MaxLength(150, ErrorMessage = "El campo Nombre debe tener una longitud de 150.")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Display(Name = "Correo Electrónico")]
        [EmailAddress(ErrorMessage = "El formato de correo no es válido.")]
        [MaxLength(150, ErrorMessage = "El campo Correo debe tener una longitud de 150.")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string? Correo { get; set; }



    }
}
