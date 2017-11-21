using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SMS.Models
{
    public class Enrolled
    {
        [Key]
        public int EnrolmentID { get; set; }
        public int StudentID { get; set; }
        public string SubjectID { get; set; }
        public int Marks { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }
    }
}
