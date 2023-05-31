using CLId01.BLL.Interfcae;
using CLId01.DAL.Interface;
using CLId01.DAL.Model;

namespace CLId01.BLL.Service
{
    public class sGetBll : IClid01Bll
    {
        private readonly IClid01Get _objDal;

        public sGetBll(IClid01Get objDal) {
            _objDal = objDal;
        }

        public async Task<List<CLID01>> GetClid01Async()
        {
            try
            {
                return await _objDal.GetAllAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
