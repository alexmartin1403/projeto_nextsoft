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
    public class EnderecosController : ApiController
    {
        SqlConnection con = new SqlConnection(@"Data Source=den1.mssql8.gear.host;Persist Security Info=True;User ID=banconextsoft;Password=next@1975");

        private banconextsoftEntities1 db = new banconextsoftEntities1();

        // GET: api/Enderecos
        public IQueryable<ENDERECOS> GetENDERECOS(string cpf)
        {
            return db.ENDERECOS.Where(c => c.CPF.Equals(cpf));
        }



        // PUT: api/Enderecos
        public string Put([FromBody] string inicio, string cpf, string tipo, string logradouro, string numero, string complemento, string bairro, string estado, string cidade, string tipo2)
        {
            SqlCommand cmd = new SqlCommand("UPDATE ENDERECOS SET TIPO = '" + tipo + "', LOGRADOURO = '" + logradouro + "', NUMERO = '" + numero + "', COMPLEMENTO = '" + complemento + "', BAIRRO = '" + bairro + "', ESTADO = '" + estado + "', CIDADE = '" + cidade + "'   WHERE CPF = '" + cpf + "' and TIPO = '" + tipo2 + "'", con);
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

        // POST: api/Enderecos
        public string Post([FromBody] string inicio, string cpf, string tipo, string logradouro, string numero, string complemento, string bairro, string estado, string cidade)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO ENDERECOS(CPF,TIPO,LOGRADOURO,NUMERO,COMPLEMENTO,BAIRRO,ESTADO,CIDADE) VALUES ('" + cpf + "','" + tipo + "','" + logradouro + "','" + numero + "','" + complemento + "','" + bairro + "','" + estado + "','" + cidade + "')", con);
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

        // DELETE: api/Enderecos/5
        public string Delete(string cpf)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM ENDERECOS WHERE CPF = '" + cpf + "'", con);
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

        private bool ENDERECOSExists(int id)
        {
            return db.ENDERECOS.Count(e => e.ID_END == id) > 0;
        }
    }
}