namespace WorkflowAuto.Contracts
{
    public interface IGenericRepository<T> where T : class 
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);  
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
        
    }
}
