using WorkflowAuto.Enums;

namespace WorkflowAuto.Data
{
    public class Workflow : BaseEntity
    {
        public string Name { get; set; }                        //PasswordReset, UserCreation

        public WorkflowType WorkflowType { get; set; }                //Software, harware
        
        public Application Application { get; set; }             //Empower, FTIR
        public int ApplicationId { get; set; }

        public string EmployeeID { get; set; }                  //The One who initiates Request

        public AssociatedRoles AssociatedRoles { get; set; }             //HOD, Supervisor
        public AssociatedRoles DeliveryRole { get; set; }        //IT Dept


    }
}
