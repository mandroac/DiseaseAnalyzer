using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseaseAnalyzer.Models
{
    public class MedicalRecord
    {
        [Key]
        public int MedicalRecord_ID { get; set; }
        [Required]
        public string Record { get; set; }
        public int Patient_ID { get; set; }
        public Patient Patient { get; set; }
    }
}
