using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ApiNextSoft.Models;

namespace ApiNextSoft.Controllers
{
    public class ClientesController : ApiController
    {
        SqlConnection con = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID=banconextsoft;Password=next@1975");

        private banconextsoftEntities1 db = new banconextsoftEntities1();

        // GET: api/Clientes
        public IQueryable<CLIENTE> GetCLIENTE(string cpf)
        {
            return db.CLIENTE.Where(c => c.CPF.Equals(cpf));
        }

        // PUT: api/Clientes
        public string Put([FromBody] string inicio, string cpf, string nome, string email, string telefone)
        {
            SqlCommand cmd = new SqlCommand("UPDATE CLIENTE SET NOME = '" + nome + "', EMAIL ='" + email + "', TELEFONE ='" + telefone + "' WHERE CPF = '" + cpf + "'", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                return "ok";
            }
            else
            {
                return "nok";
            }
        }

        // POST: api/Clientes
        [ResponseType(typeof(CLIENTE))]
        public async Task<IHttpActionResult> PostCLIENTE(CLIENTE cLIENTE)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CLIENTE.Add(cLIENTE);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cLIENTE.ID_CLIENTE }, cLIENTE);
        }

        // DELETE: api/Clientes
        public string Delete(string cpf)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTE WHERE CPF = '" + cpf + "'", con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
            {
                return "ok";
            }
            else
            {
                return "nok";
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CLIENTEExists(int id)
        {
            return db.CLIENTE.Count(e => e.ID_CLIENTE == id) > 0;
        }
    }
}