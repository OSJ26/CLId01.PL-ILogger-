using CLId01.DAL.Interface;
using CLId01.DAL.Model;
using Microsoft.Extensions.Configuration;
using ServiceStack.OrmLite;

namespace CLId01.DAL.Service
{
    public class sClid01Get : IClid01Get
    {
        private readonly IConfiguration _objConfig;
        private readonly OrmLiteConnectionFactory _objConnection;
        public sClid01Get(IConfiguration config)
        { 
            _objConfig = config;
            _objConnection = new OrmLiteConnectionFactory(_objConfig.GetConnectionString("MyAsset"),MySqlDialect.Provider);
        }

        public async Task<List<CLID01>> GetAllAsync()
        {
            using (var db = _objConnection.Open())
            { 
                var data = await db.SelectAsync<CLID01>();
                return data;
            }
        }
    }
}
