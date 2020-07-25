using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiecheng.Moldes
{
    public class TouristRoute
    {
        //创建旅游路线 Guid是数据类型
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        //原价
        public decimal OriginalPrice { get; set; }

        //折扣 【?】表示为可空数据
        public decimal? DiscoutPresent { get; set; }

        public DateTime CreatTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? DepartureTime { get; set; }

        public string Features { get; set; }

        public string Fees { get; set; }

        public string Notes { get; set; }

        //建立外键关系 一个旅游路线有很多照片 所以是一对多得关系 这里写成数组得形式
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
    }
}
