using System.ComponentModel.DataAnnotations;

namespace WorkflowAuto.Enums
{
    public enum FileSystem
    {
        [Display(Name = "Flat File")]
        FlatFile, 
        Database, 
        NA
    }
}