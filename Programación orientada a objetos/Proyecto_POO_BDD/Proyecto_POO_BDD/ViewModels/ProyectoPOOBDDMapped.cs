using System;
using System.Linq;
using Org.BouncyCastle.Bcpg;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD.ViewModels
{
    class ProyectoPOOBDDMapped
    {
        public static CitizenVM MapCitizenToCitizenVM(Citizen c)
        {
            ProCitasContext context = new ProCitasContext();

            CitizenVM citizen = new CitizenVM();

            //asignando dui y nombre del ciudadano
            citizen.Dui = c.Dui;
            citizen.NameCitizen = c.NameCitizen;

            //instanciando variable infoRef para contener la informacion de la tabla InfoVaccination
            //que corresponda a dicho ciudadano
            var infoRef = context.InfoVaccinations
                .SingleOrDefault(i => i.Id.Equals(c.IdInfoVaccination));

            //Asignando informacion de la cita
            citizen.DateAppointment1 = infoRef.DateAppointment1;
            citizen.TimeAppointment1 = infoRef.TimeAppointment1;
            citizen.DateAppointment2 = infoRef.DateAppointment2;
            citizen.TimeAppointment2 = infoRef.TimeAppointment2;

            //instanciando variable place para contener el lugar de vacunacion la cual es llave foranea en 
            //la tabla infoVaccination
            var place = context.VaccinationPlaces
                .SingleOrDefault(p => p.Id.Equals(infoRef.IdVaccinationPlace));

            //asignando lugar de la cita al ciudadano
            citizen.VaccinationPlaces = place.Place;

            return citizen;
        }
    }
}
