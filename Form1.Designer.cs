namespace MongoCSharpTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPlant = new System.Windows.Forms.TextBox();
            this.tbTruck = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPayLoad = new System.Windows.Forms.TextBox();
            this.btnInsertMsg = new System.Windows.Forms.Button();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.tbQryTruck = new System.Windows.Forms.TextBox();
            this.tbQryPlant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 503);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnInsertMsg);
            this.tabPage1.Controls.Add(this.tbPayLoad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbTruck);
            this.tabPage1.Controls.Add(this.tbPlant);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert Message";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnRetrieve);
            this.tabPage2.Controls.Add(this.tbQryTruck);
            this.tabPage2.Controls.Add(this.tbQryPlant);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Retrieve Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Truck";
            // 
            // tbPlant
            // 
            this.tbPlant.Location = new System.Drawing.Point(93, 22);
            this.tbPlant.Name = "tbPlant";
            this.tbPlant.Size = new System.Drawing.Size(100, 20);
            this.tbPlant.TabIndex = 2;
            this.tbPlant.Text = "A121";
            // 
            // tbTruck
            // 
            this.tbTruck.Location = new System.Drawing.Point(93, 58);
            this.tbTruck.Name = "tbTruck";
            this.tbTruck.Size = new System.Drawing.Size(100, 20);
            this.tbTruck.TabIndex = 3;
            this.tbTruck.Text = "B155244";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Payload";
            // 
            // tbPayLoad
            // 
            this.tbPayLoad.Location = new System.Drawing.Point(40, 113);
            this.tbPayLoad.Multiline = true;
            this.tbPayLoad.Name = "tbPayLoad";
            this.tbPayLoad.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbPayLoad.Size = new System.Drawing.Size(725, 361);
            this.tbPayLoad.TabIndex = 5;
            this.tbPayLoad.Text = resources.GetString("tbPayLoad.Text");
            // 
            // btnInsertMsg
            // 
            this.btnInsertMsg.Location = new System.Drawing.Point(222, 58);
            this.btnInsertMsg.Name = "btnInsertMsg";
            this.btnInsertMsg.Size = new System.Drawing.Size(79, 23);
            this.btnInsertMsg.TabIndex = 6;
            this.btnInsertMsg.Text = "Insert";
            this.btnInsertMsg.UseVisualStyleBackColor = true;
            this.btnInsertMsg.Click += new System.EventHandler(this.btnInsertMsg_Click);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(199, 51);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(79, 23);
            this.btnRetrieve.TabIndex = 11;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // tbQryTruck
            // 
            this.tbQryTruck.Location = new System.Drawing.Point(70, 51);
            this.tbQryTruck.Name = "tbQryTruck";
            this.tbQryTruck.Size = new System.Drawing.Size(100, 20);
            this.tbQryTruck.TabIndex = 10;
            this.tbQryTruck.Text = "B155244";
            // 
            // tbQryPlant
            // 
            this.tbQryPlant.Location = new System.Drawing.Point(70, 15);
            this.tbQryPlant.Name = "tbQryPlant";
            this.tbQryPlant.Size = new System.Drawing.Size(100, 20);
            this.tbQryPlant.TabIndex = 9;
            this.tbQryPlant.Text = "A121";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Truck";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Plant";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 391);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbPayLoad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTruck;
        private System.Windows.Forms.TextBox tbPlant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnInsertMsg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.TextBox tbQryTruck;
        private System.Windows.Forms.TextBox tbQryPlant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

