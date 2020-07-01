namespace cursrab3
{
    partial class Form4
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
            this.zakazIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.b3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakazsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meal_dbDataSet = new cursrab3.meal_dbDataSet();
            this.restrictionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMeals = new System.Windows.Forms.RadioButton();
            this.radioButtonRestrictions = new System.Windows.Forms.RadioButton();
            this.radioButtonZakazs = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.ZakazsTableAdapter();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.MealsTableAdapter();
            this.usersTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.UsersTableAdapter();
            this.restrictionsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.RestrictionsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.commentsTableAdapter1 = new cursrab3.meal_dbDataSetTableAdapters.CommentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictionsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zakazIdDataGridViewTextBoxColumn,
            this.useridDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.b1DataGridViewTextBoxColumn,
            this.b2DataGridViewTextBoxColumn,
            this.b3DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zakazsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(896, 199);
            this.dataGridView1.TabIndex = 1;
            // 
            // zakazIdDataGridViewTextBoxColumn
            // 
            this.zakazIdDataGridViewTextBoxColumn.DataPropertyName = "zakazId";
            this.zakazIdDataGridViewTextBoxColumn.HeaderText = "zakazId";
            this.zakazIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zakazIdDataGridViewTextBoxColumn.Name = "zakazIdDataGridViewTextBoxColumn";
            this.zakazIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.zakazIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // useridDataGridViewTextBoxColumn
            // 
            this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
            this.useridDataGridViewTextBoxColumn.HeaderText = "user_id";
            this.useridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
            this.useridDataGridViewTextBoxColumn.ReadOnly = true;
            this.useridDataGridViewTextBoxColumn.Width = 125;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "created";
            this.createdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            this.createdDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // b1DataGridViewTextBoxColumn
            // 
            this.b1DataGridViewTextBoxColumn.DataPropertyName = "b1";
            this.b1DataGridViewTextBoxColumn.HeaderText = "b1";
            this.b1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.b1DataGridViewTextBoxColumn.Name = "b1DataGridViewTextBoxColumn";
            this.b1DataGridViewTextBoxColumn.ReadOnly = true;
            this.b1DataGridViewTextBoxColumn.Width = 125;
            // 
            // b2DataGridViewTextBoxColumn
            // 
            this.b2DataGridViewTextBoxColumn.DataPropertyName = "b2";
            this.b2DataGridViewTextBoxColumn.HeaderText = "b2";
            this.b2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.b2DataGridViewTextBoxColumn.Name = "b2DataGridViewTextBoxColumn";
            this.b2DataGridViewTextBoxColumn.ReadOnly = true;
            this.b2DataGridViewTextBoxColumn.Width = 125;
            // 
            // b3DataGridViewTextBoxColumn
            // 
            this.b3DataGridViewTextBoxColumn.DataPropertyName = "b3";
            this.b3DataGridViewTextBoxColumn.HeaderText = "b3";
            this.b3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.b3DataGridViewTextBoxColumn.Name = "b3DataGridViewTextBoxColumn";
            this.b3DataGridViewTextBoxColumn.ReadOnly = true;
            this.b3DataGridViewTextBoxColumn.Width = 125;
            // 
            // zakazsBindingSource
            // 
            this.zakazsBindingSource.DataMember = "Zakazs";
            this.zakazsBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // meal_dbDataSet
            // 
            this.meal_dbDataSet.DataSetName = "meal_dbDataSet";
            this.meal_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restrictionsBindingSource
            // 
            this.restrictionsBindingSource.DataMember = "Restrictions";
            this.restrictionsBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMeals);
            this.groupBox1.Controls.Add(this.radioButtonRestrictions);
            this.groupBox1.Controls.Add(this.radioButtonZakazs);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 193);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите таблицу";
            // 
            // radioButtonMeals
            // 
            this.radioButtonMeals.AutoSize = true;
            this.radioButtonMeals.Location = new System.Drawing.Point(6, 85);
            this.radioButtonMeals.Name = "radioButtonMeals";
            this.radioButtonMeals.Size = new System.Drawing.Size(66, 21);
            this.radioButtonMeals.TabIndex = 4;
            this.radioButtonMeals.Text = "Meals";
            this.radioButtonMeals.UseVisualStyleBackColor = true;
            this.radioButtonMeals.Click += new System.EventHandler(this.radioButtonMeals_Click);
            // 
            // radioButtonRestrictions
            // 
            this.radioButtonRestrictions.AutoSize = true;
            this.radioButtonRestrictions.Location = new System.Drawing.Point(6, 58);
            this.radioButtonRestrictions.Name = "radioButtonRestrictions";
            this.radioButtonRestrictions.Size = new System.Drawing.Size(103, 21);
            this.radioButtonRestrictions.TabIndex = 3;
            this.radioButtonRestrictions.Text = "Restrictions";
            this.radioButtonRestrictions.UseVisualStyleBackColor = true;
            this.radioButtonRestrictions.Click += new System.EventHandler(this.radioButtonRestrictions_Click);
            // 
            // radioButtonZakazs
            // 
            this.radioButtonZakazs.AutoSize = true;
            this.radioButtonZakazs.Checked = true;
            this.radioButtonZakazs.Location = new System.Drawing.Point(6, 31);
            this.radioButtonZakazs.Name = "radioButtonZakazs";
            this.radioButtonZakazs.Size = new System.Drawing.Size(75, 21);
            this.radioButtonZakazs.TabIndex = 1;
            this.radioButtonZakazs.TabStop = true;
            this.radioButtonZakazs.Text = "Zakazs";
            this.radioButtonZakazs.UseVisualStyleBackColor = true;
            this.radioButtonZakazs.Click += new System.EventHandler(this.radioButtonZakazs_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(338, 245);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 52);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRevert
            // 
            this.buttonRevert.Location = new System.Drawing.Point(338, 343);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(100, 52);
            this.buttonRevert.TabIndex = 6;
            this.buttonRevert.Text = "Сбросить";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // zakazsTableAdapter
            // 
            this.zakazsTableAdapter.ClearBeforeFill = true;
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataMember = "Meals";
            this.mealsBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // mealsTableAdapter
            // 
            this.mealsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // restrictionsTableAdapter
            // 
            this.restrictionsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(493, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 12;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(490, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Отзыв о работе";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(415, 106);
            this.textBox1.TabIndex = 10;
            // 
            // commentsTableAdapter1
            // 
            this.commentsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRevert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Cooker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictionsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private meal_dbDataSet meal_dbDataSet;
        private System.Windows.Forms.BindingSource zakazsBindingSource;
        private meal_dbDataSetTableAdapters.ZakazsTableAdapter zakazsTableAdapter;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private meal_dbDataSetTableAdapters.MealsTableAdapter mealsTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMeals;
        private System.Windows.Forms.RadioButton radioButtonRestrictions;
        private System.Windows.Forms.RadioButton radioButtonZakazs;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private meal_dbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource restrictionsBindingSource;
        private meal_dbDataSetTableAdapters.RestrictionsTableAdapter restrictionsTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.DataGridViewTextBoxColumn restricrionIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private meal_dbDataSetTableAdapters.CommentsTableAdapter commentsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn zakazIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn b3DataGridViewTextBoxColumn;
    }
}