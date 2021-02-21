using GamerRegistrationProject.Concrete;
using GamerRegistrationProject.Entities;
using System;
using System.Collections.Generic;

namespace GamerRegistrationProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberManager memberManager = new MemberManager();
            new Member { FirstName = "İsim", LastName = "Soyisim", DateOfBirth = 1234, NationalityId = 12345678910, NickName = "Gamer", Password = "12345" };
            if (memberManager.CheckIfRealPerson(new Member()) == true)
            {
                memberManager.Save(new Member());
                Console.Clear();

                List<string> gamesNames = new List<string> { "Age Of Empires II", "Witcher 3 Wild Hunt", "Counter Strike 1.6" };
                List<string> gamePrices = new List<string> { "36 TL", "59.99 TL", "5.90 TL" };
                Console.WriteLine("Satın Almak İstediğiniz Oyunu Seçiniz.");
                for (int i = 0; i < gamesNames.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + gamesNames[i]);
                }

                GameSalesManager gameSalesManager = new GameSalesManager();
                CampaignManager campaignManager = new CampaignManager();
                Game game = new Game();
                OrderManager orderManager = new OrderManager();

                var tempNumber = Console.ReadLine();
                int number = Convert.ToInt32(tempNumber);
                ConsoleKeyInfo tus;

                switch (number)
                {
                    case 1:
                        Console.WriteLine("Satın alma işlemini onaylıyorsanız ENTER ı, onaylamıyorsanız ESCAPE i tuşlayınız.");
                        tus = Console.ReadKey();
                        if (tus.Key == ConsoleKey.Enter)
                        {
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
                                    Console.Write(gamesNames[1] + gamePrices[1] + " ");
                                    gameSalesManager.OrderCancellation(game);
                                }
                                else if (tus.Key == ConsoleKey.Delete)
                                {
                                    gameSalesManager.GameRefund(game);
                                }
                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("Satın alma işlemini onaylıyorsanız ENTER ı, onaylamıyorsanız ESCAPE i tuşlayınız.");
                        tus = Console.ReadKey();
                        if (tus.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Kampanyayı uygulamak isterseniz Y tuşuna basınız istemiyorsanız ENTER tuşuna basınız.");
                            tus = Console.ReadKey();
                            if (tus.Key == ConsoleKey.Y)
                            {
                                campaignManager.CampaignEntrence();
                                Console.Write(gamesNames[2] + gamePrices[2] + " ");
                                gameSalesManager.GamePurchase(game);
                                Console.WriteLine("İptal etmek için ESCAPE, iade etmek için DELETE tuşuna basınız.");
                                tus = Console.ReadKey();
                                if (tus.Key == ConsoleKey.Escape)
                                {
                                    Console.Write(gamesNames[2] + gamePrices[2] + " ");
                                    gameSalesManager.OrderCancellation(game);
                                }
                                else if (tus.Key == ConsoleKey.Delete)
                                {
                                    gameSalesManager.GameRefund(game);
                                }
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Satın alma işlemini onaylıyorsanız ENTER ı, onaylamıyorsanız ESCAPE i tuşlayınız.");
                        tus = Console.ReadKey();
                        if (tus.Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("Kampanyayı uygulamak isterseniz Y tuşuna basınız istemiyorsanız ENTER tuşuna basınız.");
                            tus = Console.ReadKey();
                            if (tus.Key == ConsoleKey.Y)
                            {
                                campaignManager.CampaignEntrence();
                                Console.Write(gamesNames[3] + gamePrices[3] + " ");
                                gameSalesManager.GamePurchase(game);
                                Console.WriteLine("İptal etmek için ESCAPE, iade etmek için DELETE tuşuna basınız.");
                                tus = Console.ReadKey();
                                if (tus.Key == ConsoleKey.Escape)
                                {
                                    Console.Write(gamesNames[3] + gamePrices[3] + " ");
                                    gameSalesManager.OrderCancellation(game);
                                }
                                else if (tus.Key == ConsoleKey.Delete)
                                {
                                    gameSalesManager.GameRefund(game);
                                }
                            }
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lütfen doğru bilgi giriniz.");
            }
        }
    }
}
