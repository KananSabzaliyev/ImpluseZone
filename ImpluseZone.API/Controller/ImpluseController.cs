using ImpluseZone.Business.Abstract;
using ImpluseZone.Business.Concrete;
using ImpluseZone.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpluseZone.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpluseController : ControllerBase
    {
        private IImpluseService _ımpluseService;
        public ImpluseController(IImpluseService ımpluseService)
        {
            _ımpluseService = ımpluseService;
        }
        [HttpGet]
        public List<Impluse> Get()
        {
            return _ımpluseService.GetAllImpluses();
        }
        [HttpGet("{id}")]
        public Impluse Get(int id)
        {
            return _ımpluseService.GetImpluseById(id);
        }
        [HttpPost]
        public Impluse Post([FromBody]Impluse ımpluse)
        {
            return _ımpluseService.CreateImpluse(ımpluse);
        }
        [HttpPut]
        public Impluse Put([FromBody] Impluse ımpluse)
        {
            return _ımpluseService.UpdateImpluse(ımpluse);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ımpluseService.DeleteImpluse(id);
        }
    }
}
