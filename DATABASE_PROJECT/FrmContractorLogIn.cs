using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Data Source=DESKTOP-JIRTUUF\SQLEXPRESS;Initial Catalog=DATABASEPROJE;Integrated Security=True;Trust Server Certificate=True

namespace DATABASE_PROJECT
{
    public partial class FrmContractorLogIn: Form
    {
        public FrmContractorLogIn()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TBL_Contractors where Contractor_username = @p1 and Contractor_password = @p2",connection.connection());
            cmd.Parameters.AddWithValue("@p1",txtCUserName.Text);
            cmd.Parameters.AddWithValue("@p2",txtCPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmContractor frm = new FrmContractor();
                frm.username = txtCUserName.Text;
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
