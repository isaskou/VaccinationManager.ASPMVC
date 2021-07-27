using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VaccinationManager.DAL;
using VaccinationManager.Models.Adresse;
using VaccinationManager.Models.Center;
using VaccinationManager.Models.Personne;
using WebApplication1.Models;
using WebApplication1.Services.Base_Interface;

namespace WebApplication1.Services
{
    public class CenterService : BaseService, IService<CenterModel>
    {
        public CenterService(DataContext dc) : base(dc)
        {
        }

        public CenterModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CenterModel> GetAll()
        {
            Adress adress = new Adress();
            IEnumerable<VaccinationCenter> entities = _dc.vaccinationCenters
                                                        .Include(vc=>vc.Adress).Where(vc=>vc.AdressId==adress.Id)
                                                        .ToList();

            return entities.Select(e =>
                new CenterModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    AdressId = e.AdressId,
                    CompleteAdress = e.Adress.City,
                    ResponsableId = e.ManagerId,
                    //ResponsableName = e.Manager.Staff.Person.LastName
                }
                );
        }
        public IEnumerable<CenterModel> GetFullAll()
        {
            Person person = new Person();
            Adress adress = new Adress();
            IEnumerable<VaccinationCenter> entities = _dc.vaccinationCenters
                                        .Include(c=>c.Adress).Where(c=>c.AdressId==adress.Id)
                                        .Include(c=>c.Manager)
                                            .ThenInclude(m=>m.Staff)
                                            .ThenInclude(s=>s.Person)
                                        .Where(c=>c.ManagerId == person.Id)
                                        ;

            return entities.Select(e =>
                new CenterModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    AdressId=e.AdressId,
                    CompleteAdress = e.Adress.City,
                    ResponsableId=e.ManagerId,
                    ResponsableName = e.Manager.Staff.Person.LastName
                }
            );

            //return entities.Select(e => {
            //    Adress adress = _dc.Adresses.Find(e.AdressId);
            //    Person person = _dc.People.Find(e.ManagerId);
            //    new CenterModel
            //    {
            //        Id = e.Id,
            //        Name = e.Name,
            //        CompleteAdress = adress.Street + " " + adress.Number + " - " + adress.PostalCode + " " + adress.City + " - " + adress.District,
            //        ResponsableName = person.FirstName + " " + person.LastName
            //    };
            //}
            //);


        
        }

        public CenterModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public CenterModel Insert(CenterModel entity)
        {
            throw new NotImplementedException();
        }

        public CenterModel Update(CenterModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
