using ImpluseZone.DataAccess.Abstract;
using ImpluseZone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpluseZone.DataAccess.Concrete
{
    public class ImpluseRepository : IImpluseRepository
    {
        public Impluse CreateImpluse(Impluse ımpluse)
        {
            using (var impluseDbContext = new ImpluseDbContext())
            {
                impluseDbContext.Impluses.Add(ımpluse);
                impluseDbContext.SaveChanges();
                return ımpluse;
            }
        }

        public void DeleteImpluse(int id)
        {
            using (var impluseDbContext = new ImpluseDbContext())
            {
                var deletedImpluse = GetImpluseById(id);
                impluseDbContext.Impluses.Remove(deletedImpluse);
                impluseDbContext.SaveChanges();
            }
        }

        public List<Impluse> GetAllImpluses()
        {
            using(var impluseDbContext = new ImpluseDbContext())
            {
                return impluseDbContext.Impluses.ToList();
            }
        }

        public Impluse GetImpluseById(int id)
        {
            using (var impluseDbContext = new ImpluseDbContext())
            {
                return impluseDbContext.Impluses.Find(id);
            }
        }

        public Impluse UpdateImpluse(Impluse ımpluse)
        {
            using (var impluseDbContext = new ImpluseDbContext())
            {
                impluseDbContext.Impluses.Update(ımpluse);
                impluseDbContext.SaveChanges();
                return ımpluse;
            }
        }
    }
}
