using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OneToMany.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public string Section { get; set; }
        /// <summary>
        /// 2.Another convention is to include a collection 
        /// navigation property in the principal entity 
        /// 3.Including navigation properties at both ends
        /// will also result in a one-to-many relationship
        /// </summary>
        public ICollection<Student> Students { get; set; }
    }
}
