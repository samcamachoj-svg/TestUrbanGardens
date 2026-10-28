using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Gardens.Shared
{
    public class Siembra
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int EspecieId { get; set; }

        [ForeignKey(nameof(EspecieId))]
        public EspeciePlanta Especie { get; set; } = null!;

        [Required]
        public DateTime FechaSiembra { get; set; }

        [StringLength(500)]
        public string? Notas { get; set; }


    }
}
