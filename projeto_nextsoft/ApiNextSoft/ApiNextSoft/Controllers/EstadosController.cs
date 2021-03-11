using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApiNextSoft.Models;

namespace ApiNextSoft.Controllers
{
    public class EstadosController : ApiController
    {
        private banconextsoftEntities1 db = new banconextsoftEntities1();

        // GET: api/Estados
        public IQueryable<ESTADOS> GetESTADOS()
        {
            return db.ESTADOS;
        }

        // GET: api/Estados/5
        [ResponseType(typeof(ESTADOS))]
        public async Task<IHttpActionResult> GetESTADOS(int id)
        {
            ESTADOS eSTADOS = await db.ESTADOS.FindAsync(id);
            if (eSTADOS == null)
            {
                return NotFound();
            }

            return Ok(eSTADOS);
        }

        // PUT: api/Estados/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutESTADOS(int id, ESTADOS eSTADOS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eSTADOS.id)
            {
                return BadRequest();
            }

            db.Entry(eSTADOS).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ESTADOSExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Estados
        [ResponseType(typeof(ESTADOS))]
        public async Task<IHttpActionResult> PostESTADOS(ESTADOS eSTADOS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ESTADOS.Add(eSTADOS);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ESTADOSExists(eSTADOS.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eSTADOS.id }, eSTADOS);
        }

        // DELETE: api/Estados/5
        [ResponseType(typeof(ESTADOS))]
        public async Task<IHttpActionResult> DeleteESTADOS(int id)
        {
            ESTADOS eSTADOS = await db.ESTADOS.FindAsync(id);
            if (eSTADOS == null)
            {
                return NotFound();
            }

            db.ESTADOS.Remove(eSTADOS);
            await db.SaveChangesAsync();

            return Ok(eSTADOS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ESTADOSExists(int id)
        {
            return db.ESTADOS.Count(e => e.id == id) > 0;
        }
    }
}