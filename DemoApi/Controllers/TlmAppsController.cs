using DemoApi.IRepository;
using DemoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TlmAppsController : ControllerBase
    {
        private readonly ITlmAppRepository _tlmAppRepository;

        public TlmAppsController(ITlmAppRepository tlmAppRepository)
        {
            _tlmAppRepository = tlmAppRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TlmApp>>> GetAllTlmApps()
        {
            var tlmApps = await _tlmAppRepository.GetAllTlmApps();
            return Ok(tlmApps);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TlmApp>> GetTlmAppById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return BadRequest("TlmApp ID cannot be null or empty.");
            }

            var tlmApp = await _tlmAppRepository.GetTlmAppById(id);

            if (tlmApp == null)
            {
                return NotFound("TlmApp not found.");
            }

            return Ok(tlmApp);
        }

        [HttpPost]
        public async Task<ActionResult<TlmApp>> SaveTlmApp(TlmApp tlmApp)
        {
            var createdTlmApp = await _tlmAppRepository.SaveTlmApp(tlmApp);
            return CreatedAtAction(nameof(GetTlmAppById), new { id = createdTlmApp.TJX_App_ID }, createdTlmApp);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<TlmApp>> UpdateTlmApp(string id, TlmApp tlmApp)
        {
            if (id != tlmApp.TJX_App_ID)
            {
                return BadRequest("TlmApp ID mismatch.");
            }

            try
            {
                var updatedTlmApp = await _tlmAppRepository.UpdateTlmApp(tlmApp);
                return Ok(updatedTlmApp);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("TlmApp not found.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteTlmApp(string id)
        {
            try
            {
                var success = await _tlmAppRepository.DeleteTlmApp(id);
                return Ok(success);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("TlmApp not found.");
            }
        }
    }
}
