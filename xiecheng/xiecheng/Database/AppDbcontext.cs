using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using xiecheng.Moldes;

namespace xiecheng.Database
{
    public class AppDbcontext:DbContext
    {
        //调用父类
        public AppDbcontext(DbContextOptions<AppDbcontext> options)
            :base(options)
        { 
        
        }

        //DB映射
        public  DbSet<TouristRoute> TouristRoutes { get; set; }
        public DbSet<TouristRoutePicture> touristRoutePictures { get; set; }

    }
}
