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
    public partial class FrmContractor: Form
    {
        public FrmContractor()
        {
            InitializeComponent();
        }

        ClassSqlConnection connection = new ClassSqlConnection();

        public string username;

        private void FrmContractor_Load(object sender, EventArgs e)
        {
            txtContractorUserName.Text = username;
            //CONTRACTOR BİLGİLERİNİ EKRANA GETİRME
            SqlCommand cmd = new SqlCommand("select ContractorID,Contractor_name from TBL_Contractors where Contractor_username = @p1",connection.connection());
            cmd.Parameters.AddWithValue("@p1", username);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                txtContractorId.Text = dr[0].ToString();
                txtContractorName.Text = dr[1].ToString();
            }
            connection.connection().Close();

            //CONTRACTOR NAMESİNİ CREATE PROJECTDEKİ CONTRACTOR NAME KISMINA GETİRME
            txtCPContractorName.Text = txtContractorName.Text;

        }

        private void buttonCreateProject_Click(object sender, EventArgs e)
        {
            //PROJE OLUŞTURMA(OLUŞACAK PROJELER ATANMAMIŞ POZİSYONDA OLACAK)(insert)
            SqlCommand cmd2 = new SqlCommand("insert into TBL_Unassigned_Project (Project_name,Project_field,Project_Price,ContractorID) values (@p1,@p2,@p3,@p4)",connection.connection());
            cmd2.Parameters.AddWithValue("@p1", txtCPProjectName.Text);
            cmd2.Parameters.AddWithValue("@p2", txtCPProjectField.Text);
            cmd2.Parameters.AddWithValue("@p3", txtCPProjectPrice.Text);
            cmd2.Parameters.AddWithValue("@p4", txtCPProjectContractorID.Text);
            cmd2.ExecuteNonQuery();

            //ATANMAMIS AMA OLUŞTURULAN PROJELERİ GRİDVİEWDE GÖRÜNTÜLEME
            SqlCommand cmd = new SqlCommand("SELECT Project_name as 'PROJECT NAME',Project_field as 'PROJECT FIELD',Project_Price as 'PROJECT PRICE',Contractor_name as 'CONTRACTOR NAME' FROM TBL_Unassigned_Project\r\nINNER JOIN TBL_Contractors ON TBL_Unassigned_Project.ContractorID=TBL_Contractors.ContractorID; ", connection.connection());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.connection().Close();
        }
    }
}
