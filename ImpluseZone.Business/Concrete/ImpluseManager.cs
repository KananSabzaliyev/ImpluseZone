using ImpluseZone.Business.Abstract;
using ImpluseZone.DataAccess.Abstract;
using ImpluseZone.DataAccess.Concrete;
using ImpluseZone.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpluseZone.Business.Concrete
{
    public class ImpluseManager : IImpluseService
    {
        private IImpluseRepository _ımpluseRepository;
        public ImpluseManager(IImpluseRepository ımpluseRepository)
        {
            _ımpluseRepository = ımpluseRepository;
        }
        public Impluse CreateImpluse(Impluse ımpluse)
        {
            return _ımpluseRepository.CreateImpluse(ımpluse);
        }

        public void DeleteImpluse(int id)
        {
            _ımpluseRepository.DeleteImpluse(id);
        }

        public List<Impluse> GetAllImpluses()
        {
            return _ımpluseRepository.GetAllImpluses();
        }

        public Impluse GetImpluseById(int id)
        {
            return _ımpluseRepository.GetImpluseById(id);
        }

        public Impluse UpdateImpluse(Impluse ımpluse)
        {
            return _ımpluseRepository.UpdateImpluse(ımpluse);
        }
    }
}
