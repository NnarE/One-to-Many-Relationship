using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OneToMany.Models
{
    public class Student
    {

        public int StudentId { get; set; }
        public string StudentName { get; set; }
        /// <summary>
        /// 1.relationship between the Students and Grades table in the database, 
        /// where the Students table includes foreign key Grade_GradeId
        /// </summary>
         public Grade Grade { get; set; }


        /////<summary>
        /////4.Student entity includes foreign key property 
        /////GradeId with its reference property Grade
        /////</summary>

        //public int GradeId { get; set; }
        //public Grade Grade { get; set; }



        //One-to-Many Relationship using Fluent API
        //public int Id { get; set; }
        //public string Name { get; set; }

        //public int CurrentGradeId { get; set; }
        //public Grade CurrentGrade { get; set; }



    }
}
