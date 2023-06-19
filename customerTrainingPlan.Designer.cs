namespace FitnessApp
{
    partial class customerTrainingPlan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcustomerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvcustomerplan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbplanname = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnaddplan = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.dgvselectedplandetails = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtunit = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerplan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectedplandetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(676, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training plan for Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CustomerName:";
            // 
            // txtcustomerName
            // 
            this.txtcustomerName.Location = new System.Drawing.Point(173, 97);
            this.txtcustomerName.Name = "txtcustomerName";
            this.txtcustomerName.Size = new System.Drawing.Size(264, 22);
            this.txtcustomerName.TabIndex = 3;
            this.txtcustomerName.TextChanged += new System.EventHandler(this.txtcustomerName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(563, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CustomerID:";
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerId.Location = new System.Drawing.Point(678, 96);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(20, 20);
            this.lblCustomerId.TabIndex = 5;
            this.lblCustomerId.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvcustomerplan);
            this.groupBox1.Location = new System.Drawing.Point(22, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 110);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Select a Customer";
            // 
            // dgvcustomerplan
            // 
            this.dgvcustomerplan.AllowUserToAddRows = false;
            this.dgvcustomerplan.AllowUserToDeleteRows = false;
            this.dgvcustomerplan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcustomerplan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcustomerplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomerplan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvcustomerplan.Location = new System.Drawing.Point(3, 18);
            this.dgvcustomerplan.Name = "dgvcustomerplan";
            this.dgvcustomerplan.ReadOnly = true;
            this.dgvcustomerplan.RowHeadersWidth = 51;
            this.dgvcustomerplan.RowTemplate.Height = 24;
            this.dgvcustomerplan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcustomerplan.Size = new System.Drawing.Size(662, 89);
            this.dgvcustomerplan.TabIndex = 0;
            this.dgvcustomerplan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustomerplan_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select Plan:";
            // 
            // cmbplanname
            // 
            this.cmbplanname.FormattingEnabled = true;
            this.cmbplanname.Location = new System.Drawing.Point(123, 279);
            this.cmbplanname.Name = "cmbplanname";
            this.cmbplanname.Size = new System.Drawing.Size(314, 24);
            this.cmbplanname.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnaddplan
            // 
            this.btnaddplan.BackColor = System.Drawing.Color.OrangeRed;
            this.btnaddplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddplan.ForeColor = System.Drawing.Color.Black;
            this.btnaddplan.Location = new System.Drawing.Point(458, 266);
            this.btnaddplan.Name = "btnaddplan";
            this.btnaddplan.Size = new System.Drawing.Size(113, 42);
            this.btnaddplan.TabIndex = 10;
            this.btnaddplan.Text = "Add Plan";
            this.btnaddplan.UseVisualStyleBackColor = false;
            this.btnaddplan.Click += new System.EventHandler(this.btnaddplan_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Green;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(456, 311);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(113, 42);
            this.btnedit.TabIndex = 11;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(577, 266);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(113, 42);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
           
            // 
            // dgvselectedplandetails
            // 
            this.dgvselectedplandetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvselectedplandetails.Location = new System.Drawing.Point(22, 370);
            this.dgvselectedplandetails.Name = "dgvselectedplandetails";
            this.dgvselectedplandetails.RowHeadersWidth = 51;
            this.dgvselectedplandetails.RowTemplate.Height = 24;
            this.dgvselectedplandetails.Size = new System.Drawing.Size(676, 155);
            this.dgvselectedplandetails.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Number of Hours/Weeks";
            // 
            // txtunit
            // 
            this.txtunit.Location = new System.Drawing.Point(216, 311);
            this.txtunit.Name = "txtunit";
            this.txtunit.Size = new System.Drawing.Size(221, 22);
            this.txtunit.TabIndex = 15;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(575, 314);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 42);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Remarks";
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(99, 346);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(338, 22);
            this.txtremarks.TabIndex = 19;
            // 
            // customerTrainingPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 531);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtunit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvselectedplandetails);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnaddplan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbplanname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCustomerId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "customerTrainingPlan";
            this.Text = "Fitness Club Customer Management System";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerplan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvselectedplandetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcustomerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvcustomerplan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbplanname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnaddplan;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.DataGridView dgvselectedplandetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtunit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtremarks;
    }
}