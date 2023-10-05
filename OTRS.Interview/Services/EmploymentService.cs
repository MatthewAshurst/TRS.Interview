using OTRS.Interview.Entities;
using OTRS.Interview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTRS.Interview.Services
{
    public class EmploymentService : IService<Employement> {

        public void Add(Employement entity)
        {
            using (var context = new TrsContext())
            {
                context.Employements.Add(entity);
                context.SaveChanges();
            }
        }

        public void Remove(int employementId)
        {
            using (var context = new TrsContext())
            {
                var employement = context.Employements.FirstOrDefault(b => b.EmploymentId == employementId);

                if (employement != null)
                {
                    context.Employements.Remove(employement);
                    context.SaveChanges();
                }
            }
        }
    }
}
