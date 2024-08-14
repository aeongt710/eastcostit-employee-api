using DemoApi.Data;
using DemoApi.IRepository;
using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Repository
{
    public class GenderRepository : IGenderRepository
    {
        private readonly DemoDbContext _context;

        public GenderRepository(DemoDbContext context)
        {
            _context = context;
        }

        public async Task<bool> DeleteGender(int genderId)
        {
            var gender = await _context.Genders.FindAsync(genderId);
            if (gender == null)
            {
                throw new KeyNotFoundException("Gender not found");
            }

            _context.Genders.Remove(gender);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<Gender>> GetAllGenders()
        {
            return await _context.Genders.ToListAsync();
        }

        public async Task<Gender?> GetGenderById(int? genderId)
        {
            return await _context.Genders.Where(x => x.Id == genderId).FirstOrDefaultAsync();
        }

        public async Task<Gender> SaveGender(Gender gender)
        {
            await _context.Genders.AddAsync(gender);
            await _context.SaveChangesAsync();

            return gender;
        }

        public async Task<Gender> UpdateGender(Gender gender)
        {
            var existingGender = await _context.Genders.FindAsync(gender.Id);
            if (existingGender == null)
            {
                throw new KeyNotFoundException("Gender not found");
            }

            existingGender.Name = gender.Name;

            _context.Genders.Update(existingGender);
            await _context.SaveChangesAsync();

            return existingGender;
        }
    }
}
