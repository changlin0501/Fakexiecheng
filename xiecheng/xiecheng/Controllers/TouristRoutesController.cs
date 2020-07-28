using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xiecheng.Services;

namespace xiecheng.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            _touristRouteRepository = touristRouteRepository;
        }

        //IActionResult表示访问API动作函数
        [HttpGet]
        public IActionResult GerTouristRoutes()
        {
            var touristRoutesFronRepo = _touristRouteRepository.GetTouristRoutes();
            if (touristRoutesFronRepo == null || touristRoutesFronRepo.Count() <= 0)
            {
                return NotFound("没有旅游路线");
            }
            return Ok(touristRoutesFronRepo);
        }

        //查询指定ID
        [HttpGet("{touristRouteId}")]
        public IActionResult GetTouristRouteById(Guid touristRouteId)
        {
            var touristRouteFromRepo = _touristRouteRepository.GetTouristRoute(touristRouteId);
            if (touristRouteFromRepo == null)
            {
                return NotFound($"旅游路线{touristRouteId}找不到");
            }
            return Ok(touristRouteFromRepo);
        }
    }
}
