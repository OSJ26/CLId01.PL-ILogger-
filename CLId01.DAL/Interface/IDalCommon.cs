namespace CLId01.DAL.Interface
{
    public interface IDalCommon<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(); 
    }
}
