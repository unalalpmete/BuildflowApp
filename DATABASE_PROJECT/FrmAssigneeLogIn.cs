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
    public partial class FrmAssigneeLogIn: Form
    {
        public FrmAssigneeLogIn()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from TBL_Assignees where Assignee_username = @p1 and Assignee_password = @p2", connection.connection());
            cmd.Parameters.AddWithValue("@p1", txtAUserName.Text);
            cmd.Parameters.AddWithValue("@p2", txtAPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmAssignee frm = new FrmAssignee();
                frm.username = txtAUserName.Text;
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
