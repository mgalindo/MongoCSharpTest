using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoCSharpTest.Model;

namespace MongoCSharpTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertMsg_Click(object sender, EventArgs e)
        {
            DAL.CreateMessage(tbPlant.Text, tbTruck.Text, tbPayLoad.Text, cbxStatus.Text);
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            int limitRecords = Convert.ToInt32(qryLimit.Text);

            dataGridView1.DataSource = DAL.GetMessages(tbQryPlant.Text, tbQryTruck.Text, qryStatus.Text, ckbxDescending.Checked, limitRecords);

            lblRowCount.Text = dataGridView1.RowCount.ToString()+" Record(s)";
        }
    }
}
