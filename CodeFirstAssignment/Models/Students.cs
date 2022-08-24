using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAssignment.Models
{
    public class Students
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MatricNo { get; set; }
        public decimal SchoolFees { get; set; }
        public UniversityType UniType { get; set; }

        public ICollection<Admission>? Audiences { get; set; }

    }

    public class Admission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? AdmissionId { get; set; }
        public DateTime UtmeDate { get; set; }
        public int? StudentId { get; set; }
        public decimal AdmissionFee { get; set; }

        [ForeignKey("StudentId")]
        public Students? Students { get; set; }
    }

    public enum UniversityType
    {
        Private,
        State,
        Federal

    }
    
}
