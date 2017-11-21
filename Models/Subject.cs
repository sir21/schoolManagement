using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMS.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }

        public ICollection<Enrolled> Enrolled { get; set; }
    }
}
