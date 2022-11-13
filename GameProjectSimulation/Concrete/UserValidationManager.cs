using GameProjectSimulation.Abstract;
using GameProjectSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Ümit")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
