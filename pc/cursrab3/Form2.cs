using System;
using System.Windows.Forms;

namespace cursrab3
{
    public partial class Form2 : Form
    {
        public User user;

        public Form2(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // получение данных из бд в датасеты
            this.restrictionsTableAdapter.Fill(this.meal_dbDataSet.Restrictions);
            this.mealsTableAdapter.Fill(this.meal_dbDataSet.Meals);   
            this.commentsTableAdapter.Fill(this.meal_dbDataSet.Comments);
            this.zakazsTableAdapter.Fill(this.meal_dbDataSet.Zakazs);
            this.usersTableAdapter.Fill(this.meal_dbDataSet.Users);
            this.dataGridView1.AutoGenerateColumns = true;
        }

        private void radioButtonUsers_Click(object sender, EventArgs e)
        {
            // открытие таблицы с правами соответствующими уровню доступа
            dataGridView1.DataSource = this.usersBindingSource;
        }

        private void radioButtonZakazs_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.zakazsBindingSource;
        }

        private void radioButtonComments_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.commentsBindingSource;
        }

        private void radioButtonRestrictions_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.restrictionsBindingSource;
        }

        private void radioButtonMeals_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.mealsBindingSource;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (radioButtonMeals.Checked == true)
            {
                mealsBindingSource.EndEdit();
                this.mealsTableAdapter.Update(this.meal_dbDataSet.Meals);
                MessageBox.Show("Сохранено");
            }
            if (radioButtonComments.Checked == true)
            {
                commentsBindingSource.EndEdit();
                this.commentsTableAdapter.Update(this.meal_dbDataSet.Comments);
                MessageBox.Show("Сохранено");
            }
            if (radioButtonRestrictions.Checked == true)
            {
                restrictionsBindingSource.EndEdit();
                this.restrictionsTableAdapter.Update(this.meal_dbDataSet.Restrictions);
                MessageBox.Show("Сохранено");
            }
            if (radioButtonUsers.Checked == true)
            {
                usersBindingSource.EndEdit();
                this.usersTableAdapter.Update(this.meal_dbDataSet.Users);
                MessageBox.Show("Сохранено");
            }
            if (radioButtonZakazs.Checked == true)
            {
                zakazsBindingSource.EndEdit();
                this.zakazsTableAdapter.Update(this.meal_dbDataSet.Zakazs);
                MessageBox.Show("Сохранено");
            }
        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            // отмена изменений
            dataGridView1.CancelEdit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // закрытие приложения
            Application.Exit();
        }
    }
}
