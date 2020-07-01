using System;
using System.Windows.Forms;

namespace cursrab3
{
    public partial class Form4 : Form
    {
        private User user;

        public Form4(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.restrictionsTableAdapter.Fill(this.meal_dbDataSet.Restrictions);
            this.mealsTableAdapter.Fill(this.meal_dbDataSet.Meals);
            this.zakazsTableAdapter.Fill(this.meal_dbDataSet.Zakazs);
            this.dataGridView1.AutoGenerateColumns = true;

        }     

        private void radioButtonZakazs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.zakazsBindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

       
        private void radioButtonRestrictions_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.restrictionsBindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void radioButtonMeals_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.mealsBindingSource;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonMeals.Checked == true)
            {
                mealsBindingSource.EndEdit();
                this.mealsTableAdapter.Update(this.meal_dbDataSet.Meals);
                MessageBox.Show("Сохранено");
            }
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            dataGridView1.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                commentsTableAdapter1.InsertQuery(textBox1.Text, user.userId);
            }
            MessageBox.Show("Сохранено");
            textBox1.Text = "";
        }
    }
}
