using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using xiecheng.Moldes;

namespace xiecheng.Dtos
{
    public class TouristRoutePictureDto
    {
       
        public int Id { get; set; }

        
        public string Url { get; set; }

        public Guid TouristRouteId { get; set; }

        public TouristRoute TouristRoute { get; set; }
    }
}
