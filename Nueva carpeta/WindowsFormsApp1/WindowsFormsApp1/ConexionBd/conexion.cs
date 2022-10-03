using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.ConexionBd
{
    class conexion
    {
        public String Alertas = "";
        public FbConnection cnn;
        public FbConnection conectar(String conn)
        {
            

            try
            {
                cnn = new FbConnection(conn);
                if (cnn.State != System.Data.ConnectionState.Open)
                {
                    cnn.Open();
                    Alertas = "Conexion Exitosa!";
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error al conectar la base de datos: " + e);
            }
            return cnn;
        }
        public FbConnection desconectar()
        {
            try
            {
                if (cnn.State != System.Data.ConnectionState.Closed)
                    cnn.Close();
            }
            catch (Exception e)
            {
                Alertas = "Error al cerrar la BDD: " + e;
            }
            return cnn;
        }
    }
}
