using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryEstructuraDeDatos
{
    class clsConsultarBD
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string cadena = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source = Libreria.mdb";

        public void Listar(DataGridView grilla, string varInstruccionSQL)
        {
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();
               
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = varInstruccionSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Resultado");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Resultado"];
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        public void Listar(DataGridView grilla)
        {
            try
            {
                conexion.ConnectionString = cadena;
                conexion.Open();
                
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "Libro";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Libro");

                grilla.DataSource = null;
                grilla.DataSource = DS.Tables["Libro"];
                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                conexion.Close();

            }
        }
    }
}
