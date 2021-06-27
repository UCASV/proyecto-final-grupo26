using System;
using System.Linq;
using Org.BouncyCastle.Bcpg;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD.ViewModels
{
    class ProyectoPOOBDDMapped
    {
        private static ProCitasContext context = new ProCitasContext();

        public static CitizenVM MapCitizenToCitizenVm(Citizen c)
        {
            return new CitizenVM()
            {
                Dui = c.Dui,
                NameCitizen = c.NameCitizen,
                Phone = c.Phone,
                Mail = c.Mail
            };
        }

        public static InfoVaccinationVM MapInfoVaccinationToInfoVaccinationVm(InfoVaccination i)
        {
            var place = context.VaccinationPlaces
                .SingleOrDefault(p => p.Id.Equals(i.IdVaccinationPlace));

            var namePlace = place.Place;
            
                return new InfoVaccinationVM()
                {
                    DateAppointment1 = i.DateAppointment1,
                    TimeAppointment1 = i.TimeAppointment1,
                    DateAppointment2 = i.DateAppointment2,
                    TimeAppointment2 = i.TimeAppointment2,
                    VaccinationPlaces = namePlace
                };
        }
    }
}
