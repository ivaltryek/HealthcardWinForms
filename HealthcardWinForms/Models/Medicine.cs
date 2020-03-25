using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcardWinForms.Models
{
    public class Medicine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string MedicineName { get; set; }
        public int MorningDose { get; set; }
        public int AfterNoonDose { get; set; }
        public int NightDose { get; set; }
        public int Days { get; set; }
        public string UniqueMedicineID { get; set; }
        
    }
}
