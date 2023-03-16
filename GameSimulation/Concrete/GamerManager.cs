using GameSimulation.Abstract;
using GameSimulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulation.Concrete
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void GamerAdd(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.FirstName + " " + "Adlı Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Hatalı bilgi girdiniz");
            }
        }

        public void GamerUpdate(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "Adlı Oyuncu Güncellendi");
        }

        public void GamerDelete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + "Adlı Oyuncu Silindi");
        }

        
    }


}
