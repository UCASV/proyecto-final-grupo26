using System;
using System.Collections.Generic;

#nullable disable

namespace Proyecto_POO_BDD.SqlServerContext
{
    public partial class Citizen
    {
        public int Id { get; set; }
        public string Dui { get; set; }
        public string NameCitizen { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public TimeSpan? TimeEffect { get; set; }
        public DateTime? DateEffect { get; set; }
        public TimeSpan? TimeWline { get; set; }
        public DateTime? DateWline { get; set; }
        public int IdEmployee { get; set; }
        public int IdCabin { get; set; }
        public int IdInstitution { get; set; }
        public int IdDirection { get; set; }
        public int IdInfoVaccination { get; set; }
        public int? IdSideEffects { get; set; }
        public int? IdDiseases { get; set; }

        public virtual Cabin IdCabinNavigation { get; set; }
        public virtual Direction IdDirectionNavigation { get; set; }
        public virtual Disease IdDiseasesNavigation { get; set; }
        public virtual Employee IdEmployeeNavigation { get; set; }
        public virtual InfoVaccination IdInfoVaccinationNavigation { get; set; }
        public virtual Institution IdInstitutionNavigation { get; set; }
        public virtual SideEffect IdSideEffectsNavigation { get; set; }
    }
}
