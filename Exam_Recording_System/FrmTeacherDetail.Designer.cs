namespace Exam_Recording_System
{
    partial class FrmTeacherDetail
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.MskNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtExam3 = new System.Windows.Forms.TextBox();
            this.TxtExam2 = new System.Windows.Forms.TextBox();
            this.TxtExam1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LBLFAILED = new System.Windows.Forms.Label();
            this.LBLPASSED = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LBLAVERAGE = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentDBDataSet = new Exam_Recording_System.StudentDBDataSet();
            this.tBLLESSONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_LESSONTableAdapter = new Exam_Recording_System.StudentDBDataSetTableAdapters.TBL_LESSONTableAdapter();
            this.sTDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDSURNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDE1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDE2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDE3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aVGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sITUATIONDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TxtSurname);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.MskNumber);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Student";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Save Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(113, 101);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(116, 26);
            this.TxtSurname.TabIndex = 2;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(113, 69);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(116, 26);
            this.TxtName.TabIndex = 2;
            // 
            // MskNumber
            // 
            this.MskNumber.Location = new System.Drawing.Point(113, 37);
            this.MskNumber.Mask = "0000";
            this.MskNumber.Name = "MskNumber";
            this.MskNumber.Size = new System.Drawing.Size(116, 26);
            this.MskNumber.TabIndex = 1;
            this.MskNumber.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtExam3);
            this.groupBox2.Controls.Add(this.TxtExam2);
            this.groupBox2.Controls.Add(this.TxtExam1);
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(324, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 202);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exams";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Exam Entry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Exam 3:";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(43, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Exam 1:";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Exam 2:";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtExam3
            // 
            this.TxtExam3.Location = new System.Drawing.Point(116, 101);
            this.TxtExam3.Name = "TxtExam3";
            this.TxtExam3.Size = new System.Drawing.Size(116, 26);
            this.TxtExam3.TabIndex = 2;
            // 
            // TxtExam2
            // 
            this.TxtExam2.Location = new System.Drawing.Point(116, 69);
            this.TxtExam2.Name = "TxtExam2";
            this.TxtExam2.Size = new System.Drawing.Size(116, 26);
            this.TxtExam2.TabIndex = 2;
            // 
            // TxtExam1
            // 
            this.TxtExam1.Location = new System.Drawing.Point(116, 37);
            this.TxtExam1.Name = "TxtExam1";
            this.TxtExam1.Size = new System.Drawing.Size(116, 26);
            this.TxtExam1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LBLFAILED);
            this.groupBox3.Controls.Add(this.LBLPASSED);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.LBLAVERAGE);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(636, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 202);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exams";
            // 
            // LBLFAILED
            // 
            this.LBLFAILED.AutoSize = true;
            this.LBLFAILED.Location = new System.Drawing.Point(116, 101);
            this.LBLFAILED.Name = "LBLFAILED";
            this.LBLFAILED.Size = new System.Drawing.Size(28, 18);
            this.LBLFAILED.TabIndex = 0;
            this.LBLFAILED.Text = "00";
            this.LBLFAILED.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLPASSED
            // 
            this.LBLPASSED.AutoSize = true;
            this.LBLPASSED.Location = new System.Drawing.Point(116, 72);
            this.LBLPASSED.Name = "LBLPASSED";
            this.LBLPASSED.Size = new System.Drawing.Size(28, 18);
            this.LBLPASSED.TabIndex = 0;
            this.LBLPASSED.Text = "00";
            this.LBLPASSED.Click += new System.EventHandler(this.label1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(54, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Failed:";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Passed:";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLAVERAGE
            // 
            this.LBLAVERAGE.AutoSize = true;
            this.LBLAVERAGE.Location = new System.Drawing.Point(116, 40);
            this.LBLAVERAGE.Name = "LBLAVERAGE";
            this.LBLAVERAGE.Size = new System.Drawing.Size(28, 18);
            this.LBLAVERAGE.TabIndex = 0;
            this.LBLAVERAGE.Text = "00";
            this.LBLAVERAGE.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(12, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(891, 276);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sTDIDDataGridViewTextBoxColumn,
            this.sTDNODataGridViewTextBoxColumn,
            this.sTDNAMEDataGridViewTextBoxColumn,
            this.sTDSURNAMEDataGridViewTextBoxColumn,
            this.sTDE1DataGridViewTextBoxColumn,
            this.sTDE2DataGridViewTextBoxColumn,
            this.sTDE3DataGridViewTextBoxColumn,
            this.aVGDataGridViewTextBoxColumn,
            this.sITUATIONDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tBLLESSONBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(882, 254);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // studentDBDataSet
            // 
            this.studentDBDataSet.DataSetName = "StudentDBDataSet";
            this.studentDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLLESSONBindingSource
            // 
            this.tBLLESSONBindingSource.DataMember = "TBL_LESSON";
            this.tBLLESSONBindingSource.DataSource = this.studentDBDataSet;
            // 
            // tBL_LESSONTableAdapter
            // 
            this.tBL_LESSONTableAdapter.ClearBeforeFill = true;
            // 
            // sTDIDDataGridViewTextBoxColumn
            // 
            this.sTDIDDataGridViewTextBoxColumn.DataPropertyName = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.HeaderText = "STDID";
            this.sTDIDDataGridViewTextBoxColumn.Name = "sTDIDDataGridViewTextBoxColumn";
            this.sTDIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTDNODataGridViewTextBoxColumn
            // 
            this.sTDNODataGridViewTextBoxColumn.DataPropertyName = "STDNO";
            this.sTDNODataGridViewTextBoxColumn.HeaderText = "STDNO";
            this.sTDNODataGridViewTextBoxColumn.Name = "sTDNODataGridViewTextBoxColumn";
            // 
            // sTDNAMEDataGridViewTextBoxColumn
            // 
            this.sTDNAMEDataGridViewTextBoxColumn.DataPropertyName = "STDNAME";
            this.sTDNAMEDataGridViewTextBoxColumn.HeaderText = "STDNAME";
            this.sTDNAMEDataGridViewTextBoxColumn.Name = "sTDNAMEDataGridViewTextBoxColumn";
            // 
            // sTDSURNAMEDataGridViewTextBoxColumn
            // 
            this.sTDSURNAMEDataGridViewTextBoxColumn.DataPropertyName = "STDSURNAME";
            this.sTDSURNAMEDataGridViewTextBoxColumn.HeaderText = "STDSURNAME";
            this.sTDSURNAMEDataGridViewTextBoxColumn.Name = "sTDSURNAMEDataGridViewTextBoxColumn";
            // 
            // sTDE1DataGridViewTextBoxColumn
            // 
            this.sTDE1DataGridViewTextBoxColumn.DataPropertyName = "STDE1";
            this.sTDE1DataGridViewTextBoxColumn.HeaderText = "STDE1";
            this.sTDE1DataGridViewTextBoxColumn.Name = "sTDE1DataGridViewTextBoxColumn";
            // 
            // sTDE2DataGridViewTextBoxColumn
            // 
            this.sTDE2DataGridViewTextBoxColumn.DataPropertyName = "STDE2";
            this.sTDE2DataGridViewTextBoxColumn.HeaderText = "STDE2";
            this.sTDE2DataGridViewTextBoxColumn.Name = "sTDE2DataGridViewTextBoxColumn";
            // 
            // sTDE3DataGridViewTextBoxColumn
            // 
            this.sTDE3DataGridViewTextBoxColumn.DataPropertyName = "STDE3";
            this.sTDE3DataGridViewTextBoxColumn.HeaderText = "STDE3";
            this.sTDE3DataGridViewTextBoxColumn.Name = "sTDE3DataGridViewTextBoxColumn";
            // 
            // aVGDataGridViewTextBoxColumn
            // 
            this.aVGDataGridViewTextBoxColumn.DataPropertyName = "AVG";
            this.aVGDataGridViewTextBoxColumn.HeaderText = "AVG";
            this.aVGDataGridViewTextBoxColumn.Name = "aVGDataGridViewTextBoxColumn";
            // 
            // sITUATIONDataGridViewCheckBoxColumn
            // 
            this.sITUATIONDataGridViewCheckBoxColumn.DataPropertyName = "SITUATION";
            this.sITUATIONDataGridViewCheckBoxColumn.HeaderText = "SITUATION";
            this.sITUATIONDataGridViewCheckBoxColumn.Name = "sITUATIONDataGridViewCheckBoxColumn";
            // 
            // FrmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(915, 508);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmTeacherDetail";
            this.Text = "FrmTeacherDetail";
            this.Load += new System.EventHandler(this.FrmTeacherDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLLESSONBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.MaskedTextBox MskNumber;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtExam3;
        private System.Windows.Forms.TextBox TxtExam2;
        private System.Windows.Forms.TextBox TxtExam1;
        private System.Windows.Forms.Label LBLFAILED;
        private System.Windows.Forms.Label LBLPASSED;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LBLAVERAGE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private StudentDBDataSet studentDBDataSet;
        private System.Windows.Forms.BindingSource tBLLESSONBindingSource;
        private StudentDBDataSetTableAdapters.TBL_LESSONTableAdapter tBL_LESSONTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDSURNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDE3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aVGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sITUATIONDataGridViewCheckBoxColumn;
    }
}