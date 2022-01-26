using System;

namespace cadenaHotelera.Models
{
    public class Habitacion
    {
        public int id { get; set; }
        public int sedeId { get; set; }
        public string tipo { get; set; }
        public int cupo { get; set; }
        public string disponibilidad { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
