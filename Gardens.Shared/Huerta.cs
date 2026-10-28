using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gardens.Shared
{
    public class Huerta
    {
        public int Id { get; set; }

        [Display(Name = "Nombre de la huerta")]
        [MaxLength(80, ErrorMessage = "El campo Nombre debe tener una longitud de 80.")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Display(Name = "Descripcion de la huerta")]
        [MaxLength(200, ErrorMessage = "El campo Nombre debe tener una longitud de 200.")]
        public string Descripcion { get; set; } = string.Empty;

        [Display(Name = "Fecha de creacion")]
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Date { get; set; } = string.Empty;

        public int IdHuerta { get; set; }

        [ForeignKey(nameof(IdHuerta))]
        public Huerta Huertaid { get; set; } = null!;

    }
}