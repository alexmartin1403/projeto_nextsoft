using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Onde executa os metodos
    /// </summary>
    public class Query
    {
        private SqlCommand comando;

        public Query(String sql, SqlConnection connection)
        {
            try
            {
                comando = connection.CreateCommand();
                comando.CommandText = sql;
            }
            catch (Exception ex)
            {
                comando.Dispose();
                throw new Exception(ex.Message);
            }
        }

        public Query(String sql, SqlConnection connection, string conexao)
        {
            SqlTransaction trans = connection.BeginTransaction("SisCastelo");
            try
            {
                comando = connection.CreateCommand();

                //comando.Connection = connection;
                //comando.Transaction = trans;

                comando = new SqlCommand(sql, connection, trans);
                comando.ExecuteNonQuery();
                trans.Commit();
            }
            catch (Exception ex)
            {
                comando.Dispose();
                trans.Rollback();
                throw new Exception(ex.Message);
            }
        }

        public DataSet ExecuteDataSet(string table)
        {
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void ExecuteNonQuery()
        {
            comando.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteQuery()
        {
            return comando.ExecuteReader();
        }

        public DataTable fillDataTable(string table)
        {
            SqlDataAdapter da = new SqlDataAdapter(comando);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public Query SetParameter(String nome, object valor)
        {
            var parametro = comando.CreateParameter();
            parametro.ParameterName = nome;
            parametro.Value = valor;
            comando.Parameters.Add(parametro);
            return this;
        }

    }

    /// <summary>
    /// Conexão com o banco SqlServer
    /// </summary>
    public class DBSession
    {
        private SqlConnection conexao;

        public DBSession()
        {
            try
            {
                conexao = new SqlConnection("Data Source=den1.mssql8.gear.host;User ID=banconextsoft;Password=next@1975");

                conexao.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("Banco Inválido" + ex.Message);
            }
        }

        public void Close()
        {
            conexao.Close();
        }

        public Query CreateQuery(String sql)
        {
            return new Query(sql, conexao);
        }

        public Query ExecuteTransaction(string query)
        {
            return new Query(query, conexao, string.Empty);
        }

        public void ExecuteSqlTransaction(string query)
        {
            SqlCommand command = conexao.CreateCommand();
            SqlTransaction transaction;

            transaction = conexao.BeginTransaction("SisCastelo");

            command.Connection = conexao;
            command.Transaction = transaction;

            try
            {
                command.CommandText = query;
                command.ExecuteNonQuery();

                transaction.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    transaction.Rollback();
                }
                catch (Exception ex2)
                {
                    Console.WriteLine("Rollback Exception Type: {0}", ex2.GetType());
                    Console.WriteLine("  Message: {0}", ex2.Message);
                }
            }
        }
    }
}