using GameProjectSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectSimulation.Abstract
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }

}
