namespace cursrab3
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meal_dbDataSet = new cursrab3.meal_dbDataSet();
            this.restrictionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.UsersTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMeals = new System.Windows.Forms.RadioButton();
            this.radioButtonRestrictions = new System.Windows.Forms.RadioButton();
            this.radioButtonComments = new System.Windows.Forms.RadioButton();
            this.radioButtonZakazs = new System.Windows.Forms.RadioButton();
            this.radioButtonUsers = new System.Windows.Forms.RadioButton();
            this.zakazsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.ZakazsTableAdapter();
            this.commentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.CommentsTableAdapter();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.MealsTableAdapter();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.restrictionsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.RestrictionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealdbDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.clasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(798, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // clasDataGridViewTextBoxColumn
            // 
            this.clasDataGridViewTextBoxColumn.DataPropertyName = "clas";
            this.clasDataGridViewTextBoxColumn.HeaderText = "clas";
            this.clasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clasDataGridViewTextBoxColumn.Name = "clasDataGridViewTextBoxColumn";
            this.clasDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // meal_dbDataSet
            // 
            this.meal_dbDataSet.DataSetName = "meal_dbDataSet";
            this.meal_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restrictionsBindingSource
            // 
            this.restrictionsBindingSource.DataMember = "Restrictions";
            this.restrictionsBindingSource.DataSource = this.mealdbDataSetBindingSource;
            // 
            // mealdbDataSetBindingSource
            // 
            this.mealdbDataSetBindingSource.DataSource = this.meal_dbDataSet;
            this.mealdbDataSetBindingSource.Position = 0;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMeals);
            this.groupBox1.Controls.Add(this.radioButtonRestrictions);
            this.groupBox1.Controls.Add(this.radioButtonComments);
            this.groupBox1.Controls.Add(this.radioButtonZakazs);
            this.groupBox1.Controls.Add(this.radioButtonUsers);
            this.groupBox1.Location = new System.Drawing.Point(33, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 193);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите таблицу";
            // 
            // radioButtonMeals
            // 
            this.radioButtonMeals.AutoSize = true;
            this.radioButtonMeals.Location = new System.Drawing.Point(6, 139);
            this.radioButtonMeals.Name = "radioButtonMeals";
            this.radioButtonMeals.Size = new System.Drawing.Size(66, 21);
            this.radioButtonMeals.TabIndex = 4;
            this.radioButtonMeals.TabStop = true;
            this.radioButtonMeals.Text = "Meals";
            this.radioButtonMeals.UseVisualStyleBackColor = true;
            this.radioButtonMeals.Click += new System.EventHandler(this.radioButtonMeals_Click);
            // 
            // radioButtonRestrictions
            // 
            this.radioButtonRestrictions.AutoSize = true;
            this.radioButtonRestrictions.Location = new System.Drawing.Point(6, 112);
            this.radioButtonRestrictions.Name = "radioButtonRestrictions";
            this.radioButtonRestrictions.Size = new System.Drawing.Size(103, 21);
            this.radioButtonRestrictions.TabIndex = 3;
            this.radioButtonRestrictions.TabStop = true;
            this.radioButtonRestrictions.Text = "Restrictions";
            this.radioButtonRestrictions.UseVisualStyleBackColor = true;
            this.radioButtonRestrictions.Click += new System.EventHandler(this.radioButtonRestrictions_Click);
            // 
            // radioButtonComments
            // 
            this.radioButtonComments.AutoSize = true;
            this.radioButtonComments.Location = new System.Drawing.Point(6, 85);
            this.radioButtonComments.Name = "radioButtonComments";
            this.radioButtonComments.Size = new System.Drawing.Size(95, 21);
            this.radioButtonComments.TabIndex = 2;
            this.radioButtonComments.TabStop = true;
            this.radioButtonComments.Text = "Comments";
            this.radioButtonComments.UseVisualStyleBackColor = true;
            this.radioButtonComments.Click += new System.EventHandler(this.radioButtonComments_Click);
            // 
            // radioButtonZakazs
            // 
            this.radioButtonZakazs.AutoSize = true;
            this.radioButtonZakazs.Location = new System.Drawing.Point(6, 58);
            this.radioButtonZakazs.Name = "radioButtonZakazs";
            this.radioButtonZakazs.Size = new System.Drawing.Size(75, 21);
            this.radioButtonZakazs.TabIndex = 1;
            this.radioButtonZakazs.TabStop = true;
            this.radioButtonZakazs.Text = "Zakazs";
            this.radioButtonZakazs.UseVisualStyleBackColor = true;
            this.radioButtonZakazs.Click += new System.EventHandler(this.radioButtonZakazs_Click);
            // 
            // radioButtonUsers
            // 
            this.radioButtonUsers.AutoSize = true;
            this.radioButtonUsers.Checked = true;
            this.radioButtonUsers.Location = new System.Drawing.Point(6, 31);
            this.radioButtonUsers.Name = "radioButtonUsers";
            this.radioButtonUsers.Size = new System.Drawing.Size(66, 21);
            this.radioButtonUsers.TabIndex = 0;
            this.radioButtonUsers.TabStop = true;
            this.radioButtonUsers.Text = "Users";
            this.radioButtonUsers.UseVisualStyleBackColor = true;
            this.radioButtonUsers.Click += new System.EventHandler(this.radioButtonUsers_Click);
            // 
            // zakazsBindingSource
            // 
            this.zakazsBindingSource.DataMember = "Zakazs";
            this.zakazsBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // zakazsTableAdapter
            // 
            this.zakazsTableAdapter.ClearBeforeFill = true;
            // 
            // commentsBindingSource
            // 
            this.commentsBindingSource.DataMember = "Comments";
            this.commentsBindingSource.DataSource = this.mealdbDataSetBindingSource;
            // 
            // commentsTableAdapter
            // 
            this.commentsTableAdapter.ClearBeforeFill = true;
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataMember = "Meals";
            this.mealsBindingSource.DataSource = this.mealdbDataSetBindingSource;
            // 
            // mealsTableAdapter
            // 
            this.mealsTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(371, 233);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 52);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRevert
            // 
            this.buttonRevert.Location = new System.Drawing.Point(515, 233);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(100, 52);
            this.buttonRevert.TabIndex = 3;
            this.buttonRevert.Text = "Сбросить";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // restrictionsTableAdapter
            // 
            this.restrictionsTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.buttonRevert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealdbDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zakazsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private meal_dbDataSet meal_dbDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private meal_dbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonUsers;
        private System.Windows.Forms.BindingSource zakazsBindingSource;
        private meal_dbDataSetTableAdapters.ZakazsTableAdapter zakazsTableAdapter;
        private System.Windows.Forms.BindingSource mealdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource commentsBindingSource;
        private meal_dbDataSetTableAdapters.CommentsTableAdapter commentsTableAdapter;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private meal_dbDataSetTableAdapters.MealsTableAdapter mealsTableAdapter;
        private System.Windows.Forms.RadioButton radioButtonZakazs;
        private System.Windows.Forms.RadioButton radioButtonRestrictions;
        private System.Windows.Forms.RadioButton radioButtonComments;
        private System.Windows.Forms.RadioButton radioButtonMeals;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.BindingSource restrictionsBindingSource;
        private meal_dbDataSetTableAdapters.RestrictionsTableAdapter restrictionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn restrictionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}