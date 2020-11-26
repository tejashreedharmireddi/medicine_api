using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medicine2.Repository;
using Medicine2.Model;

namespace Medicine2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
       
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MedicineController));
        private IMedicineRepository _repo;
        public MedicineController(IMedicineRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public ActionResult<List<MedicineListModel>> Get()
        {
            _log4net.Info("API initiated");
            _log4net.Info(" Http GET is accesed");
            return _repo.GetAll();
        }
    }
}
