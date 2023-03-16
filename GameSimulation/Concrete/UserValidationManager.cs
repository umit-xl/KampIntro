using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Abstract;
using GameSimulation.Entities;

namespace GameSimulation.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 2000 && gamer.FirstName == "Ümit" && gamer.LastName == "Arlı" && gamer.IdentityNumber == 39811892146)
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
