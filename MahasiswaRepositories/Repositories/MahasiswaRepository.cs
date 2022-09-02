
using Kodehive5.Data.Interface.Repositories;
using Kodehive.Service.Interface.Services;
using Kodehive5._0.Model.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Kodehive.Data.Repositories
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly IDbService _dbService;

        public MahasiswaRepository(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> Create(Mahasiswa mahasiswa)
        {
            await _dbService.ModifyData("insert into mahasiswa (id, nama, alamat, usia, jurusan_id) " +
                "values (@id,@nama,@alamat,@usia,@jurusan_id)", mahasiswa);
            return true;
        }

        public async Task<bool> DeleteById(int Id)
        {
            await _dbService.ModifyData("DELETE from mahasiswa where id = @id;", new { id = Id });
            return true;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            List<Mahasiswa> result= await _dbService.Get<Mahasiswa>("select * from mahasiswa",new {});
            return result;
        }
        
    }
}
