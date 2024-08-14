using DemoApi.Models;

namespace DemoApi.IRepository
{
    public interface IGenderRepository
    {
        Task<bool> DeleteGender(int genderId);
        Task<IEnumerable<Gender>> GetAllGenders();
        Task<Gender?> GetGenderById(int? genderId);
        Task<Gender> SaveGender(Gender gender);
        Task<Gender> UpdateGender(Gender gender);
    }
}
