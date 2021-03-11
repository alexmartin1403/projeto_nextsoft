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
    public class CidadesController : ApiController
    {
        private banconextsoftEntities1 db = new banconextsoftEntities1();

        // GET: api/Cidades
        public IQueryable<CIDADES> GetCIDADES()
        {
            return db.CIDADES.OrderBy(c => c.nome);

        }

        

        // PUT: api/Cidades/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCIDADES(int id, CIDADES cIDADES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cIDADES.id)
            {
                return BadRequest();
            }

            db.Entry(cIDADES).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CIDADESExists(id))
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

        // POST: api/Cidades
        [ResponseType(typeof(CIDADES))]
        public async Task<IHttpActionResult> PostCIDADES(CIDADES cIDADES)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CIDADES.Add(cIDADES);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CIDADESExists(cIDADES.id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = cIDADES.id }, cIDADES);
        }

        // DELETE: api/Cidades/5
        [ResponseType(typeof(CIDADES))]
        public async Task<IHttpActionResult> DeleteCIDADES(int id)
        {
            CIDADES cIDADES = await db.CIDADES.FindAsync(id);
            if (cIDADES == null)
            {
                return NotFound();
            }

            db.CIDADES.Remove(cIDADES);
            await db.SaveChangesAsync();

            return Ok(cIDADES);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CIDADESExists(int id)
        {
            return db.CIDADES.Count(e => e.id == id) > 0;
        }
    }
}