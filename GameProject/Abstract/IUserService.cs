using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    interface IUserService
    {
        public void Add(User user);
        public void Delete(User user);
        public void Update(User user);

    }
}
