using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace TesteNextSoft
{
    public class ClienteService
    {
        public void cadastrarCliente(string nome, string cpf, string email, string telefone)
        {
            StringBuilder query = new StringBuilder();
            var session = new DBSession();

            query.Append(" INSERT INTO CLIENTE (");
            query.Append("NOME,CPF,EMAIL,TELEFONE) ");
            query.AppendFormat("VALUES ('{0}','{1}','{2}','{3}')",nome,cpf,email,telefone);           

            Query executar = session.CreateQuery(query.ToString());
            IDataReader reader = executar.ExecuteQuery();
            
        }
        public void cadastrarEndereco(string cpf, string tipo, string logradouro, string numero, string complemento, string bairro, string estado, string cidade)
        {
            StringBuilder query = new StringBuilder();
            var session = new DBSession();

            query.Append(" INSERT INTO ENDERECOS (");
            query.Append("CPF, TIPO, LOGRADOURO, NUMERO,COMPLEMENTO, BAIRRO, CIDADE, ESTADO) ");
            query.AppendFormat("VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", cpf, tipo, logradouro, numero, complemento, bairro, estado, cidade);

            Query executar = session.CreateQuery(query.ToString());
            IDataReader reader = executar.ExecuteQuery();

        }
        public bool validarExistCPF(string cpfP)
        {
            StringBuilder query = new StringBuilder();
            var session = new DBSession();

            query.Append(" SELECT CPF");
            query.Append(" FROM CLIENTE");
            query.AppendFormat(" WHERE CPF = '{0}'",cpfP);            

            Query executar = session.CreateQuery(query.ToString());
            IDataReader reader = executar.ExecuteQuery();

            using (reader)
            {
                if (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["CPF"].ToString()))
                        return false;
                }
                return true;
            }
        }
    }
}