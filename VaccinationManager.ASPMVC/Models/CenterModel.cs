using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CenterModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int AdressId { get; set; }
        public string CompleteAdress { get; set; }

        public int ResponsableId { get; set; }
        public string ResponsableName { get; set; }

        //public int ScheduleId { get; set; }
        //public string CompleteSchedule { get; set; }

        //public int VaccinLotId { get; set; }
        //public string NameVaccin { get; set; }

    }
}
