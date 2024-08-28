namespace simpleCrudApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.empBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.crudFormDataSet2 = new simpleCrudApp.crudFormDataSet2();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crudFormDataSet = new simpleCrudApp.crudFormDataSet();
            this.empBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.crudFormDataSet1 = new simpleCrudApp.crudFormDataSet1();
            this.empTableAdapter = new simpleCrudApp.crudFormDataSetTableAdapters.empTableAdapter();
            this.empTableAdapter1 = new simpleCrudApp.crudFormDataSet1TableAdapters.empTableAdapter();
            this.empTableAdapter2 = new simpleCrudApp.crudFormDataSet2TableAdapters.empTableAdapter();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudFormDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudFormDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudFormDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "empId";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 121);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Address";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "dob";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "telNo";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(115, 15);
            this.textBox6.MaxLength = 5;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(169, 30);
            this.textBox6.TabIndex = 5;
            // 
            // empBindingSource2
            // 
            this.empBindingSource2.DataMember = "emp";
            this.empBindingSource2.DataSource = this.crudFormDataSet2;
            // 
            // crudFormDataSet2
            // 
            this.crudFormDataSet2.DataSetName = "crudFormDataSet2";
            this.crudFormDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(115, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(169, 30);
            this.textBox7.TabIndex = 6;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(115, 121);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(169, 30);
            this.textBox8.TabIndex = 7;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(115, 227);
            this.textBox10.MaxLength = 10;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(169, 30);
            this.textBox10.TabIndex = 9;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button5.Location = new System.Drawing.Point(369, 150);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 69);
            this.button5.TabIndex = 10;
            this.button5.Text = "insert";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button6.Location = new System.Drawing.Point(475, 226);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(101, 69);
            this.button6.TabIndex = 11;
            this.button6.Text = "update";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(473, 150);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(101, 69);
            this.button7.TabIndex = 12;
            this.button7.Text = "delete";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Olive;
            this.button8.Location = new System.Drawing.Point(370, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 69);
            this.button8.TabIndex = 13;
            this.button8.Text = "Search";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 228);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(372, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Location = new System.Drawing.Point(488, 47);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 46);
            this.button9.TabIndex = 16;
            this.button9.Text = "browse";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 172);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(169, 30);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(290, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 33);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // empBindingSource
            // 
            this.empBindingSource.DataMember = "emp";
            this.empBindingSource.DataSource = this.crudFormDataSet;
            // 
            // crudFormDataSet
            // 
            this.crudFormDataSet.DataSetName = "crudFormDataSet";
            this.crudFormDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empBindingSource1
            // 
            this.empBindingSource1.DataMember = "emp";
            this.empBindingSource1.DataSource = this.crudFormDataSet1;
            // 
            // crudFormDataSet1
            // 
            this.crudFormDataSet1.DataSetName = "crudFormDataSet1";
            this.crudFormDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empTableAdapter
            // 
            this.empTableAdapter.ClearBeforeFill = true;
            // 
            // empTableAdapter1
            // 
            this.empTableAdapter1.ClearBeforeFill = true;
            // 
            // empTableAdapter2
            // 
            this.empTableAdapter2.ClearBeforeFill = true;
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(simpleCrudApp.Form1);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(689, 554);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudFormDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudFormDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crudFormDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource form1BindingSource;
        private crudFormDataSet crudFormDataSet;
        private System.Windows.Forms.BindingSource empBindingSource;
        private crudFormDataSetTableAdapters.empTableAdapter empTableAdapter;
        private crudFormDataSet1 crudFormDataSet1;
        private System.Windows.Forms.BindingSource empBindingSource1;
        private crudFormDataSet1TableAdapters.empTableAdapter empTableAdapter1;
        private crudFormDataSet2 crudFormDataSet2;
        private System.Windows.Forms.BindingSource empBindingSource2;
        private crudFormDataSet2TableAdapters.empTableAdapter empTableAdapter2;
    }
}

