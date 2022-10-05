using WorkflowAuto.Contracts;
using WorkflowAuto.Data;

namespace WorkflowAuto.Repositories
{
    public class ApplicationRepository : GenericRepository<Application>, IApplicationRepository
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
