using WorkflowAuto.Enums;

namespace WorkflowAuto.Data
{
    public class Application: BaseEntity
    {
        public string Name { get; set; }
        public string? Version { get; set; }
        public string? Manufacturer { get; set; }
        public ConnectedTo? ConnectedToInstrumnet{ get; set; }
        public ConnectedTo? ConnectedToEquipment { get; set; }
        public ConnectedTo? ConnectedToComputer { get; set; }
        public ConnectedTo? ConnectedToServer { get; set; }
        public string? ServerName { get; set; }
        public FileSystem? FileSystem { get; set; }
        public CSVGXPStatus? CSVStatus { get; set; }
        public DateTime? CSVCompletedOn { get; set; }
        public CSVGXPStatus? GXPStatus { get; set; }
        public BackupMode? BackupMode { get; set; }
        public Priviledges? Priviledges { get; set; }
        public GAMPCategory? GAMPCategory { get; set; }
        public string? VendorDetails { get; set; }
        public Status Status { get; set; }

    }
}