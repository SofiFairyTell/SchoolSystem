using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Ученик : Form
    {      
        // вернуть позже
        // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
        SqlConnection sqlConnection;

        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Database1.mdf;Integrated Security=True";
        int k = 2;
        int p = 3;

        public Ученик()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // вернуть позже
            // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
           // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Database1.mdf;Integrated Security=True";

            
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();

            string Login, Password;
            Login = textBox1.Text;
            Password = textBox2.Text;
            if (k != 0)
            {
                if (Login == "1" && Password == "123" || Login == "2" && Password == "123")
                {
                    Class1.Id = textBox1.Text;
                    SqlDataReader SqlReader = null;
                    SqlCommand command = new SqlCommand("SELECT * FROM [Ученик] WHERE [Id_Ученик] = @Id", sqlConnection);
                    command.Parameters.AddWithValue("Id", textBox1.Text);
                    try
                    {
                        SqlReader = await command.ExecuteReaderAsync();
                        while (await SqlReader.ReadAsync())
                        {
                            listBox1.Items.Clear();
                            listBox3.Items.Clear();
                            listBox4.Items.Clear();
                            listBox5.Items.Clear();
                            Class1.Klass = Convert.ToString(SqlReader["Класс"]);
                            listBox1.Items.Add(Convert.ToString(SqlReader["Фамилия"]));
                            listBox3.Items.Add(Convert.ToString(SqlReader["Имя"]));
                            listBox4.Items.Add(Convert.ToString(SqlReader["Отчество"]));
                            listBox5.Items.Add(Convert.ToString(SqlReader["Класс"]));
                            listBox6.Items.Add(Convert.ToString(SqlReader["Номер_телефона"]));
                            listBox7.Items.Add(Convert.ToString(SqlReader["Место_жительства"]));
                            listBox8.Items.Add(Convert.ToString(SqlReader["ФИО_мамы"]));
                            listBox9.Items.Add(Convert.ToString(SqlReader["ФИО_папы"]));
                            listBox10.Items.Add(Convert.ToString(SqlReader["Рейтинг"]));
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (SqlReader != null)
                            SqlReader.Close();
                    }
                }
                else
                {
                    k = k - 1;
                    p = p - 1;
                    MessageBox.Show("Указанные данные не совпадают.\n Количество попыток :" + p);
                }
            }
            else
            {
                MessageBox.Show("Указанные данные не совпадают.\n Попыток больше нет попробуйте в другой раз");
                Application.Exit();
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // вернуть позже
            // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            listBox2.Items.Clear();
            if (!string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text) &&
                !string.IsNullOrEmpty(comboBox2.Text) && !string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                SqlDataReader SqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Составление_расписания] WHERE [Класс] = @Класс AND [День_недели] = @День_недели", sqlConnection);
                command.Parameters.AddWithValue("Класс", comboBox1.Text);
                command.Parameters.AddWithValue("День_недели", comboBox2.Text);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        listBox2.Items.Add(Convert.ToString(SqlReader["Время_урока"]) + " " + Convert.ToString(SqlReader["Предмет"]) + " " + Convert.ToString(SqlReader["ФИО_учителя"]) + " " + Convert.ToString(SqlReader["Номер_кабинета"]));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (SqlReader != null)
                        SqlReader.Close();
                }

            }
            else
            {
                MessageBox.Show("Поле 'Класс' и 'День недели' должно быть заполнено!");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private async void button17_Click(object sender, EventArgs e)
        {
            //listBox11.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader5 = null;
            SqlCommand command5 = new SqlCommand("SELECT * FROM [Питание] WHERE [Id_Ученик] = @Id", sqlConnection);
            command5.Parameters.AddWithValue("Id", textBox10.Text);
            try
            {
                SqlReader5 = await command5.ExecuteReaderAsync();
                while (await SqlReader5.ReadAsync())
                {
                    listBox11.Items.Add(Convert.ToString(SqlReader5["Номер"]) + " " + Convert.ToString(SqlReader5["Сумма"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader5 != null)
                    SqlReader5.Close();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            listBox11.Items.Clear();
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            if (!string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Питание] (Id_Ученик, Номер, Сумма) VALUES(@Id_Ученик, @Номер, @Сумма)", sqlConnection);
                command.Parameters.AddWithValue("Id_Ученик", textBox5.Text);
                command.Parameters.AddWithValue("Номер", textBox4.Text);
                command.Parameters.AddWithValue("Сумма", textBox3.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Оплата добавлена");
            }
            else
            {
                MessageBox.Show("Поля 'Id_Ученик', 'Номер' и 'Сумма' должны быть заполнены!");
            }
        }

        private async void обновлениеПитанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox11.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader5 = null;
            SqlCommand command5 = new SqlCommand("SELECT * FROM [Питание] WHERE [Id_Ученик] = @Id", sqlConnection);
            command5.Parameters.AddWithValue("Id", textBox10.Text);
            try
            {
                SqlReader5 = await command5.ExecuteReaderAsync();
                while (await SqlReader5.ReadAsync())
                {
                    listBox11.Items.Add(Convert.ToString(SqlReader5["Номер"]) + " " + Convert.ToString(SqlReader5["Сумма"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader5 != null)
                    SqlReader5.Close();
            }
        }
    }
}
