using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DATABASE_PROJECT
{
    public partial class FrmSupervısorLogIn: Form
    {
        public FrmSupervısorLogIn()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TBL_Supervisors where Supervisor_username = @p1 and Supervisor_password = @p2", connection.connection());
            cmd.Parameters.AddWithValue("@p1", txtSUserName.Text);
            cmd.Parameters.AddWithValue("@p2", txtSPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmSupervısor frm = new FrmSupervısor();
                frm.username = txtSUserName.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password !!!");
            }
            connection.connection().Close();

        }
    }
}
