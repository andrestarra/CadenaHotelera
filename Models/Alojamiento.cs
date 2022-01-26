using System;

namespace cadenaHotelera.Models
{
    public class Alojamiento
    {
        public int id { get; set; }
        public int habitacionId { get; set; }
        public string fecha_inicial { get; set; }
        public string fecha_final { get; set; }
        public string hora_inicial { get; set; }
        public string hora_final { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
