using Microsoft.EntityFrameworkCore;
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
            return _context.TouristRoutes.Include(t => t.TouristRoutePictures).FirstOrDefault(n => n.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes(string keyword)
        {
            //IQueryable 其实就是Linq to Sql 语句
            IQueryable<TouristRoute> result = _context
                .TouristRoutes
                .Include(t => t.TouristRoutePictures);
                //如果Keyword为空时或者空字符串时
            if (!string.IsNullOrEmpty(keyword))
            {
                //消除keyword中多余的空格
                keyword = keyword.Trim();
                //使用where函数使用sql语句
               result= result.Where(t => t.Title.Contains(keyword));
            }
            //include vs join (可使用数据立即加载)

            //结果返回tolist()列表指快速去数据库中查找数据
            return result.ToList();
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

        //调用子资源ID
        public TouristRoutePicture GetPicture(int pirtureId)
        {
            return _context.touristRoutePictures.Where(p => p.Id == pirtureId).FirstOrDefault();
        }
    }
}
 