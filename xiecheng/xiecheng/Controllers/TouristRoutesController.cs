using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using xiecheng.Dtos;
using xiecheng.Services;
using AutoMapper;

namespace xiecheng.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;

        //注入私有变量
        private readonly IMapper _mapper;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository ,IMapper mapper)
        {
            //通过接口注入服务依赖
            _touristRouteRepository = touristRouteRepository;
            _mapper = mapper;
        }
       
        //传入格式 api/Controller?Keyword="传入的参数"
        //IActionResult表示访问API动作函数
        [HttpGet]
        public IActionResult GerTouristRoutes([FromQuery]string keyword)
        {
            var touristRoutesFronRepo = _touristRouteRepository.GetTouristRoutes(keyword);
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

            //创建Dto文件
            //var touristRouteDto = new TouristRouteDto()
            //{
            //    Id = touristRouteFromRepo.Id,
            //    Title = touristRouteFromRepo.Title,
            //    Description = touristRouteFromRepo.Description,
            //    Price = touristRouteFromRepo.OriginalPrice * (decimal)(touristRouteFromRepo.DiscountPresent ?? 1),
            //    CreateTime = touristRouteFromRepo.CreateTime,
            //    UpdateTime = touristRouteFromRepo.UpdateTime,
            //    Features = touristRouteFromRepo.Features,
            //    Fees = touristRouteFromRepo.Fees,
            //    Notes = touristRouteFromRepo.Notes,
            //    Rating = touristRouteFromRepo.Rating,
            //    TravelDays = touristRouteFromRepo.TravelDays.ToString(),
            //    TripType = touristRouteFromRepo.TripType.ToString(),
            //    DepartureCity = touristRouteFromRepo.DepartureCity.ToString()
            //};

            //使用Automapper处理数据
            var touristRouteDto = _mapper.Map<TouristRouteDto>(touristRouteFromRepo);

            return Ok(touristRouteDto);
        }
    }
}
