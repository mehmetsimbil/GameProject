﻿using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface ISaleService
    {
        public void Sale(User user,Sale sale,Campaign campaign);
    }
}
