using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameSimulation.Entities;

namespace GameSimulation.Abstract
{
    internal interface IGamerService
    {
        void GamerAdd(Gamer gamer);
        void GamerUpdate(Gamer gamer);
        void GamerDelete(Gamer gamer);
    }
}
