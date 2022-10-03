using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Consultas;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        consulta objConsultas = new consulta();
        List<String> conexiones;
        public Form1()
        {
            InitializeComponent();
            conexiones = objConsultas.RegresaSucursal();
            for (int x = 0; x < conexiones.Count; x+=2)
                CbSucursal.Items.Add(conexiones[x]);
            CbSucursal.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            String fechaInicio = TbFechaInicio.Text;
            String fechaTermino = TbFechaTermino.Text;
            String sucursal = CbSucursal.SelectedItem.ToString();
            if (sucursal.Length<=0)
                MessageBox.Show("SELECCIONE UNA SUCURSAL");
            else
            if (verificaFecha(fechaInicio.Split('.'), fechaTermino.Split('.')))
                objConsultas.generaReporte(fechaInicio, fechaTermino, sucursal);
            else
                MessageBox.Show("Error en las fechas");

        }
        public Boolean verificaFecha(String[] fecha1,String[] fecha2)
        {
            Boolean band = false;
            String Month = DateTime.Now.Month.ToString();
            String Year = DateTime.Now.Year.ToString();
            if (Int32.Parse(fecha1[0]) < 32 && Int32.Parse(fecha1[0]) > 0)
                band = true;
            else
                band = false;
            if (band == true && Int32.Parse(fecha1[1]) < 13 && Int32.Parse(fecha1[1]) > 0)
                band = true;
            else
                band = false;
            if (band == true && Int32.Parse(fecha1[2]) <= Int32.Parse(Year))
                band = true;
            else
                band = false;

            if (band==true && Int32.Parse(fecha2[0]) < 32 && Int32.Parse(fecha2[0]) > 0)
                band = true;
            else
                band = false;
            if (band == true && Int32.Parse(fecha2[1]) < 13 && Int32.Parse(fecha2[1]) > 0)
                band = true;
            else
                band = false;
            if (band == true && Int32.Parse(fecha2[2]) <= Int32.Parse(Year))
                band = true;
            else
                band = false;

            if (band == true && Int16.Parse(fecha1[2]) <= Int16.Parse(fecha2[2]) && Int16.Parse(fecha1[1]) <= Int16.Parse(fecha2[1]) && Int16.Parse(fecha1[0]) <= Int16.Parse(fecha2[0]))
                band = true;
            else
                band = false;


            return band;
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            objConsultas.Generador();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtBox(object sender, EventArgs e)
        {
            if (TbFechaTermino.Text.Equals("01.01.2020"))
            {
                TbFechaTermino.Text = "";
                TbFechaTermino.ForeColor = Color.Black;                
            }
        }

        private void TbFechaInicio_leave(object sender, EventArgs e)
        {
            if (TbFechaInicio.Text.Equals(""))
            {
                TbFechaInicio.Text = "01.01.2020";
                TbFechaInicio.ForeColor = Color.Silver;
            }
        }

        private void TbFechaTermino_leave(object sender, EventArgs e)
        {
            if (TbFechaTermino.Text.Equals(""))
            {
                TbFechaTermino.Text = "01.01.2020";
                TbFechaTermino.ForeColor = Color.Silver;
            }
        }

        private void TbFechaInicio_enter(object sender, EventArgs e)
        {
            if (TbFechaInicio.Text.Equals("01.01.2020"))
            {
                TbFechaInicio.Text = "";
                TbFechaInicio.ForeColor = Color.Black;
            }
        }
    }
}
