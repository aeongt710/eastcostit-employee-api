using DemoApi.IRepository;
using DemoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IGenderRepository _genderRepository;

        public GendersController(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Gender>>> GetAllGenders()
        {
            var genders = await _genderRepository.GetAllGenders();
            return Ok(genders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Gender>?> GetGenderById(int? id)
        {
            if (id == null)
            {
                return BadRequest("Gender ID cannot be null.");
            }

            var gender = await _genderRepository.GetGenderById(id);

            if (gender == null)
            {
                return NotFound("Gender not found.");
            }

            return Ok(gender);
        }

        [HttpPost]
        public async Task<ActionResult<Gender>> SaveGender(Gender gender)
        {
            var createdGender = await _genderRepository.SaveGender(gender);
            return CreatedAtAction(nameof(GetGenderById), new { id = createdGender.Id }, createdGender);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Gender>> UpdateGender(int id, Gender gender)
        {
            if (id != gender.Id)
            {
                return BadRequest("Gender ID mismatch.");
            }

            var updatedGender = await _genderRepository.UpdateGender(gender);

            if (updatedGender == null)
            {
                return NotFound("Gender not found.");
            }

            return Ok(updatedGender);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteGender(int id)
        {
            try
            {
                var success = await _genderRepository.DeleteGender(id);
                return Ok(success);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Gender not found.");
            }
        }
    }
}
