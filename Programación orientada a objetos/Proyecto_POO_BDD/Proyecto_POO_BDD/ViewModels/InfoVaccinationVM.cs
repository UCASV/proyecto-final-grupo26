using System;
using Proyecto_POO_BDD.SqlServerContext;


namespace Proyecto_POO_BDD.ViewModels
{
    public class InfoVaccinationVM
    {
        public DateTime? DateAppointment1 { get; set; }
        public TimeSpan? TimeAppointment1 { get; set; }
        public DateTime? DateAppointment2 { get; set; }
        public TimeSpan? TimeAppointment2 { get; set; }
    }
}