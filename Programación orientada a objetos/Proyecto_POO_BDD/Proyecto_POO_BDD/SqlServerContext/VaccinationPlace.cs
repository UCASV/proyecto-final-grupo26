using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class VaccinationPlace
    {
        public VaccinationPlace()
        {
            InfoVaccinations = new HashSet<InfoVaccination>();
        }

        public int Id { get; set; }
        public string Place { get; set; }

        public virtual ICollection<InfoVaccination> InfoVaccinations { get; set; }
    }
}
