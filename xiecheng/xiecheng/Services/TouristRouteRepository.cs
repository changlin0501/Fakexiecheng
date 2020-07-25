﻿using System;
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
    }
}
 