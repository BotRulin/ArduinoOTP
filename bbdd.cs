using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Utils
{
    /// <summary>
    /// Classe que se encarga de todos los metodos para acceder a la bbdd
    /// </summary>
    /// 
    public class bbdd
    {
        private string connectionString;
        private SqlConnection sqlConnection;
        private DataSet dataSet;

        /// <summary>
        /// Metodo que te conecta a la bbdd, lo usaran otras funciones.
        /// </summary>
        /// <returns>No devuelve nada ya que es un void</returns>

        private void Connectar()
        {
            connectionString = ConfigurationManager.ConnectionStrings["M13ConnectionString"].ConnectionString;

            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(connectionString);
            }

            if (sqlConnection.State != ConnectionState.Open)
            {
                try
                {
                    sqlConnection.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"There was a critical error: {e}");
                }
                
            }
        }

        /// <summary>
        /// Metodo que te desconecta a la bbdd, lo usaran otras funciones.
        /// </summary>
        /// <returns>No devuelve nada ya que es un void</returns>

        private void Desconnectar()
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Metodo que te trae una tabla de la bbdd.
        /// </summary>
        /// <param name="tableName">Nombre de la tabla de la bbdd de la cual le quieres hacer select</param>
        /// <returns>Devuelve un DataSet de la consulta a la bbdd de la tabla que le pasaste el nombre</returns>
        /// <example>
        /// <returns>dataSet lleno de datos si es que los hay</returns>
        /// </example>
        public DataSet PortarTaula(string tableName)
        {
            Connectar();

            dataSet = new DataSet();
            string query = string.Format("Select * from {0}", tableName);

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataSet);
            }

            Desconnectar();

            return dataSet;
        }

        /// <summary>
        /// Metodo que te trae una tabla de la bbdd pasandole tu una query completa.
        /// </summary>
        /// <param name="query">Query que le pasas al metodo</param>
        /// <returns>Devuelve un DataSet de la query que le has mandado para la bbdd</returns>
        /// <example>
        /// <returns>dataSet lleno de datos si es que los hay</returns>
        /// </example>

        public DataSet PortarPerConsulta(string query)
        {
            Connectar();

            dataSet = new DataSet();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataSet);
            }

            Desconnectar();

            return dataSet;
        }

        /// <summary>
        /// Metodo que te trae una tabla de la bbdd pasandole tu una query completa.
        /// </summary>
        /// <param name="query">Query que le pasas al metodo</param>
        /// <param name="tableName">Nombre que le pones al dataset</param>
        /// <returns>Devuelve un DataSet de la query que le has mandado para la bbdd y le pone el nombre al dataset que tu elijas</returns>
        /// <example>
        /// <returns>dataSet lleno de datos si es que los hay</returns>
        /// </example>

        public DataSet PortarPerConsulta(string query, string tableName)
        {
            Connectar();

            dataSet = new DataSet();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                adapter.Fill(dataSet, tableName);
            }

            Desconnectar();

            return dataSet;
        }

        /// <summary>
        /// Metodo que le pasas una query y un dataset y te actualiza la tabla en la bbdd.
        /// </summary>
        /// <param name="query">Query que le pasas al metodo</param>
        /// <param name="dataSet">dataset modificado que le mandas</param>
        /// <returns>Actualiza la bbdd con los datos del dataset que le mandes</returns>

        public void Actualitzar(string query, DataSet dataSet)
        {
            Connectar();

            using (SqlDataAdapter adapter = new SqlDataAdapter(query, sqlConnection))
            {
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);


                adapter.Update(dataSet.Tables[0]);
            }

            Desconnectar();
        }

        /// <summary>
        /// Metodo que ejecuta una query en la bbdd no tiene porque devolver nada, puede hacer cualquier accion.
        /// </summary>
        /// <param name="query">Query que le pasas al metodo</param>
        /// <returns>Ejecuta la query en la bbdd</returns>

        public void Executa(string query)
        {
            Connectar();

            using (SqlCommand command = new SqlCommand(query, sqlConnection))
            {
                command.ExecuteNonQuery();
            }

            Desconnectar();
        }

        /// <summary>
        /// Metodo que te trae una tabla de la bbdd pasandole solo el campo de interes, en este caso el usuario, evita sqlinjections ya que hace una consulta parametrizada.
        /// </summary>
        /// <param name="user">Nombre del usuario al cual le quieres hacer la consulta</param>
        /// <returns>Devuelve un dataSet con los datos del usuario pedido</returns>
        /// <example>
        /// <returns>dataSet lleno de datos si es que los hay</returns>
        /// </example>

        public DataSet consultaParametritzada(string user)
        {
            Connectar();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet resultDataSet = new DataSet();

                SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT * FROM [Users] WHERE [Login] = @User ";
                command.Parameters.Add(new SqlParameter("@User", user));

                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(resultDataSet);
                }
                Desconnectar();
                return resultDataSet;
            }
        }

    }
}

