using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcardWinForms.Models
{
    public class Prescription
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string DoctorEmail { get; set; }
        [Required]
        public string PatientID { get; set; }
        [Required]
        public string  MedicineID { get; set; }
        [Required]
        public string PatientName { get; set; }
        [Required]
        public string DoctorHospital { get; set; }
        [Required]
        public string DoctorName { get; set; }
        public string Date { get; set; }
    }
}
