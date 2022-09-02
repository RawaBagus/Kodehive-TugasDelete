using Kodehive5.Data.Interface.Repositories;
using Kodehive.Service.Interface.Services;
using Kodehive5._0.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodehive5._0.Service.Services
{
    public class MahasiswaService : IMahasiswaService
    {
        private readonly IMahasiswaRepository mahasiswaRepository;

        public MahasiswaService(IMahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<bool> Create(Mahasiswa mahasiswa)
        {
            var result = await mahasiswaRepository.Create(mahasiswa);
            return result;
            
        }

        public async Task<bool> DeleteById(int id)
        {
            var result = await mahasiswaRepository.DeleteById(id);
            return result;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            List<Mahasiswa> result = new List<Mahasiswa>();
            result = await mahasiswaRepository.GetAll();
            return result;
        }
    }
}
