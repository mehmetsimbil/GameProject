using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concretes
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(User user)
        {
            if (_userValidationService.Validate(user)==true)
            {
                Console.WriteLine("Yeni Kullanıcı Eklendi.");
            }
        }

        public void Delete(User user)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine("Kullanıcı Güncellendi.");
        }
    }
}
