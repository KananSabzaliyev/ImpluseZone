using ImpluseZone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpluseZone.DataAccess.Abstract
{
    public interface IImpluseRepository
    {
        List<Impluse> GetAllImpluses();
        Impluse GetImpluseById(int id);
        Impluse CreateImpluse(Impluse ımpluse);
        Impluse UpdateImpluse(Impluse ımpluse);
        void DeleteImpluse(int id);
    }
}
