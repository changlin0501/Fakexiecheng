using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace xiecheng.Moldes
{
    public class TouristRoute
    {
        //创建旅游路线 Guid是数据类型
        [Key]
        public Guid Id { get; set; }
        [Required]//Required必填字段
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(1500)]
        public string Description { get; set; }
        
        //原价
        [Column(TypeName = "decimal(18,2)")]
        public decimal OriginalPrice { get; set; }

        //折扣 【?】表示为可空数据
        [Range(0.0,1.0)]
        public decimal? DiscountPresent { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? UpdateTime { get; set; }

        public DateTime? DepartureTime { get; set; }

        [MaxLength]
        public string Features { get; set; }
       
        [MaxLength]
        public string Fees { get; set; }
        
        [MaxLength]
        public string Notes { get; set; }

        //建立外键关系 一个旅游路线有很多照片 所以是一对多得关系 这里写成数组得形式
        public ICollection<TouristRoutePicture> TouristRoutePictures { get; set; }
            = new List<TouristRoutePicture>();

        public double? Rating { get; set; }
        public TravelDays? TravelDays { get; set; }
        public TripType? TripType { get; set; }
        public DepartureCity? DepartureCity { get; set; }
    }
}
