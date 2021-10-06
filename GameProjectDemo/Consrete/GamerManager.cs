using GameProjectDemo.Abstract;
using GameProjectDemo.Consrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo
{
    class GamerManager : IGamerService
    {
        //oyuncunun dogrulugunu kontrol ediyoruz.
        IGamerCheckManager _gamerCheckManager;

        public GamerManager()
        {
        }

        public GamerManager(IGamerCheckManager gamerCheckService)
        {
            _gamerCheckManager = gamerCheckService;
        }


        public void Add(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer)==true)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine("Oyuncu sisteme eklendi " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Giris Basarisiz");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine("Oyuncu sistemden silindi " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine(" Basarisiz");
            }
            
        }

        public void Update(Gamer gamer)
        {
            if (_gamerCheckManager.Check(gamer) == true)
            {
                Console.WriteLine("Basarili");
                Console.WriteLine("Oyuncu sistemde guncellendi " + gamer.FirstName + " " + gamer.LastName);
            }
            
        }

     
    }
}
