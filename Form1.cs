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

        private void btnFindAndModify_Click(object sender, EventArgs e)
        {
            displayMessage("", //String _id, 
                           "", //String plant,
                           "", //String truck,
                           "", //String payload,
                           "", //String status,
                            null, //Datetime createdate,
                            null //Datetime lastmodified
                              );

            var record = DAL.FindFirstMessage(textBox1.Text, comboBox1.Text);

            if (record != null)
            {
                displayMessage(record._id.ToString(),
                               record.plant,
                               record.truck,
                               record.payload,
                               record.status,
                               record.createdate,
                               record.lastmodified);
            }
            else
            {
                tb_id.Text = "*** No Record Found ***";
            }


        }

        private void displayMessage(String _id, 
                                    String plant,
                                    String truck,
                                    String payload,
                                    String status,
                                    DateTime? createdate,
                                    DateTime? lastmodified)

        {
            tb_id.Text = _id;

            textBox2.Text = truck;
            textBox4.Text = plant;
            textBox3.Text = status;
            textBox5.Text = payload;

            textBox6.Text = "";
            if (createdate != null) 
            {
                textBox6.Text = createdate.ToString();
            }

            textBox7.Text = "";
            if (lastmodified != null)
            {
                textBox7.Text = lastmodified.ToString();
            }

        }
    }
}
