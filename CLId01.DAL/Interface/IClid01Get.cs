using CLId01.DAL.Model;

namespace CLId01.DAL.Interface
{
    public interface IClid01Get
    {
        Task<List<CLID01>> GetAllAsync();
    }
}
