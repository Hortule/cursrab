using System;
using System.Windows.Forms;

namespace cursrab3
{
    public partial class Form3 : Form
    {
        private User user;

        public Form3(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // получение данных из бд в датасеты
            this.restrictionsTableAdapter.Fill(this.meal_dbDataSet.Restrictions);
            this.usersTableAdapter.Fill(this.meal_dbDataSet.Users);
            this.mealsTableAdapter.Fill(this.meal_dbDataSet.Meals);
            this.zakazsTableAdapter.Fill(this.meal_dbDataSet.Zakazs);
            this.dataGridView1.AutoGenerateColumns = true;

        }
        private void radioButtonUsers_Click(object sender, EventArgs e)
        {
            // открытие таблицы с правами соответствующими уровню доступа
            dataGridView1.DataSource = this.usersBindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void radioButtonZakazs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.zakazsBindingSource;
            dataGridView1.AllowUserToAddRows = true;
            dataGridView1.AllowUserToDeleteRows = true;
            dataGridView1.ReadOnly = false;
        }

       
        private void radioButtonRestrictions_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.restrictionsBindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void radioButtonMeals_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.mealsBindingSource;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            // закрытие приложения
            Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // сохранение изменений в бд
            if (radioButtonZakazs.Checked == true)
            {
                zakazsBindingSource.EndEdit();
                this.zakazsTableAdapter.Update(this.meal_dbDataSet.Zakazs);
                MessageBox.Show("Сохранено");
            }
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            // отена изменений
            dataGridView1.CancelEdit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // запись отзыва в бд
            if (textBox1.Text != "")
            {
                commentsTableAdapter1.InsertQuery(textBox1.Text, user.userId);
            }
            MessageBox.Show("Сохранено");
            textBox1.Text = "";
        }
    }
}
