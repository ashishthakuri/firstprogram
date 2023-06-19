namespace FitnessApp
{
    partial class TrainingPlanForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbunit = new System.Windows.Forms.ComboBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.txttrainingplanname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btncreatetrainingplan = new System.Windows.Forms.Button();
            this.btnedittrainingplan = new System.Windows.Forms.Button();
            this.btndeletetrainingplan = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Training Plan";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.Controls.Add(this.cmbunit);
            this.groupBox1.Controls.Add(this.txtrate);
            this.groupBox1.Controls.Add(this.txtremarks);
            this.groupBox1.Controls.Add(this.txttrainingplanname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(43, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 216);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "please provide all the details";
            // 
            // cmbunit
            // 
            this.cmbunit.FormattingEnabled = true;
            this.cmbunit.Items.AddRange(new object[] {
            "Hour",
            "Week"});
            this.cmbunit.Location = new System.Drawing.Point(265, 98);
            this.cmbunit.Name = "cmbunit";
            this.cmbunit.Size = new System.Drawing.Size(308, 24);
            this.cmbunit.TabIndex = 7;
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(265, 139);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(308, 22);
            this.txtrate.TabIndex = 6;
            // 
            // txtremarks
            // 
            this.txtremarks.Location = new System.Drawing.Point(265, 176);
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(308, 22);
            this.txtremarks.TabIndex = 5;
            // 
            // txttrainingplanname
            // 
            this.txttrainingplanname.Location = new System.Drawing.Point(265, 62);
            this.txttrainingplanname.Name = "txttrainingplanname";
            this.txttrainingplanname.Size = new System.Drawing.Size(308, 22);
            this.txttrainingplanname.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Remarks:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Unit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Training Plan Name:";
            // 
            // btncreatetrainingplan
            // 
            this.btncreatetrainingplan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btncreatetrainingplan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatetrainingplan.ForeColor = System.Drawing.Color.Black;
            this.btncreatetrainingplan.Location = new System.Drawing.Point(628, 86);
            this.btncreatetrainingplan.Name = "btncreatetrainingplan";
            this.btncreatetrainingplan.Size = new System.Drawing.Size(231, 49);
            this.btncreatetrainingplan.TabIndex = 2;
            this.btncreatetrainingplan.Text = "Create Training Plan";
            this.btncreatetrainingplan.UseVisualStyleBackColor = false;
            this.btncreatetrainingplan.Click += new System.EventHandler(this.btncreatetrainingplan_Click);
            // 
            // btnedittrainingplan
            // 
            this.btnedittrainingplan.BackColor = System.Drawing.Color.Gold;
            this.btnedittrainingplan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedittrainingplan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnedittrainingplan.Location = new System.Drawing.Point(628, 148);
            this.btnedittrainingplan.Name = "btnedittrainingplan";
            this.btnedittrainingplan.Size = new System.Drawing.Size(231, 46);
            this.btnedittrainingplan.TabIndex = 3;
            this.btnedittrainingplan.Text = "Edit Training Plan";
            this.btnedittrainingplan.UseVisualStyleBackColor = false;
            this.btnedittrainingplan.Click += new System.EventHandler(this.btnedittrainingplan_Click);
            // 
            // btndeletetrainingplan
            // 
            this.btndeletetrainingplan.BackColor = System.Drawing.Color.DarkGreen;
            this.btndeletetrainingplan.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletetrainingplan.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btndeletetrainingplan.Location = new System.Drawing.Point(628, 210);
            this.btndeletetrainingplan.Name = "btndeletetrainingplan";
            this.btndeletetrainingplan.Size = new System.Drawing.Size(231, 45);
            this.btndeletetrainingplan.TabIndex = 4;
            this.btndeletetrainingplan.Text = "Delete Training Plan";
            this.btndeletetrainingplan.UseVisualStyleBackColor = false;
            this.btndeletetrainingplan.Click += new System.EventHandler(this.btndeletetrainingplan_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.GreenYellow;
            this.btnclose.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnclose.Location = new System.Drawing.Point(628, 262);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(231, 40);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(816, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // TrainingPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(871, 495);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndeletetrainingplan);
            this.Controls.Add(this.btnedittrainingplan);
            this.Controls.Add(this.btncreatetrainingplan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TrainingPlanForm";
            this.Text = "Fitness club customer management system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbunit;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.TextBox txttrainingplanname;
        private System.Windows.Forms.Button btncreatetrainingplan;
        private System.Windows.Forms.Button btnedittrainingplan;
        private System.Windows.Forms.Button btndeletetrainingplan;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}