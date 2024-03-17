namespace casheer.screens.suppliers
{
    partial class UpdateSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSupplier));
            this.txt_PhoneSrch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checked_Supplier = new System.Windows.Forms.CheckedListBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_srch = new System.Windows.Forms.Button();
            this.txt_SupplierNameSrch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rfrch = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_dell = new System.Windows.Forms.Button();
            this.dataGridView_Users = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.casheerDataSet4 = new casheer.casheerDataSet4();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.picture_Supplier = new System.Windows.Forms.PictureBox();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_SupplierName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refrsh = new System.Windows.Forms.Button();
            this.supplierTableAdapter = new casheer.casheerDataSet4TableAdapters.SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casheerDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Supplier)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_PhoneSrch
            // 
            this.txt_PhoneSrch.Location = new System.Drawing.Point(206, 47);
            this.txt_PhoneSrch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_PhoneSrch.Multiline = true;
            this.txt_PhoneSrch.Name = "txt_PhoneSrch";
            this.txt_PhoneSrch.Size = new System.Drawing.Size(125, 23);
            this.txt_PhoneSrch.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(354, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 68;
            this.label6.Text = "رقم المورد";
            // 
            // checked_Supplier
            // 
            this.checked_Supplier.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checked_Supplier.CheckOnClick = true;
            this.checked_Supplier.ForeColor = System.Drawing.Color.Firebrick;
            this.checked_Supplier.FormattingEnabled = true;
            this.checked_Supplier.Items.AddRange(new object[] {
            "تعديل بيانات مورد سابق",
            "اضافه مورد جديد"});
            this.checked_Supplier.Location = new System.Drawing.Point(737, 72);
            this.checked_Supplier.Name = "checked_Supplier";
            this.checked_Supplier.Size = new System.Drawing.Size(143, 34);
            this.checked_Supplier.TabIndex = 67;
            this.checked_Supplier.SelectedIndexChanged += new System.EventHandler(this.checked_Supplier_SelectedIndexChanged);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_add.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.Location = new System.Drawing.Point(441, 386);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(99, 37);
            this.btn_add.TabIndex = 66;
            this.btn_add.Text = "اضافه مورد";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_srch
            // 
            this.btn_srch.BackColor = System.Drawing.Color.Transparent;
            this.btn_srch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_srch.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_srch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_srch.Location = new System.Drawing.Point(77, 34);
            this.btn_srch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_srch.Name = "btn_srch";
            this.btn_srch.Size = new System.Drawing.Size(85, 24);
            this.btn_srch.TabIndex = 65;
            this.btn_srch.Text = "يحث";
            this.btn_srch.UseVisualStyleBackColor = false;
            // 
            // txt_SupplierNameSrch
            // 
            this.txt_SupplierNameSrch.Location = new System.Drawing.Point(206, 20);
            this.txt_SupplierNameSrch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SupplierNameSrch.Multiline = true;
            this.txt_SupplierNameSrch.Name = "txt_SupplierNameSrch";
            this.txt_SupplierNameSrch.Size = new System.Drawing.Size(125, 23);
            this.txt_SupplierNameSrch.TabIndex = 64;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(352, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 63;
            this.label5.Text = "اسم المورد";
            // 
            // btn_rfrch
            // 
            this.btn_rfrch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rfrch.BackgroundImage")));
            this.btn_rfrch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rfrch.Location = new System.Drawing.Point(-53, 30);
            this.btn_rfrch.Name = "btn_rfrch";
            this.btn_rfrch.Size = new System.Drawing.Size(43, 38);
            this.btn_rfrch.TabIndex = 62;
            this.btn_rfrch.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(668, 386);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // btn_dell
            // 
            this.btn_dell.BackColor = System.Drawing.Color.Transparent;
            this.btn_dell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_dell.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_dell.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dell.Location = new System.Drawing.Point(571, 386);
            this.btn_dell.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dell.Name = "btn_dell";
            this.btn_dell.Size = new System.Drawing.Size(99, 37);
            this.btn_dell.TabIndex = 60;
            this.btn_dell.Text = "حذف";
            this.btn_dell.UseVisualStyleBackColor = false;
            // 
            // dataGridView_Users
            // 
            this.dataGridView_Users.AutoGenerateColumns = false;
            this.dataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView_Users.DataSource = this.supplierBindingSource;
            this.dataGridView_Users.Location = new System.Drawing.Point(12, 83);
            this.dataGridView_Users.Name = "dataGridView_Users";
            this.dataGridView_Users.Size = new System.Drawing.Size(403, 349);
            this.dataGridView_Users.TabIndex = 59;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // noteDataGridViewTextBoxColumn
            // 
            this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
            this.noteDataGridViewTextBoxColumn.HeaderText = "Note";
            this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.casheerDataSet4;
            // 
            // casheerDataSet4
            // 
            this.casheerDataSet4.DataSetName = "casheerDataSet4";
            this.casheerDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(854, 386);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Save.Location = new System.Drawing.Point(726, 386);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 37);
            this.btn_Save.TabIndex = 57;
            this.btn_Save.Text = "حفظ البيانات الجديده";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // picture_Supplier
            // 
            this.picture_Supplier.Location = new System.Drawing.Point(668, 235);
            this.picture_Supplier.Margin = new System.Windows.Forms.Padding(2);
            this.picture_Supplier.Name = "picture_Supplier";
            this.picture_Supplier.Size = new System.Drawing.Size(107, 102);
            this.picture_Supplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_Supplier.TabIndex = 56;
            this.picture_Supplier.TabStop = false;
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(588, 186);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Phone.Multiline = true;
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.PasswordChar = '*';
            this.txt_Phone.Size = new System.Drawing.Size(187, 28);
            this.txt_Phone.TabIndex = 55;
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Location = new System.Drawing.Point(588, 138);
            this.txt_SupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SupplierName.Multiline = true;
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(187, 28);
            this.txt_SupplierName.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(790, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 53;
            this.label4.Text = "صوره المورد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(805, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 52;
            this.label3.Text = "رقم الهاتف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(799, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 27);
            this.label2.TabIndex = 51;
            this.label2.Text = "اسم االمورد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(451, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 38);
            this.label1.TabIndex = 50;
            this.label1.Text = "تعديل بيانات االمورد او اضافه مورد جديد";
            // 
            // btn_refrsh
            // 
            this.btn_refrsh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_refrsh.BackgroundImage")));
            this.btn_refrsh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_refrsh.Location = new System.Drawing.Point(12, 28);
            this.btn_refrsh.Name = "btn_refrsh";
            this.btn_refrsh.Size = new System.Drawing.Size(43, 38);
            this.btn_refrsh.TabIndex = 70;
            this.btn_refrsh.UseVisualStyleBackColor = true;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(909, 450);
            this.Controls.Add(this.btn_refrsh);
            this.Controls.Add(this.txt_PhoneSrch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checked_Supplier);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_srch);
            this.Controls.Add(this.txt_SupplierNameSrch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_rfrch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_dell);
            this.Controls.Add(this.dataGridView_Users);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.picture_Supplier);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.txt_SupplierName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdateSupplier";
            this.Text = "UpdateSupplier";
            this.Load += new System.EventHandler(this.UpdateSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casheerDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Supplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_PhoneSrch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checked_Supplier;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_srch;
        private System.Windows.Forms.TextBox txt_SupplierNameSrch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rfrch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_dell;
        private System.Windows.Forms.DataGridView dataGridView_Users;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox picture_Supplier;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_SupplierName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_refrsh;
        private casheerDataSet4 casheerDataSet4;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private casheerDataSet4TableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}