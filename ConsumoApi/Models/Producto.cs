using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsumoApi.Models
{
    public class Producto
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Es requerido un nombre para el artículo.")]
        public string title { get; set; }
        [Required(ErrorMessage = "Es requerido un precio.")]
        public float price { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public string image { get; set; }
        public Rating rating { get; set; } = new Rating();
    }
}
