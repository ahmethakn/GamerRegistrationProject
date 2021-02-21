using GamerRegistrationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerRegistrationProject.Concrete
{
    public class OrderManager
    {
        public void OrderConditions(Game game)
        {
            List<string> gamesNames = new List<string> { "Age Of Empires II", "Witcher 3 Wild Hunt", "Counter Strike 1.6" };
            List<string> gamePrices = new List<string> { "36 TL", "59.99 TL", "5.90 TL" };
            
            GameSalesManager gameSalesManager = new GameSalesManager();
            CampaignManager campaignManager = new CampaignManager();
                       
            ConsoleKeyInfo tus;

            Console.WriteLine("Kampanyayı uygulamak isterseniz Y tuşuna basınız istemiyorsanız ENTER tuşuna basınız.");
            tus = Console.ReadKey();
            if (tus.Key == ConsoleKey.Y)
            {
                campaignManager.CampaignEntrence();
                Console.Write(gamesNames[1] + gamePrices[1] + " ");
                gameSalesManager.GamePurchase(game);
                Console.WriteLine("İptal etmek için ESCAPE, iade etmek için DELETE tuşuna basınız.");
                tus = Console.ReadKey();
                if (tus.Key == ConsoleKey.Escape)
                {
                    Console.Write(gamesNames[1] + " ");
                    gameSalesManager.OrderCancellation(game);
                }
                else if (tus.Key == ConsoleKey.Delete)
                {
                    gameSalesManager.GameRefund(game);
                }

            }
        }
    }
}
