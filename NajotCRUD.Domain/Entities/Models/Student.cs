using NajotCRUD.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Domain.Entities.Models
{
    public class Student : BaseEntity
    {   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public long Cash {  get; set; }
    }
}
