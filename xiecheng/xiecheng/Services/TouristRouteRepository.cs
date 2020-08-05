using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xiecheng.Database;
using xiecheng.Moldes;

namespace xiecheng.Services
{
    public class TouristRouteRepository:ITouristRouteRepository
    {
        private readonly AppDbcontext _context;

        public TouristRouteRepository(AppDbcontext context) 
        {
            _context = context;
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _context.TouristRoutes.FirstOrDefault(n => n.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _context.TouristRoutes;
        }

        //接口函数调用数据库
        public bool TouristRouteExists(Guid touristRouteId)
        {
            //调用数据库，使用Any表示数据库是否存在。
            return _context.TouristRoutes.Any(t => t.Id == touristRouteId);
        }

        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
        {
            return _context.touristRoutePictures.Where(p => p.TouristRouteid == touristRouteId).ToList();
        }
    }
}
 