namespace Client
{
    partial class ClientForm
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
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.TabMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonClientEdit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClientCreate = new System.Windows.Forms.Button();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFamilyName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxEmployeeService = new System.Windows.Forms.TextBox();
            this.textBoxEmployeePhone = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeName = new System.Windows.Forms.TextBox();
            this.textBoxEmployeeFamilyName = new System.Windows.Forms.TextBox();
            this.buttonEmployeeDelete = new System.Windows.Forms.Button();
            this.buttonEmployeeEdit = new System.Windows.Forms.Button();
            this.buttonEmployeeCreate = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.TabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AllowUserToResizeColumns = false;
            this.dataGridViewClient.AllowUserToResizeRows = false;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.RowTemplate.Height = 24;
            this.dataGridViewClient.Size = new System.Drawing.Size(564, 331);
            this.dataGridViewClient.TabIndex = 0;
            this.dataGridViewClient.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClient_CellMouseClick);
            // 
            // TabMenu
            // 
            this.TabMenu.Controls.Add(this.tabPage1);
            this.TabMenu.Controls.Add(this.tabPage2);
            this.TabMenu.Controls.Add(this.tabPage3);
            this.TabMenu.Location = new System.Drawing.Point(12, 1);
            this.TabMenu.Name = "TabMenu";
            this.TabMenu.SelectedIndex = 0;
            this.TabMenu.Size = new System.Drawing.Size(822, 367);
            this.TabMenu.TabIndex = 0;
            this.TabMenu.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabMenu_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonClientEdit);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonClientCreate);
            this.tabPage1.Controls.Add(this.textBoxCompany);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.textBoxFamilyName);
            this.tabPage1.Controls.Add(this.dataGridViewClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(814, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Onglet Client";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonClientEdit
            // 
            this.buttonClientEdit.Location = new System.Drawing.Point(695, 241);
            this.buttonClientEdit.Name = "buttonClientEdit";
            this.buttonClientEdit.Size = new System.Drawing.Size(115, 93);
            this.buttonClientEdit.TabIndex = 13;
            this.buttonClientEdit.Text = "Edit";
            this.buttonClientEdit.UseVisualStyleBackColor = true;
            this.buttonClientEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(655, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Entreprise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom";
            // 
            // buttonClientCreate
            // 
            this.buttonClientCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonClientCreate.Location = new System.Drawing.Point(573, 241);
            this.buttonClientCreate.Name = "buttonClientCreate";
            this.buttonClientCreate.Size = new System.Drawing.Size(116, 93);
            this.buttonClientCreate.TabIndex = 9;
            this.buttonClientCreate.Text = "Create";
            this.buttonClientCreate.UseVisualStyleBackColor = true;
            this.buttonClientCreate.Click += new System.EventHandler(this.buttonCreateClient_Click);
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(604, 160);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(180, 22);
            this.textBoxCompany.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(604, 102);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 22);
            this.textBoxName.TabIndex = 7;
            // 
            // textBoxFamilyName
            // 
            this.textBoxFamilyName.Location = new System.Drawing.Point(604, 50);
            this.textBoxFamilyName.Name = "textBoxFamilyName";
            this.textBoxFamilyName.Size = new System.Drawing.Size(180, 22);
            this.textBoxFamilyName.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.dataGridViewParts);
            this.tabPage2.Controls.Add(this.dataGridViewProduct);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(814, 338);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Onglet Plan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(534, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "COMPOSANTS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(118, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "PRODUITS";
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AllowUserToResizeColumns = false;
            this.dataGridViewParts.AllowUserToResizeRows = false;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Location = new System.Drawing.Point(411, 38);
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            this.dataGridViewParts.RowTemplate.Height = 24;
            this.dataGridViewParts.Size = new System.Drawing.Size(400, 300);
            this.dataGridViewParts.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(3, 38);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            this.dataGridViewProduct.RowTemplate.Height = 24;
            this.dataGridViewProduct.Size = new System.Drawing.Size(400, 300);
            this.dataGridViewProduct.TabIndex = 0;
            this.dataGridViewProduct.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxEmployeeService);
            this.tabPage3.Controls.Add(this.textBoxEmployeePhone);
            this.tabPage3.Controls.Add(this.textBoxEmployeeName);
            this.tabPage3.Controls.Add(this.textBoxEmployeeFamilyName);
            this.tabPage3.Controls.Add(this.buttonEmployeeDelete);
            this.tabPage3.Controls.Add(this.buttonEmployeeEdit);
            this.tabPage3.Controls.Add(this.buttonEmployeeCreate);
            this.tabPage3.Controls.Add(this.dataGridViewEmployee);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(814, 338);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Onglet RH";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(598, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Service";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(598, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nom";
            // 
            // textBoxEmployeeService
            // 
            this.textBoxEmployeeService.Location = new System.Drawing.Point(707, 106);
            this.textBoxEmployeeService.Name = "textBoxEmployeeService";
            this.textBoxEmployeeService.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployeeService.TabIndex = 7;
            // 
            // textBoxEmployeePhone
            // 
            this.textBoxEmployeePhone.Location = new System.Drawing.Point(707, 78);
            this.textBoxEmployeePhone.Name = "textBoxEmployeePhone";
            this.textBoxEmployeePhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployeePhone.TabIndex = 6;
            // 
            // textBoxEmployeeName
            // 
            this.textBoxEmployeeName.Location = new System.Drawing.Point(707, 50);
            this.textBoxEmployeeName.Name = "textBoxEmployeeName";
            this.textBoxEmployeeName.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployeeName.TabIndex = 5;
            // 
            // textBoxEmployeeFamilyName
            // 
            this.textBoxEmployeeFamilyName.Location = new System.Drawing.Point(707, 22);
            this.textBoxEmployeeFamilyName.Name = "textBoxEmployeeFamilyName";
            this.textBoxEmployeeFamilyName.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmployeeFamilyName.TabIndex = 4;
            // 
            // buttonEmployeeDelete
            // 
            this.buttonEmployeeDelete.Location = new System.Drawing.Point(744, 296);
            this.buttonEmployeeDelete.Name = "buttonEmployeeDelete";
            this.buttonEmployeeDelete.Size = new System.Drawing.Size(67, 37);
            this.buttonEmployeeDelete.TabIndex = 3;
            this.buttonEmployeeDelete.Text = "Delete";
            this.buttonEmployeeDelete.UseVisualStyleBackColor = true;
            this.buttonEmployeeDelete.Click += new System.EventHandler(this.buttonEmployeeDelete_Click);
            // 
            // buttonEmployeeEdit
            // 
            this.buttonEmployeeEdit.Location = new System.Drawing.Point(674, 296);
            this.buttonEmployeeEdit.Name = "buttonEmployeeEdit";
            this.buttonEmployeeEdit.Size = new System.Drawing.Size(64, 37);
            this.buttonEmployeeEdit.TabIndex = 2;
            this.buttonEmployeeEdit.Text = "Edit";
            this.buttonEmployeeEdit.UseVisualStyleBackColor = true;
            this.buttonEmployeeEdit.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonEmployeeCreate
            // 
            this.buttonEmployeeCreate.Location = new System.Drawing.Point(601, 296);
            this.buttonEmployeeCreate.Name = "buttonEmployeeCreate";
            this.buttonEmployeeCreate.Size = new System.Drawing.Size(67, 36);
            this.buttonEmployeeCreate.TabIndex = 1;
            this.buttonEmployeeCreate.Text = "Add";
            this.buttonEmployeeCreate.UseVisualStyleBackColor = true;
            this.buttonEmployeeCreate.Click += new System.EventHandler(this.buttonEmployeeCreate_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AllowUserToResizeColumns = false;
            this.dataGridViewEmployee.AllowUserToResizeRows = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(592, 332);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Click_EmployeeDataGrid);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 372);
            this.Controls.Add(this.TabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Super Programme de ouf";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.TabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.DataGridView GetDataGridViewClient()
        {
            return this.dataGridViewClient;
        }

        public System.Windows.Forms.DataGridView GetDataGridViewProduct()
        {
            return this.dataGridViewProduct;
        }

        public System.Windows.Forms.DataGridView GetDataGridViewEmployee()
        {
            return this.dataGridViewEmployee;
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.TabControl TabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClientCreate;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFamilyName;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonClientEdit;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEmployeeEdit;
        private System.Windows.Forms.Button buttonEmployeeCreate;
        private System.Windows.Forms.Button buttonEmployeeDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxEmployeeService;
        private System.Windows.Forms.TextBox textBoxEmployeePhone;
        private System.Windows.Forms.TextBox textBoxEmployeeName;
        private System.Windows.Forms.TextBox textBoxEmployeeFamilyName;
    }
    #endregion
}