using System.Data;
using System.Data.SQLite;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private static SQLiteConnection DB; // Объявляем переменную DB
        private bool isDarkMode = false; // Переменная для управления темной темой

        public Form1()
        {
            InitializeComponent();
            string connection = "Data Source=asd.db;Version=3;"; // Убедитесь, что строка подключения правильная
            DB = new SQLiteConnection(connection); // Инициализируем соединение
            CreateTable(); // Создаём таблицу при инициализации
            ApplyTheme(); // Применяем тему при инициализации
        }

        private void ApplyTheme()
        {
            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                this.ForeColor = Color.White;

                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = Color.FromArgb(50, 50, 50);
                        control.ForeColor = Color.White;
                    }
                    else
                    {
                        control.BackColor = Color.FromArgb(30, 30, 30);
                        control.ForeColor = Color.White;
                    }
                }
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;

                foreach (Control control in this.Controls)
                {
                    if (control is Button)
                    {
                        control.BackColor = Color.LightGray;
                        control.ForeColor = Color.Black;
                    }
                    else
                    {
                        control.BackColor = Color.White;
                        control.ForeColor = Color.Black;
                    }
                }
            }
        }


        private void CreateTable()
        {
            OpenConnection();
            using (var cmd = new SQLiteCommand("CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Login TEXT NOT NULL, Password TEXT NOT NULL)", DB))
            {
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка создания таблицы: {ex.Message}");
                }
            }
            CloseConnection();
        }

        private void OpenConnection()
        {
            try
            {
                if (DB.State == ConnectionState.Closed)
                {
                    DB.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}");
            }
        }

        private void CloseConnection()
        {
            try
            {
                if (DB.State == ConnectionState.Open)
                {
                    DB.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка закрытия подключения: {ex.Message}");
            }
        }

        private void vxod_Click(object sender, EventArgs e)
        {
            string Login = LOGBox1.Text;
            string Password = REGBox2.Text;

            if (Login.Length < 3 || Login.Length > 20)
            {
                MessageBox.Show("Длина логина должна составлять от 3 до 20 символов.");
                return;
            }

            if (Password.Length < 3 || Password.Length > 20)
            {

                MessageBox.Show("Длина пароля должна составлять от 3 до 20 символов.");
                return;
            }

            OpenConnection();

            using (var cmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Login = @Log AND Password = @Pass", DB))
            {

                cmd.Parameters.AddWithValue("@Log", Login);
                cmd.Parameters.AddWithValue("@Pass", Password);

                try
                {

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Вход успешен!");
                        this.Hide();
                        Form2 form1 = new Form2();
                        form1.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при выполнении запроса: {ex.Message}");
                }
            }

            CloseConnection();
        }

        private void reg_Click_1(object sender, EventArgs e)
        {
            string Login = LOGBox1.Text;
            string Password = REGBox2.Text;

            if (Login.Length < 3 || Login.Length > 20)
            {
                MessageBox.Show("Длина логина должна составлять от 3 до 20 символов.");
                return;
            }

            if (Password.Length < 3 || Password.Length > 20)
            {
                MessageBox.Show("Длина пароля должна составлять от 3 до 20 символов.");
                return;
            }

            OpenConnection();

            using (var cmd = new SQLiteCommand("INSERT INTO Users (Login, Password) VALUES (@Log, @Pass)", DB))
            {
                cmd.Parameters.AddWithValue("@Log", Login);
                cmd.Parameters.AddWithValue("@Pass", Password);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Регистрация не удалась: {ex.Message}");
                }
            }

            CloseConnection();
        }

        private void ShowUsers()
        {
            OpenConnection();
            using (var cmd = new SQLiteCommand("SELECT * FROM Users", DB))
            {
                try
                {
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        string usersList = "Список пользователей:\n";
                        while (reader.Read())
                        {
                            usersList += $"ID: {reader["Id"]}, Login: {reader["Login"]}\n";
                        }
                        MessageBox.Show(usersList);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при получении пользователей: {ex.Message}");
                }
            }
            CloseConnection();
        }

        private void ChangePassword(int userId, string newPassword)
        {
            OpenConnection();
            using (var cmd = new SQLiteCommand("UPDATE Users SET Password = @Pass WHERE Id = @Id", DB))
            {
                cmd.Parameters.AddWithValue("@Pass", newPassword);
                cmd.Parameters.AddWithValue("@Id", userId);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Пароль успешно изменён.");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при изменении пароля: {ex.Message}");
                }
            }
            CloseConnection();
        }

        private void DeleteUser(string login)
        {
            OpenConnection();
            using (var cmd = new SQLiteCommand("DELETE FROM Users WHERE Login = @Log", DB))
            {
                cmd.Parameters.AddWithValue("@Log", login);

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Пользователь успешно удалён.");
                    }
                    else
                    {
                        MessageBox.Show("Пользователь не найден.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении пользователя: {ex.Message}");
                }
            }
            CloseConnection();
        }

        private void smena_Click(object sender, EventArgs e)
        {
            int userId = 1;
            string newPassword = "newPassword123";
            ChangePassword(userId, newPassword);
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            string loginToDelete = "userLogin";
            DeleteUser(loginToDelete);
        }

        private void Otobr_Click_1(object sender, EventArgs e)
        {
            ShowUsers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}







