using System.ComponentModel.DataAnnotations;

namespace VehiculosMVC2.Models
{
    public class Auto : Vehiculo
    {
        public int Id { get; set; }

        [Range(1, 6)]
        public int NumeroPuertas { get; set; }
    }
}
