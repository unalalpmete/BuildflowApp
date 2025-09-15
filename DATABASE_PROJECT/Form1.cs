using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace DATABASE_PROJECT
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBoxContractor_Click(object sender, EventArgs e)
        {
            FrmContractorLogIn frm = new FrmContractorLogIn();
            frm.Show();
        }

        private void pictureBoxSupervısor_Click(object sender, EventArgs e)
        {
            FrmSupervısorLogIn frm = new FrmSupervısorLogIn();
            frm.Show();
        }

      

        private void pictureBoxAssignee_Click(object sender, EventArgs e)
        {
            FrmAssigneeLogIn frm = new FrmAssigneeLogIn();
            frm.Show();
        }

        
    }
}
