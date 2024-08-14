using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.DataSeeding
{
    public class SeedManager
    {
        private readonly DbContext _context;

        public SeedManager(DbContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Set<Gender>().Any())
            {
                var genders = new List<Gender>
                {
                    new Gender {  Name = "Male" },
                    new Gender {  Name = "Female" },
                    new Gender { Name = "Other" }
                };

                _context.Set<Gender>().AddRange(genders);
                _context.SaveChanges();
            }
        }
    }
}
