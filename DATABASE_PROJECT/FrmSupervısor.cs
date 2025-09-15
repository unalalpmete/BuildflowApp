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
    public partial class FrmSupervısor: Form
    {
        public FrmSupervısor()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        public string username;

        private void FrmSupervısor_Load(object sender, EventArgs e)
        {
            txtSupervisorUserName.Text = username;

            //SUPERVISOR BİLGİLERİNİ EKRANA GETİRME
            SqlCommand cmd = new SqlCommand("select SupervisorID,Supervisor_name from TBL_Supervisors where Supervisor_username = @p1",connection.connection());
            cmd.Parameters.AddWithValue("@p1",username);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtSupervisorId.Text = dr[0].ToString();
                txtSupervisorName.Text = dr[1].ToString();
            }
            connection.connection().Close();

            //ATANMAMIŞ PROJELERİ SUPERVISOR EKRANINA GETİRME DAHA SONRA ATAYACAĞI PROJEYİ ORDAN SEÇCEK
            SqlCommand cmd2 = new SqlCommand("SELECT Project_name as 'PROJECT NAME',Project_field as 'PROJECT FIELD',Project_Price as 'PROJECT PRICE',Contractor_name as 'CONTRACTOR NAME' FROM TBL_Unassigned_Project\r\nINNER JOIN TBL_Contractors ON TBL_Unassigned_Project.ContractorID=TBL_Contractors.ContractorID; ", connection.connection());
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;
            connection.connection().Close();

        }

        private void buttonAssignProject_Click(object sender, EventArgs e)
        {
            //PROJELERİ ASSİGNEELERE ATAMA 
            // atamada hata var !!!
            SqlCommand cmd2 = new SqlCommand("insert into TBL_Project (Project_name,Project_field,Project_AssigneeID,Project_Price,Project_ContractorID) values (@p1,@p2,@p3,@p4,@p5)",connection.connection());
            cmd2.Parameters.AddWithValue("@p1", txtAPProjectName.Text);
            cmd2.Parameters.AddWithValue("@p2", txtAPProjectField.Text);
            cmd2.Parameters.AddWithValue("@p3", txtAPProjectAssigneeID.Text);
            cmd2.Parameters.AddWithValue("@p4", txtAPProjectPrice.Text);
            cmd2.Parameters.AddWithValue("@p5", txtAPProjectContractorID.Text);
            cmd2.ExecuteNonQuery();

            //ATANMIŞ PROJELERİ GRİDVİEWDE GÖRÜNTÜLEME
            //\r\nINNER JOIN TBL_Contractors ON TBL_Project.Project_ContractorID=TBL_Contractors.ContractorID\r\nINNER JOIN TBL_Assignees ON TBL_Project.Project_AssigneeID=TBL_Assignees.AssigneeID
            //,Contractor_name as 'CONTRACTOR NAME',Assignee_name as'ASSIGNEE NAME'
            SqlCommand cmd = new SqlCommand("SELECT Project_name as 'PROJECT NAME',Project_field as 'PROJECT FIELD',Project_state as 'PROJECT STATE',Project_Price as 'PROJECT PRICE',Project_ContractorID as 'CONTRACTOR ID',Contractor_name as 'CONTRACTOR NAME',Assignee_name as'ASSIGNEE NAME' FROM TBL_Project\r\nINNER JOIN TBL_Contractors ON TBL_Project.Project_ContractorID=TBL_Contractors.ContractorID\r\nINNER JOIN TBL_Assignees ON TBL_Project.Project_AssigneeID=TBL_Assignees.AssigneeID;", connection.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.connection().Close();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //ATANMAMIS PROJELERİN OLDUGU GRİDVİEWDEKİ VERİLERİ SUPERVİSOR EKRANINDAKİ ARAÇLARA AKTARMA
            int choosen = dataGridView2.SelectedCells[0].RowIndex;
            txtAPProjectName.Text = dataGridView2.Rows[choosen].Cells[0].Value.ToString();
            txtAPProjectField.Text = dataGridView2.Rows[choosen].Cells[1].Value.ToString();
            txtAPProjectPrice.Text = dataGridView2.Rows[choosen].Cells[2].Value.ToString();
            txtAPProjectContractorName.Text = dataGridView2.Rows[choosen].Cells[3].Value.ToString();

        }

        
    }
}
