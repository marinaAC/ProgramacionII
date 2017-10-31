using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace baseDeDatos
{
    public partial class frmPrincipal : Form
    {
        SqlConnection conexion;
        string connectionStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=Argentina;Integrated Security=True";
        SqlCommand select;
        /// <summary>
        /// Profesor declara aca dentro el sqlconnection
        /// </summary>
        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion = new SqlConnection(connectionStr);
            select = new SqlCommand("Select l.Nombre from Localidad l inner join Provincia p on l.idProvincia = p.id where p.descripcion = '"+this.cmbProvincia.Text+"'",conexion);
            try
            {
                conexion.Open();
                SqlDataReader dr = select.ExecuteReader();
                this.cmbLocalidad.Items.Clear();
                while (dr.Read())
                {
                    this.cmbLocalidad.Items.Add(dr[0]);
                }
            }
            catch (Exception a)
            {

                MessageBox.Show(a.Message);
            }
            finally 
            {
                conexion.Close();
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs n)
        {
            conexion = new SqlConnection(connectionStr);
            select = new SqlCommand("Select * from Provincia");
            try
            {
                conexion.Open();
                select.Connection = conexion;
                SqlDataReader oDr = select.ExecuteReader();
                cmbProvincia.Items.Clear();
                while (oDr.Read())
                {
                    this.cmbProvincia.Items.Add(oDr["descripcion"].ToString());
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + "Error no pudo abrirse la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }


        /*
        private SqlDataReader selectFromBase()
        {
            select = new SqlCommand("Select * from Provincias");
            //select.CommandType = System.Data.CommandType.Text;
            //select.Connection = conexion;
            //select.CommandText = "Select * from Provincias";
            conexion.Open();
            SqlDataReader oDr = select.ExecuteReader();
            return oDr;
        }*/
    }
}
