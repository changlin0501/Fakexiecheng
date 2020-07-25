using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace xiecheng.Moldes
{
    public class TouristRoutePicture
    {
        public int Id { get; set; }

        public string Url { get; set; }

        public Guid TouristRouteid { get; set; }

        //建立外键联系
        public TouristRoute TouristRoute { get; set; }
    }
}
