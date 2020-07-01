namespace cursrab3
{
    partial class Form5
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
            this.buttonRevert = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonMeals = new System.Windows.Forms.RadioButton();
            this.radioButtonRestrictions = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restrictionsIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restrictionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meal_dbDataSet = new cursrab3.meal_dbDataSet();
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.MealsTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.UsersTableAdapter();
            this.restrictionsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.RestrictionsTableAdapter();
            this.zakazsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zakazsTableAdapter = new cursrab3.meal_dbDataSetTableAdapters.ZakazsTableAdapter();
            this.commentsTableAdapter1 = new cursrab3.meal_dbDataSetTableAdapters.CommentsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRevert
            // 
            this.buttonRevert.Location = new System.Drawing.Point(331, 338);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(100, 52);
            this.buttonRevert.TabIndex = 10;
            this.buttonRevert.Text = "Сбросить";
            this.buttonRevert.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(331, 245);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 52);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMeals);
            this.groupBox1.Controls.Add(this.radioButtonRestrictions);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 193);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите таблицу";
            // 
            // radioButtonMeals
            // 
            this.radioButtonMeals.AutoSize = true;
            this.radioButtonMeals.Location = new System.Drawing.Point(6, 58);
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
            this.radioButtonRestrictions.Checked = true;
            this.radioButtonRestrictions.Location = new System.Drawing.Point(6, 31);
            this.radioButtonRestrictions.Name = "radioButtonRestrictions";
            this.radioButtonRestrictions.Size = new System.Drawing.Size(103, 21);
            this.radioButtonRestrictions.TabIndex = 3;
            this.radioButtonRestrictions.TabStop = true;
            this.radioButtonRestrictions.Text = "Restrictions";
            this.radioButtonRestrictions.UseVisualStyleBackColor = true;
            this.radioButtonRestrictions.CheckedChanged += new System.EventHandler(this.radioButtonRestrictions_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.commentDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.restrictionsIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.restrictionsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 199);
            this.dataGridView1.TabIndex = 7;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 125;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // restrictionsIdDataGridViewTextBoxColumn
            // 
            this.restrictionsIdDataGridViewTextBoxColumn.DataPropertyName = "restrictionsId";
            this.restrictionsIdDataGridViewTextBoxColumn.HeaderText = "restrictionsId";
            this.restrictionsIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.restrictionsIdDataGridViewTextBoxColumn.Name = "restrictionsIdDataGridViewTextBoxColumn";
            this.restrictionsIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.restrictionsIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // restrictionsBindingSource
            // 
            this.restrictionsBindingSource.DataMember = "Restrictions";
            this.restrictionsBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // meal_dbDataSet
            // 
            this.meal_dbDataSet.DataSetName = "meal_dbDataSet";
            this.meal_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.meal_dbDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // restrictionsTableAdapter
            // 
            this.restrictionsTableAdapter.ClearBeforeFill = true;
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
            // commentsTableAdapter1
            // 
            this.commentsTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Отзыв о работе";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(458, 245);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 113);
            this.textBox1.TabIndex = 11;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonRevert);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Medic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restrictionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meal_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakazsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonMeals;
        private System.Windows.Forms.RadioButton radioButtonRestrictions;
        private System.Windows.Forms.DataGridView dataGridView1;
        private meal_dbDataSet meal_dbDataSet;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private meal_dbDataSetTableAdapters.MealsTableAdapter mealsTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private meal_dbDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource restrictionsBindingSource;
        private meal_dbDataSetTableAdapters.RestrictionsTableAdapter restrictionsTableAdapter;
        private System.Windows.Forms.BindingSource zakazsBindingSource;
        private meal_dbDataSetTableAdapters.ZakazsTableAdapter zakazsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restrictionsIdDataGridViewTextBoxColumn;
        private meal_dbDataSetTableAdapters.CommentsTableAdapter commentsTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}