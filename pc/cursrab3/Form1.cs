using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace cursrab3
{
    public partial class Form1 : Form
    {
        public User user;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = PasswordBox.Text;
            string hash = "";
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (u.login == login) // сохранение данных авторизовавшегося пользователя
                    {
                        hash = u.password;
                        user = u;
                        break;
                    }
                }
            }

            using (SHA256 sha256Hash = SHA256.Create())
            {
                if (VerifyHash(sha256Hash, password, hash))
                {
                    Console.WriteLine("The hashes are the same.");
                    if (user.clas == 0) // administrator
                    {
                        Form2 f = new Form2(user);
                        f.Show();
                        this.Hide();
                    }
                    if (user.clas > 0 && user.clas < 12) // teacher
                    {                               
                        Form3 f = new Form3(user);
                        f.Show();
                        this.Hide();
                    }
                    if (user.clas == -1) // cooker
                    {
                        Form4 f = new Form4(user);
                        f.Show();
                        this.Hide();
                    }
                    if (user.clas == -2) // medic
                    {
                        Form5 f = new Form5(user);
                        f.Show();
                        this.Hide();
                    }
                    Random random = new Random();
                    int s_id = random.Next(1, 100000000);
                    string os_v = Environment.OSVersion.ToString();
                    string arch = Environment.Is64BitOperatingSystem.ToString();
                    this.queriesTableAdapter1.InsertOS(os_v, arch, s_id.ToString()); // вставка в бд информации об ос 
                    this.queriesTableAdapter1.InsertSession(s_id.ToString(), user.userId); 
                } else
                {
                    user = null;
                    MessageBox.Show("Неверные данные");
                }
            }
            
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input) // получение хэша пароля
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash) // сравнение хэшей
        {
            
            var hashOfInput = GetHash(hashAlgorithm, input);
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            return comparer.Compare(hashOfInput, hash) == 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.sessionTableAdapter.Fill(this.sessions_dbDataSet.session); // получение данных из бд в датасет
            this.osTableAdapter.Fill(this.sessions_dbDataSet.os);

        }


    }
}
