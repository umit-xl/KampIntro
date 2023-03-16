using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " - Adlı oyun eklendi");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " - Adlı oyun silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " - Adlı oyun güncellendi");
        }
    }
}
