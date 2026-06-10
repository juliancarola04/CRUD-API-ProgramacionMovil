using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsumoApi.Models
{
    public class Rating
    {
        [Range(0, 5, ErrorMessage = "El puntaje debe estar entre 0 y 5.")]
        public float rate { get; set; }
        public int count { get; set; }
    }
}
