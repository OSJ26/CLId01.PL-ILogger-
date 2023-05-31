using CLId01.DAL.Model;

namespace CLId01.BLL.Interfcae
{
    public interface IClid01Bll 
    {
        Task<List<CLID01>> GetClid01Async();
    }
}
