﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Scrumban.DataAccessLayer.Models;
using Scrumban.ServiceLayer.Entities;

namespace Scrumban.DataAccessLayer
{
    public interface ISprintRepository:IBaseRepository<SprintDAL>
    {
        void Create(SprintDTO sprint);

        void Update(SprintDTO sprint);
    }
}
