using OTRS.Interview.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTRS.Interview.Entities
{
    public class Employement : IEntity
    {
        public int EmploymentId { get; set; }

        public int EmployerId { get; set; }

        [ForeignKey("EmployerId")]
        public Employer Employer { get; set; }

        public int Salary { get; set; }
    }
}
