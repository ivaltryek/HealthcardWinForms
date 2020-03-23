using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcardWinForms.Models
{
    public class DocDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Doctor { get; set; }
        [Required]
        [MaxLength(1024)]
        public string Specialities { get; set; }
        [Required]
        public string LicenceNo { get; set; }
        [Required]
        public string WorkPlace { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required]
        [MaxLength(6)]
        public string ZipCode { get; set; }
        [Required]
        public string WorkPlaceContact { get; set; }
        [Required]
        public string Degree { get; set; }
        [Required]
        public string State { get; set; }
        public bool IsVerified { get; set; }
    }
}
