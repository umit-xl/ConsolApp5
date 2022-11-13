using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager (IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public int BirthYear { get; internal set; }
        public string FirstName { get; internal set; }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt olma işlemi tamamlandı giriş yapabilirsiniz");

            }
            else
            {
                Console.WriteLine("Bilgilerinizi kontrol ediniz");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt başarılı bir şekilde güncellendi");
        }
    }
}
