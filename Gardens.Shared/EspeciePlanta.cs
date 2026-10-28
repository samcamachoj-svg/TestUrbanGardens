using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Gardens.Shared
{
    public class EspeciePlanta
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string NombreComun { get; set; } = string.Empty;

        [StringLength(150)]
        public string? NombreCientifico { get; set; }

        [Range(0, 365)]
        public int DiasGerminacion { get; set; }

        [Range(0, 1000)]
        public int DiasACosecha { get; set; }

        [StringLength(50)]
        public string? NecesidadRiego { get; set; }

        [StringLength(50)]
        public string? TipoSueloIdeal { get; set; }

    }
}