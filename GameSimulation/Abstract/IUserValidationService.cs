using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    internal interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
