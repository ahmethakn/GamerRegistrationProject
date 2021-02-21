using GamerRegistrationProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerRegistrationProject.Concrete
{
    public class CampaignManager : ICampaignManager
    {
        public void CampaignDelete()
        {
            Console.WriteLine("Kampanya silinmiştir.");
        }

        public void CampaignEntrence()
        {
            Console.WriteLine("Kampanya eklenmiştir.");
        }

        public void CampaignUpdate()
        {
            Console.WriteLine("Kampanya güncellenmiştir.");
        }
    }
}
