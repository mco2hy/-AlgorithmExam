using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sinav2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public AddressesController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var addresses = _unitOfWork.AddressRepository.GetAll();
            return new JsonResult(addresses);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.Address address)
        {
            _unitOfWork.AddressRepository.Insert(address);
            _unitOfWork.Complete();
            return new JsonResult(address);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.Address address)
        {
            _unitOfWork.AddressRepository.Update(address);
            _unitOfWork.Complete();
            return new JsonResult(address);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.AddressRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var addresses = _unitOfWork.AddressRepository.GetById(id);
            return new JsonResult(addresses);
        }
    }
}