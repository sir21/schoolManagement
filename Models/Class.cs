using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Models
{
    public class Class
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ClassID { set; get; }
        public string ClassName { set; get; }
        public int NoOfStudents { set; get; }
        public int Year { set; get; }
        public ICollection<Student> Students { set; get; }
    }
}
