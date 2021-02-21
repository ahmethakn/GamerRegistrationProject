using GamerRegistrationProject.Abstract;
using GamerRegistrationProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerRegistrationProject.Concrete
{
    public class MemberManager : IMemberManager
    {
        public void Delete(Member member)
        {
            Console.WriteLine("Kaydınız Silinmiştir.");
        }

        public void Save(Member member)
        {
            Console.WriteLine("Kaydınız Alınmıştır.");        
        }
        public void Update(Member member)
        {
            Console.WriteLine("Kaydınız Alınmıştır.");
        }
        public bool CheckIfRealPerson(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(member.NationalityId, member.FirstName, member.LastName, member.DateOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }
        
    }
}
