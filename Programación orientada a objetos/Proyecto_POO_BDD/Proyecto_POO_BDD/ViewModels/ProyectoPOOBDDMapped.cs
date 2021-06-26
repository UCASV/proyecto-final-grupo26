using System;
using System.Linq;
using Proyecto_POO_BDD.SqlServerContext;

namespace Proyecto_POO_BDD.ViewModels
{
    class ProyectoPOOBDDMapped
    {
        
       
        public static CitizenVM MapCitizenToCitizenVm(Citizen c)
        {
            var db = new ProCitasContext();

            return new CitizenVM()
            {
                Dui = c.Dui,
                NameCitizen = c.NameCitizen,
                Phone = c.Phone,
                Mail = c.Mail,
                IdInfoVaccinationNavigation = c.IdInfoVaccinationNavigation
            };
        }
    }
}