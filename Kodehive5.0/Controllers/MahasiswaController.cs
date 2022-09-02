using Kodehive.Service.Interface.Services;
using Kodehive5._0.Model.Entities;
using Kodehive5._0.Service.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;

namespace Kodehive.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private readonly IMahasiswaService mahasiswaService;

        public MahasiswaController(IMahasiswaService mahasiswaService)
        {
            this.mahasiswaService = mahasiswaService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Mahasiswa model)
        {
            var result = await mahasiswaService.Create(model);
            return Ok(result);
        }
        [HttpGet]
        public async Task<List<Mahasiswa>> GetAllData()
        {

            List<Mahasiswa> result = await mahasiswaService.GetAll();
            return result;
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById([FromBody]int id)
        {
            var result = await mahasiswaService.DeleteById(id);
            return Ok(result);
        }
    }
}
