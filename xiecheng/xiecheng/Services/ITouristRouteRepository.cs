using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xiecheng.Moldes;

namespace xiecheng.Services
{
    public interface ITouristRouteRepository
    {
        //添加api方法 得到所有旅游路线
        IEnumerable<TouristRoute> GetTouristRoutes();

        //得到特定的旅游路线
        TouristRoute GetTouristRoute(Guid touristRouteId);

    }
}
