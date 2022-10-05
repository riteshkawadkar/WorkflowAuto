using WorkflowAuto.Contracts;
using WorkflowAuto.Data;

namespace WorkflowAuto.Repositories
{
    public class WorkflowRepository : GenericRepository<Workflow>, IWorkflowRepository
    {
        public WorkflowRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
