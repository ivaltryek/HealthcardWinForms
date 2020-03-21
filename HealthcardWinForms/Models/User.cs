using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthcardWinForms.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set;  }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string UserType { get; set; }
        [Index(IsUnique = true)]
        [MaxLength(40)]
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string gender { get; set; }
        [MaxLength(2048)]
        public string password { get; set; }
        public string age { get; set; }


    }
}
