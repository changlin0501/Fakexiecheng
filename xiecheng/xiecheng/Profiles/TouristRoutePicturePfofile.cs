using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using xiecheng.Dtos;
using xiecheng.Moldes;

namespace xiecheng.Profiles
{
    public class TouristRoutePicturePfofile:Profile
    {
        public TouristRoutePicturePfofile()
        {
            CreateMap<TouristRoutePicture, TouristRoutePictureDto>();
        }
    }
}
