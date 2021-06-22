using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class InfoVaccination
    {
        public InfoVaccination()
        {
            Citizens = new HashSet<Citizen>();
        }

        public int Id { get; set; }
        public DateTime? DateAppointment1 { get; set; }
        public TimeSpan? TimeAppointment1 { get; set; }
        public string VaccinationPlace { get; set; }
        public DateTime? DateAppointment2 { get; set; }
        public TimeSpan? TimeAppointment2 { get; set; }

        public virtual ICollection<Citizen> Citizens { get; set; }
    }
}
