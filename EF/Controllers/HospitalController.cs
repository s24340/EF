using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using EF.DTO;
using EF.Repositories.Interfaces;

namespace EF.Controllers
{
    [Route("api/hospital")]
    [ApiController]
    [Authorize]
    public class HospitalController : ControllerBase
    {
        private readonly IHospitalDbRepository _repository;

        public HospitalController(IHospitalDbRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("doctors")]
        public async Task<IActionResult> GetDoctors()
        {
            var result = await _repository.GetDoctorsAsync();

            if (result == null || !result.Any())
                return NoContent();

            return Ok(result);
        }

        [HttpPost("doctors")]
        public async Task<IActionResult> AddDoctor([FromBody] DoctorDto dto)
        {
            var result = await _repository.AddDoctorAsync(dto);

            if (result != "Success!")
                return BadRequest((object)result);

            return Ok(result);
        }

        [HttpPut("doctors/{id}")]
        public async Task<IActionResult> ChangeDoctor([FromRoute] int id, [FromBody] DoctorDto dto)
        {
            var result = await _repository.ChangeDoctorAsync(id, dto);

            if (result != "Success!")
                return NotFound((object)result);

            return Ok(result);
        }

        [HttpDelete("doctors/{id}")]
        public async Task<IActionResult> DeleteDoctor([FromRoute] int id)
        {
            var result = await _repository.DeleteDoctorAsync(id);

            if (result != "Success!")
                return BadRequest((object)result);

            return Ok(result);
        }

        [HttpGet("prescriptions/{id}")]
        public async Task<IActionResult> GetPrescription([FromRoute] int id)
        {
            var result = await _repository.GetPrescriptionAsync(id);

            if (result == null)
                return NoContent();

            return Ok(result);
        }
    }
}
