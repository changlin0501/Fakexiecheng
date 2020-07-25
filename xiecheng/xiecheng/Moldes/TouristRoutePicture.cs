using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace xiecheng.Moldes
{
    public class TouristRoutePicture
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Url { get; set; }
        [ForeignKey("TouristRouteId")]//外键
        public Guid TouristRouteid { get; set; }

        //建立外键联系
        public TouristRoute TouristRoute { get; set; }
    }
}
