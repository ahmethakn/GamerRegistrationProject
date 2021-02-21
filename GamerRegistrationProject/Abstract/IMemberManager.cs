using GamerRegistrationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamerRegistrationProject.Abstract
{
    public interface IMemberManager
    {
        void Save(Member member);
        void Update(Member member);
        void Delete(Member member);
    }
}
