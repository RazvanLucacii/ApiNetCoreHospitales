using ApiNetCoreHospitales.Data;
using ApiNetCoreHospitales.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiNetCoreHospitales.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }

        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            return await this.context.Hospitales.ToListAsync();
        }

        public async Task<Hospital> GetHospitalAsync(int idHospital)
        {
            return await this.context.Hospitales.FirstOrDefaultAsync(x => x.IdHospital == idHospital);
        }

    }
}
