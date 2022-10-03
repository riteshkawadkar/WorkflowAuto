using System.ComponentModel.DataAnnotations;
using WorkflowAuto.Enums;

namespace WorkflowAuto.Models
{
    public class ApplicationVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string? Version { get; set; }
        public string? Manufacturer { get; set; }

        [Display(Name= "Connected To Instrumnet?")]
        public ConnectedTo? ConnectedToInstrumnet { get; set; }

        [Display(Name = "Connected To Equipment?")]
        public ConnectedTo? ConnectedToEquipment { get; set; }

        [Display(Name = "Connected To Computer?")]
        public ConnectedTo? ConnectedToComputer { get; set; }

        [Display(Name = "Connected To Server?")]
        public ConnectedTo? ConnectedToServer { get; set; }

        public string? ServerName { get; set; }
        public FileSystem? FileSystem { get; set; }
        public CSVGXPStatus? CSVStatus { get; set; }

        [Display(Name = "CSV Completed On")]
        public DateTime? CSVCompletedOn { get; set; }
        public CSVGXPStatus? GXPStatus { get; set; }
        public BackupMode? BackupMode { get; set; }
        public Priviledges? Priviledges { get; set; }

        [Display(Name = "GAMP Category")]
        public GAMPCategory? GAMPCategory { get; set; }

        [Display(Name = "Vendor Details")]
        public string? VendorDetails { get; set; }

        [Required]
        public Status Status { get; set; }
    }

    public class ApplicationIndexVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Version { get; set; }
        public string? Manufacturer { get; set; }        
        public Status Status { get; set; }
    }
}
