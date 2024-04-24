using Microsoft.EntityFrameworkCore;
using WebApiExamen1.Data;
using WebApiExamen1.Models;

namespace WebApiExamen1.Repositories
{
    public class PersonajesRepository
    {
        private PersonajesContext context;

        public PersonajesRepository(PersonajesContext context)
        {
            this.context = context;
        }

        public async Task<List<PersonajeSeries>> GetPersonajeSeriesAsync()
        {
            return await this.context.PersonajesSeries.ToListAsync();
        }
        public async Task<List<PersonajeSeries>> FindPersonajeSeriesAsync(string serie)
        {
            return await this.context.PersonajesSeries.Where(x => x.Serie == serie).ToListAsync();
        }

        public async Task<List<string>> GetSeriesAsync()
        {
            var series = await this.context.PersonajesSeries
                                    .Select(ps => ps.Serie).Distinct()
                                    .ToListAsync();
            return series;
        }
        public async Task<PersonajeSeries> FindPersonajeIdAsync(int id)
        {
            return await this.context.PersonajesSeries.FirstOrDefaultAsync(x => x.IdPersonaje == id);
        }

        public async Task InsertarPersonajeSeriesAsync(PersonajeSeries per)
        {
            this.context.PersonajesSeries.Add(per);
            await this.context.SaveChangesAsync();
        }


        public async Task UpdatePersonajeSeriesAsync(PersonajeSeries per)
        {
            this.context.PersonajesSeries.Update(per);
            await this.context.SaveChangesAsync();
        }
        public async Task DeletePersonajeSeriesAsync(int id)
        {
            PersonajeSeries per = await this.FindPersonajeIdAsync(id);
            this.context.PersonajesSeries.Remove(per);
            await this.context.SaveChangesAsync();
        }
    }
}
