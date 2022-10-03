namespace WorkflowAuto.Data
{
    public class Workflow : BaseEntity
    {
        public string Name { get; set; }                        //PasswordReset, UserCreation

        public WorkflowType WorkflowType { get; set; }                //Application
        
        public Application Application { get; set; }             //Empower, FTIR
        public int ApplicationId { get; set; }             

        public AssociatedRoles AssociatedRoles { get; set; }             //HOD, Supervisor
        public AssociatedRoles DeliveryRole { get; set; }        //IT Dept

    }

    public enum WorkflowType
    {
        Software,
        Hardware,
    }

    public enum AssociatedRoles
    {
        HOD,
        Supervisor,
        PlanrHead,
        QC,
        IT,
        SiteAdmin
    }
}
