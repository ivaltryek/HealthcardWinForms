using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcardWinForms.Models
{
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string PatientID { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string LaboratorianID { get; set; }
        [Required]
        public string LaboratorianName { get; set; }
        [Required]
        public string PathTOReport { get; set; }
        [Required]
        public string ReportDescription { get; set; }
        [Required]
        public string UploadDate { get; set; }
        [Required]
        public string LabName { get; set; }
        [Required]
        public string ReportName { get; set; }
        [Required]
        public byte[] Content { get; set; }
        
    }

}
