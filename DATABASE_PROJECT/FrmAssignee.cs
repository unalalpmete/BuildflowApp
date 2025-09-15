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
    public partial class FrmAssignee: Form
    {
        public FrmAssignee()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        public string username;

        private void FrmAssignee_Load(object sender, EventArgs e)
        {
            //ASSİGNEE BİLGİLERİ EKRANA GETİRME
            txtAssigneeUserName.Text = username;
            

            SqlCommand cmd = new SqlCommand("select AssigneeID,Assignee_name from TBL_Assignees where Assignee_username=@p1",connection.connection());
            cmd.Parameters.AddWithValue("@p1",username);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtAssigneeId.Text = dr[0].ToString();
                txtAssigneeName.Text = dr[1].ToString();
            }

            txtAssigneeProjectAssigneeName.Text = txtAssigneeName.Text;

            // ASSİGNEEYE ATANAN PROJELERİN GRİDVİEWDE GÖRÜNTÜLENMESİ
            txtAssigneeProjectAssigneeID.Text = txtAssigneeId.Text;
            SqlCommand cmd2 = new SqlCommand("SELECT Project_name as 'PROJECT NAME',Project_field as 'PROJECT FIELD',Project_Price as 'PROJECT PRICE',Project_ContractorID as 'CONTRACTOR ID',Contractor_name as 'CONTRACTOR NAME',Project_AssigneeID as 'ASSIGNEE ID',Assignee_name as 'ASSIGNEE NAME' FROM TBL_Project\r\nINNER JOIN TBL_Assignees ON TBL_Project.Project_AssigneeID=TBL_Assignees.AssigneeID\r\nINNER JOIN TBL_Contractors ON TBL_Project.Project_ContractorID=TBL_Contractors.ContractorID\r\nWHERE Project_AssigneeID=@p1;", connection.connection());
            cmd2.Parameters.AddWithValue("@p1",txtAssigneeProjectAssigneeID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.connection().Close();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int choosen = dataGridView1.SelectedCells[0].RowIndex;
            txtAssigneeProjectName.Text = dataGridView1.Rows[choosen].Cells[0].Value.ToString();
            txtAssigneeProjectField.Text = dataGridView1.Rows[choosen].Cells[1].Value.ToString();
            txtAssigneeProjectPrice.Text = dataGridView1.Rows[choosen].Cells[2].Value.ToString();
            txtAssigneeProjectContractorID.Text = dataGridView1.Rows[choosen].Cells[3].Value.ToString();
            txtAssigneeProjectContractorName.Text = dataGridView1.Rows[choosen].Cells[4].Value.ToString();
            txtAssigneeProjectAssigneeID.Text = dataGridView1.Rows[choosen].Cells[5].Value.ToString();
            txtAssigneeProjectAssigneeName.Text = dataGridView1.Rows[choosen].Cells[6].Value.ToString();
        }

        //TIKLANILAN DEĞERİ VERİTABANINDA GÜNCELLE
        //RADİOBUTTONLARA TIKLANILDIGINDA Project_state DEĞERİNİ GEİDVİEWE GETİR 

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = "DONE";// update ve gridviewde görüntüleme gerekli
            SqlCommand cmd = new SqlCommand("UPDATE TBL_Project SET Project_state=@p1 WHERE Project_AssigneeID=@p2;",connection.connection());
            cmd.Parameters.AddWithValue("@p1", label10.Text);
            cmd.Parameters.AddWithValue("@p2", txtAssigneeProjectAssigneeID.Text);
            cmd.ExecuteNonQuery();
            connection.connection().Close();

            // DEĞİŞİKLİKTEN SONRA ASSİGNEENİN PROJELERİNİ GRİDVİEWDE GÖRÜNTÜLEME
            SqlCommand cmd2 = new SqlCommand("SELECT Project_name as 'PROJECT NAME',Project_field as 'PROJECT FIELD',Project_Price as 'PROJECT PRICE',Project_ContractorID as 'CONTRACTOR ID',Contractor_name as 'CONTRACTOR NAME',Project_AssigneeID as 'ASSIGNEE ID',Assignee_name as 'ASSIGNEE NAME',Project_state as 'PROJECT STATE' FROM TBL_Project\r\nINNER JOIN TBL_Assignees ON TBL_Project.Project_AssigneeID=TBL_Assignees.AssigneeID\r\nINNER JOIN TBL_Contractors ON TBL_Project.Project_ContractorID=TBL_Contractors.ContractorID\r\nWHERE Project_AssigneeID=@p1;", connection.connection());
            cmd2.Parameters.AddWithValue("@p1", txtAssigneeProjectAssigneeID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.connection().Close();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = "NOT DONE";// update ve gridviewde görüntüleme gerekli
            SqlCommand cmd = new SqlCommand("UPDATE TBL_Project SET Project_state=@p1 WHERE Project_AssigneeID=@p2;", connection.connection());
            cmd.Parameters.AddWithValue("@p1", label10.Text);
            cmd.Parameters.AddWithValue("@p2", txtAssigneeProjectAssigneeID.Text);
            cmd.ExecuteNonQuery();
            connection.connection().Close();

            // DEĞİŞİKLİKTEN SONRA ASSİGNEENİN PROJELERİNİ GRİDVİEWDE GÖRÜNTÜLEME
            SqlCommand cmd2 = new SqlCommand("SELECT Project_name as 'PROJECT NAME',Project_field as 'PROJECT FIELD',Project_Price as 'PROJECT PRICE',Project_ContractorID as 'CONTRACTOR ID',Contractor_name as 'CONTRACTOR NAME',Project_AssigneeID as 'ASSIGNEE ID',Assignee_name as 'ASSIGNEE NAME',Project_state as 'PROJECT STATE' FROM TBL_Project\r\nINNER JOIN TBL_Assignees ON TBL_Project.Project_AssigneeID=TBL_Assignees.AssigneeID\r\nINNER JOIN TBL_Contractors ON TBL_Project.Project_ContractorID=TBL_Contractors.ContractorID\r\nWHERE Project_AssigneeID=@p1;", connection.connection());
            cmd2.Parameters.AddWithValue("@p1", txtAssigneeProjectAssigneeID.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.connection().Close();
        }

        

    }
}
