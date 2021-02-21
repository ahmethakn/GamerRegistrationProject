using GamerRegistrationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerRegistrationProject.Abstract
{
    public interface IGameSalesManager
    {
        void GamePurchase(Game game);
        void GameRefund(Game game);
        void OrderCancellation(Game game);
    }
}
