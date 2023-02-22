using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using prueba_intento2.Models;

namespace prueba_intento2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CiudadanoController : ControllerBase
    {
        private readonly BolsaEmpleoDbContext _context;

        public CiudadanoController(BolsaEmpleoDbContext context)
        {

            _context = context;

        }


        [HttpGet]
        public async Task<List<Ciudadano>> Get()
        {
            return await _context.Ciudadanos.ToListAsync();
        }


        [HttpPost]
        public async Task<OkResult> Post(Ciudadano ciudadano)

        {

            _context.Add(ciudadano);
            await _context.SaveChangesAsync();
            return Ok();


        }


        [HttpPut]
        public async Task<object> Put(Ciudadano ciudadano)
        {
            if (ciudadano == null || ciudadano.Id == null)
            {
                return BadRequest();


            }

            var ciudadano1 = await _context.Ciudadanos.FindAsync(ciudadano.Id);

            if (ciudadano1 == null)
            {
                return BadRequest();


            }
            var updateCiudadano = new Ciudadano
            {
                Cedula = ciudadano.Cedula ?? ciudadano1.Cedula,
                Nombre = ciudadano.Nombre ?? ciudadano1.Nombre,
                Apellido = ciudadano.Apellido ?? ciudadano1.Apellido,
                Profesion = ciudadano.Profesion ?? ciudadano1.Profesion,
                Correo = ciudadano.Correo ?? ciudadano1.Correo,
                FechaNacimiento = ciudadano.FechaNacimiento == null ? ciudadano1.FechaNacimiento : ciudadano.FechaNacimiento,
                TipoDocumento = ciudadano.TipoDocumento == null ? ciudadano.TipoDocumento : ciudadano1.TipoDocumento,
                AspiracionSalarial = ciudadano.AspiracionSalarial == null ? ciudadano.AspiracionSalarial : ciudadano1.AspiracionSalarial

            };

            ciudadano1 = updateCiudadano;
            await _context.SaveChangesAsync();
            return Ok();


        }


        [HttpDelete("{cedula}")]
        public async Task<object> Delete(int cedula)
        {
            var ciudadano = await _context.Ciudadanos.FindAsync(cedula);

            if (ciudadano == null)
            {
                return NotFound();



            }
            _context.Ciudadanos.Remove(ciudadano);
            await _context.SaveChangesAsync();
            return Ok();


        }



    }
}
