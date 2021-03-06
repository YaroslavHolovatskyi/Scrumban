﻿using Scrumban.ServiceLayer.DTO;
using System.Linq;

namespace Scrumban.ServiceLayer.Interfaces
{
    interface IFeatureService
    {
        IQueryable<FeatureDTO> Get();
        void Delete(FeatureDTO feature);
        void Put(FeatureDTO feature);
        void Post(FeatureDTO feature);
    }
}
