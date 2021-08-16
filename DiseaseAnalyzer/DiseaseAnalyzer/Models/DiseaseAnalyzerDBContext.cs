using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseaseAnalyzer.Models
{
    public class DiseaseAnalyzerDBContext : DbContext
    {
        public DiseaseAnalyzerDBContext() : base("name = DiseaseAnalyzerContext ") {}
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
    }
}
