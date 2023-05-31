using CLId01.BLL.Interfcae;
using Microsoft.AspNetCore.Mvc;

namespace CLId01.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Clid01Controller : ControllerBase
    {
        private readonly IClid01Bll _objBlll;
        private readonly ILogger<Clid01Controller> _objLogger;

        public Clid01Controller(IClid01Bll sGetBll,ILogger<Clid01Controller> logger)
        {
            _objBlll = sGetBll;
            _objLogger = logger;
        }

        [HttpGet]
        public IActionResult GetClid01()
        {
            var data = _objBlll.GetClid01Async();
            _objLogger.LogDebug("This is Trace");
            if (data == null)
            { 
                _objLogger.LogDebug("Your data is null");
                return NotFound();
            }
            _objLogger.LogWarning("Logging working properly");
             return Ok(data);
        }
    }
}
