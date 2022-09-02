using Kodehive5._0.Model.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kodehive.Service.Interface.Services
{
    public interface IMahasiswaService
    {
        public Task<bool> Create(Mahasiswa mahasiswa);
        public Task<List<Mahasiswa>> GetAll();
        public Task<bool> DeleteById(int id);
    }
}
