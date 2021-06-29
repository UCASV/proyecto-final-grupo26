using System;

namespace Proyecto_POO_BDD.ViewModels
{
    public class CitizenVM
    {
        public string Dui { get; set; }
        public string NameCitizen { get; set; }
        public DateTime? DateAppointment1 { get; set; }
        public TimeSpan? TimeAppointment1 { get; set; }
        public DateTime? DateAppointment2 { get; set; }
        public TimeSpan? TimeAppointment2 { get; set; }
        public string VaccinationPlaces { get; set; }

    }
}