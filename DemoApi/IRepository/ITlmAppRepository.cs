using DemoApi.Models;

namespace DemoApi.IRepository
{
    public interface ITlmAppRepository
    {
        Task<IEnumerable<TlmApp>> GetAllTlmApps();
        Task<TlmApp?> GetTlmAppById(string id);
        Task<TlmApp> SaveTlmApp(TlmApp tlmApp);
        Task<TlmApp> UpdateTlmApp(TlmApp tlmApp);
        Task<bool> DeleteTlmApp(string id);
    }
}
