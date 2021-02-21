using GamerRegistrationProject.Abstract;
using GamerRegistrationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerRegistrationProject.Concrete
{
    public class GameSalesManager : IGameSalesManager
    {
        public void GamePurchase(Game game)
        {
            Console.WriteLine("Adlı Oyunu Satın Alma İşleminiz Başarıyla Gerçekleşmiştir.");
        }

        public void OrderCancellation(Game game)
        {
            Console.WriteLine("Adlı Oyunu Satın Alma İptaliniz Başarıyla Gerçekleşmiştir.");
        }

        public void GameRefund(Game game)
        {
            Console.WriteLine("Adlı Oyunu İade İşleminiz Başarıyla Gerçekleşmiştir.");
        }       
    }
}
