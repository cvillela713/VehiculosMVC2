using System.ComponentModel.DataAnnotations;

namespace VehiculosMVC2.Models
{
    public class Vehiculo
    {
        public string? Marca { get; set; }

        public string? Modelo { get; set; }

        [Range(1900, 2100)]
        public int Anio { get; set; }
    }
}
