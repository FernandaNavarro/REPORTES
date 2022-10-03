using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ConexionBd;

namespace WindowsFormsApp1.Consultas
{
    class consulta
    {
        List<String> conexiones,sucursales;
        List<DataTable> listTablas = new List<DataTable>();        
        public int mayor = 0;
        FbConnection cnn;
        conexion objConexion = new conexion();
        public List<String> RegresaSucursal()
        {
            conexiones = new List<string>();
            sucursales = new List<string>();
            conexiones.Add("GORDOA 32");
            conexiones.Add("User=SYSDBA; Password=LpAcdnE; Database=E:\\Bases Datos\\JECOR 2020.FDB; " +
              "Datasource =192.168.10.200; Port =3051; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");

            conexiones.Add("TURCIO");
            conexiones.Add("User=SYSDBA; Password=B0l@g3t1tJ; Database=E:\\BASES DE DATOS\\JECOR 2018.FDB; " +
              "Datasource =192.168.15.202; Port =3053; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");        

            conexiones.Add("PAEZ STILLE");
            conexiones.Add("User=SYSDBA; Password=masterkey; Database=E:\\Bases de datos\\JECOR PAEZ STILLE.FDB; " +
              "Datasource =192.168.15.203; Port =3052; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");

            conexiones.Add("ALBERTO CARDENAS");
            conexiones.Add("User=SYSDBA; Password=ducor2; Database=E:\\Bases de Datos\\JECOR 2020.FDB; " +
              "Datasource =192.168.15.201; Port =; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");

            conexiones.Add("COLIMA CENTRO");
            conexiones.Add("User=SYSDBA; Password=B0l@g3t1tJ; Database=E:\\Bases de datos\\JECOR SA DE CV 2018.FDB; " +
              "Datasource =colimajec.ddns.net; Port =3054; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");

            conexiones.Add("COLIMA CEREALES");
            conexiones.Add("User=SYSDBA; Password=B0l@g3t1tJ; Database=E:\\Bases de datos\\JECOR SA DE CV 2018.FDB; " +
              "Datasource =colimajec.ddns.net; Port =3054; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");

            conexiones.Add("COLINAS DEL REY");
            conexiones.Add("User=SYSDBA; Password=masterkey; Database=E:\\Bases de Datos\\JECOR 2020.FDB; " +
              "Datasource =villarey.ddns.net; Port =3056; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");

            conexiones.Add("VILLA DE ALVAREZ");
            conexiones.Add("User=SYSDBA; Password=masterkey; Database=E:\\Bases de Datos\\JECOR SA DE CV.FDB; " +
              "Datasource =villajecor.ddns.net; Port =3055; Library=C:\\Program Files (x86)\\Firebird\\Firebird_3_0\\fbclient.dll;");
            return conexiones;
        }
        public void generaReporte(String fechaInicio, String fechaFinal,String sucursal)
        {
            String consultaVe = "",consultaPv="";
            Boolean banderoa = false;
            for (int x = 0; x < sucursales.Count; x++)
                if (sucursales[x].Equals(sucursal))
                {
                    MessageBox.Show("Ya se cargaron los datos de la sucursal: " + sucursal);
                    banderoa = true;
                    break;
                }
            if (banderoa == false)
            {
                if (sucursal.Equals("GORDOA 32"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND(ALMACEN_ID = 182727 OR ALMACEN_ID = 182728) AND folio LIKE 'F%'";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND(ALMACEN_ID = 182727 OR ALMACEN_ID = 182728)";
                }
                if (sucursal.Equals("TURCIO"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND folio LIKE 'F%' AND ALMACEN_ID = 179263";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND ALMACEN_ID = 179263";
                }
                if (sucursal.Equals("PAEZ STILLE"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND folio LIKE 'F%' AND ALMACEN_ID = 186107";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND ALMACEN_ID =186107";
                }

                if (sucursal.Equals("ALBERTO CARDENAS"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND folio LIKE 'F%' AND ALMACEN_ID = 181614";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND ALMACEN_ID =181614";
                }
                if (sucursal.Equals("COLIMA CENTRO"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND folio LIKE 'F%' AND ALMACEN_ID = 1357";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND ALMACEN_ID =1357";
                }
                if (sucursal.Equals("COLIMA CEREALES"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND folio LIKE 'F%' AND ALMACEN_ID = 1368";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND ALMACEN_ID =1368";
                }

                if (sucursal.Equals("COLINAS DEL REY"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND folio LIKE 'F%' AND ALMACEN_ID = 3012";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND ALMACEN_ID =3012";
                }
                if (sucursal.Equals("VILLA DE ALVAREZ"))
                {
                    consultaVe = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_VE " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND folio LIKE 'F%' AND ALMACEN_ID = 5367";

                    consultaPv = "SELECT FOLIO, USUARIO_CREADOR,FECHA_HORA_CREACION, USUARIO_AUT_MODIF, FECHA_HORA_ULT_MODIF " +
                        "FROM DOCTOS_PV " +
                        "WHERE FECHA_HORA_CREACION!= FECHA_HORA_ULT_MODIF AND FECHA BETWEEN '" + fechaInicio + "' AND '" + fechaFinal + "' " +
                        "AND ALMACEN_ID =5367";
                }
                for (int x = 0; x < conexiones.Count; x += 2)
                    if (sucursal.Equals(conexiones[x]))
                    {
                        GeneraConsulta(consultaVe, consultaPv, sucursal, conexiones[x + 1]);
                        break;
                    }
            }

        }
        public void GeneraConsulta(String consultaVE,String consultaPV,String sucursal,string conexion)
        {
            cnn=objConexion.conectar(conexion);
            DataTable tablaPV = new DataTable();
            DataTable tablaVE = new DataTable();

            tablaPV.Columns.Add("FOLIO", typeof(String));
            tablaPV.Columns.Add("USUARIO CREADOR", typeof(String));
            tablaPV.Columns.Add("FECHA DE CREACION", typeof(String));
            tablaPV.Columns.Add("USUARIO_AUT_MODIF", typeof(String));
            tablaPV.Columns.Add("FECHA DE MODIFICACION", typeof(String));

            tablaVE.Columns.Add("FOLIO", typeof(String));
            tablaVE.Columns.Add("USUARIO CREADOR", typeof(String));
            tablaVE.Columns.Add("FECHA DE CREACION", typeof(String));
            tablaVE.Columns.Add("USUARIO_AUT_MODIF", typeof(String));
            tablaVE.Columns.Add("FECHA DE MODIFICACION", typeof(String));

            DataRow renglon;
            FbCommand cmd = new FbCommand(consultaPV, cnn);
            FbDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    renglon = tablaPV.NewRow();
                    renglon[0] = reader.GetString(0).Trim();
                    renglon[1] = reader.GetString(1).Trim();
                    renglon[2] = reader.GetString(2).Trim();
                    renglon[3] = reader.GetString(3).Trim();
                    renglon[4] = reader.GetString(4).Trim();
                    tablaPV.Rows.Add(renglon);

                }                
            }
            catch (Exception e)
            {
                reader.Close();                
            }
            renglon = null;
            reader.Close();
            cmd = new FbCommand(consultaVE, cnn);
            reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    renglon = tablaVE.NewRow();
                    renglon[0] = reader.GetString(0).Trim();
                    renglon[1] = reader.GetString(1).Trim();
                    renglon[2] = reader.GetString(2).Trim();
                    renglon[3] = reader.GetString(3).Trim();
                    renglon[4] = reader.GetString(4).Trim();
                    tablaVE.Rows.Add(renglon);

                }
            }
            catch (Exception e)
            {
                reader.Close();
            }
            sucursales.Add(sucursal);
            listTablas.Add(tablaVE);
            listTablas.Add(tablaPV);
            cnn = objConexion.desconectar();
            MessageBox.Show("Los documentos de la sucursal "+sucursal+" Se han Cargado con exito!");            
        }
        public void Generador()
        {
            int cont = 0;
            mayor = 0;
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            for (int x=0; x<listTablas.Count; x+=2)
            {
                exportaExcel(sucursales[cont], listTablas[x], listTablas[x + 1],x,excel);
                cont++;
            }
        }

        public void exportaExcel(String sucursal,DataTable tablaVE, DataTable tablaPV,int fin,Microsoft.Office.Interop.Excel.Application excel)
        {

            
            if (mayor==0)
            {                                

                excel.Cells[1, 1] = sucursal;
                excel.Cells[1, 3] = "DOCUMENTOS DE VENTAS";

                for (int x = 0; x < tablaVE.Columns.Count; x++)
                {
                    excel.Cells[2, x + 1] = tablaVE.Columns[x].ToString();
                    for (int y = 0; y < tablaVE.Rows.Count; y++)
                        excel.Cells[y + 3, x + 1] = tablaVE.Rows[y][x].ToString();
                }

                excel.Cells[1, 10] = "DOCUMENTOS DE PUNTO DE VENTA";
                for (int x = 0; x < tablaPV.Columns.Count; x++)
                {
                    excel.Cells[2, x + 8] = tablaPV.Columns[x].ToString();
                    for (int y = 0; y < tablaPV.Rows.Count; y++)
                        excel.Cells[y + 3, x + 8] = tablaPV.Rows[y][x].ToString();
                }
            }
            else
            {
                excel.Cells[mayor+1, 1] = sucursal;
                excel.Cells[mayor+1, 3] = "DOCUMENTOS DE VENTAS";

                for (int x = 0; x < tablaVE.Columns.Count; x++)
                {
                    excel.Cells[mayor+2, x + 1] = tablaVE.Columns[x].ToString();
                    for (int y = 0; y < tablaVE.Rows.Count; y++)
                        excel.Cells[mayor + y + 3, x + 1] = tablaVE.Rows[y][x].ToString();
                }

                excel.Cells[mayor+1, 10] = "DOCUMENTOS DE PUNTO DE VENTA";
                for (int x = 0; x < tablaPV.Columns.Count; x++)
                {
                    excel.Cells[mayor+2, x + 8] = tablaPV.Columns[x].ToString();
                    for (int y = 0; y < tablaPV.Rows.Count; y++)
                        excel.Cells[mayor + y + 3, x + 8] = tablaPV.Rows[y][x].ToString();
                }
            }            
            if (tablaPV.Rows.Count > tablaVE.Rows.Count)
                mayor += tablaPV.Rows.Count+3;
            else
                mayor += tablaVE.Rows.Count+3;
                        
            if(fin == listTablas.Count-2)
                excel.Visible= true;
        }
    }
}
