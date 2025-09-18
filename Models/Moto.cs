using System.ComponentModel.DataAnnotations;

namespace VehiculosMVC2.Models
{
    public class Moto : Vehiculo
    {
        public int Id { get; set; }

        [Range(50, 2200)]
        public int CilindrajeCC { get; set; }

        public bool TieneParrilla { get; set; }
    }
}
