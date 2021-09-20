using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Администратор : Form
    {
        // вернуть позже
        // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
        SqlConnection sqlConnection;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Database1.mdf;Integrated Security=True";
        public Администратор()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) //отображение информации которая имеется в базе данных
        {
            sqlConnection = new SqlConnection(connectionString); //ученики
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Ученик]", sqlConnection);
            try
            {
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    listView2.Items.Add(Convert.ToString(SqlReader["Id_Ученик"]) + "          " + Convert.ToString(SqlReader["Фамилия"]) + "          " + Convert.ToString(SqlReader["Имя"]) + "          " + Convert.ToString(SqlReader["Отчество"]) + "          " + Convert.ToString(SqlReader["Класс"]));
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

            sqlConnection = new SqlConnection(connectionString); //питание
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader5 = null;
            SqlCommand command5 = new SqlCommand("SELECT Ученик.Id_Ученик, Ученик.Фамилия, Ученик.Имя, Ученик.Отчество, Ученик.Класс, Питание.Id_Ученик, Питание.Номер, Питание.Сумма FROM Ученик, Питание WHERE Ученик.Id_Ученик = Питание.Id_Ученик", sqlConnection);
            try
            {
                SqlReader5 = await command5.ExecuteReaderAsync();
                while (await SqlReader5.ReadAsync())
                {
                    listView1.Items.Add(Convert.ToString(SqlReader5["Id_Ученик"]) + "          " + Convert.ToString(SqlReader5["Фамилия"]) + "          " + Convert.ToString(SqlReader5["Имя"]) + "          " + Convert.ToString(SqlReader5["Отчество"]) + "          " + Convert.ToString(SqlReader5["Класс"]) + "          " + Convert.ToString(SqlReader5["Номер"]) + "          " + Convert.ToString(SqlReader5["Сумма"]));
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

            sqlConnection = new SqlConnection(connectionString); //учителя
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader1 = null;
            SqlCommand command1 = new SqlCommand("SELECT * FROM [Учитель]", sqlConnection);
            try
            {
                SqlReader1 = await command1.ExecuteReaderAsync();
                while (await SqlReader1.ReadAsync())
                {
                    listView3.Items.Add(Convert.ToString(SqlReader1["Id_Учитель"]) + "          " + Convert.ToString(SqlReader1["Фамилия"]) + "          " + Convert.ToString(SqlReader1["Имя"]) + "          " + Convert.ToString(SqlReader1["Отчество"]) + "          " + Convert.ToString(SqlReader1["Предмет"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader1 != null)
                    SqlReader1.Close();
            }

            sqlConnection = new SqlConnection(connectionString); // составление расписания
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader2 = null;
            SqlCommand command2 = new SqlCommand("SELECT * FROM [Составление_расписания]", sqlConnection);
            try
            {
                SqlReader2 = await command2.ExecuteReaderAsync();
                while (await SqlReader2.ReadAsync())
                {
                    listView5.Items.Add((SqlReader2["Id"]) + "          " + Convert.ToString(SqlReader2["Класс"]) + "          " + Convert.ToString(SqlReader2["День_недели"]) + "          " + Convert.ToString(SqlReader2["Время_урока"]) + "          " + Convert.ToString(SqlReader2["Предмет"]) + "          " + Convert.ToString(SqlReader2["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader2["Номер_кабинета"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader2 != null)
                    SqlReader2.Close();
            }

            sqlConnection = new SqlConnection(connectionString); //расписание
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader3 = null;
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Составление_расписания]", sqlConnection);
            try
            {
                SqlReader3 = await command3.ExecuteReaderAsync();
                while (await SqlReader3.ReadAsync())
                {
                    listView4.Items.Add((SqlReader3["Id"]) + "          " + Convert.ToString(SqlReader3["Класс"]) + "          " + Convert.ToString(SqlReader3["День_недели"]) + "          " + Convert.ToString(SqlReader3["Время_урока"]) + "          " + Convert.ToString(SqlReader3["Предмет"]) + "          " + Convert.ToString(SqlReader3["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader3["Номер_кабинета"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader3 != null)
                    SqlReader3.Close();
            }
        }

        private async void Button8_Click(object sender, EventArgs e) //сортировка для преподавателей
        {
            listView3.Items.Clear();
            if (!string.IsNullOrEmpty(comboBox7.Text) && !string.IsNullOrWhiteSpace(comboBox7.Text)) 
            {
                SqlDataReader SqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Учитель] WHERE [Предмет] = @Предмет", sqlConnection);
                command.Parameters.AddWithValue("Предмет", comboBox7.Text);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        listView3.Items.Add(Convert.ToString(SqlReader["Id_Учитель"]) + "          " + Convert.ToString(SqlReader["Фамилия"]) + "          " + Convert.ToString(SqlReader["Имя"]) + "          " + Convert.ToString(SqlReader["Отчество"]) + "          " + Convert.ToString(SqlReader["Предмет"]));
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
                MessageBox.Show("Поле 'Предмет' должно быть заполнено!");
            }
        }


        /**/

        private async void БазаДанныхУчениковToolStripMenuItem1_Click(object sender, EventArgs e) // обновление базы данных учеников
        {
            listView2.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True"; 

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Ученик]", sqlConnection);
            try
            {
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    listView2.Items.Add(Convert.ToString(SqlReader["Id_Ученик"]) + "          " + Convert.ToString(SqlReader["Фамилия"]) + "          " + Convert.ToString(SqlReader["Имя"]) + "          " + Convert.ToString(SqlReader["Отчество"]) + "          " + Convert.ToString(SqlReader["Класс"]));
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

        private async void БазаДанныхПреподавателейToolStripMenuItem_Click(object sender, EventArgs e) //обновление базы данных преподавателей
        {
            listView3.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Учитель]", sqlConnection);
            try
            {
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    listView3.Items.Add(Convert.ToString(SqlReader["Id_Учитель"]) + "          " + Convert.ToString(SqlReader["Фамилия"]) + "          " + Convert.ToString(SqlReader["Имя"]) + "          " + Convert.ToString(SqlReader["Отчество"]) + "          " + Convert.ToString(SqlReader["Предмет"]));
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

        private async void базуПриСоставленииРасписанияToolStripMenuItem_Click(object sender, EventArgs e) //обновление базы данных с составлением расписания
        {
            listView5.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Составление_расписания]", sqlConnection);
            try
            {
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    listView5.Items.Add(Convert.ToString(SqlReader["Id"]) + "          " + Convert.ToString(SqlReader["Класс"]) + "          " + Convert.ToString(SqlReader["День_недели"]) + "          " + Convert.ToString(SqlReader["Время_урока"]) + "          " + Convert.ToString(SqlReader["Предмет"]) + "          " + Convert.ToString(SqlReader["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader["Номер_кабинета"]));
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

       
        private async void расписаниеToolStripMenuItem_Click(object sender, EventArgs e) //обновление базы данных с расписанием
        {
            listView4.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Составление_расписания]", sqlConnection);
            try
            {
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    listView4.Items.Add(Convert.ToString(SqlReader["Id"]) + "          " + Convert.ToString(SqlReader["Класс"]) + "          " + Convert.ToString(SqlReader["День_недели"]) + "          " + Convert.ToString(SqlReader["Время_урока"]) + "          " + Convert.ToString(SqlReader["Предмет"]) + "          " + Convert.ToString(SqlReader["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader["Номер_кабинета"]));
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

        private async void Button3_Click(object sender, EventArgs e) //добавление ученика
        {
            if (!string.IsNullOrEmpty(textBox9.Text) && !string.IsNullOrWhiteSpace(textBox9.Text) &&
                !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrWhiteSpace(textBox5.Text) &&
                !string.IsNullOrEmpty(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox4.Text) &&
                !string.IsNullOrEmpty(comboBox4.Text) && !string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Ученик] (Фамилия, Имя, Отчество, Класс) VALUES(@Фамилия, @Имя, @Отчество, @Класс)", sqlConnection);
                command.Parameters.AddWithValue("Фамилия", textBox9.Text);
                command.Parameters.AddWithValue("Имя", textBox5.Text);
                command.Parameters.AddWithValue("Отчество", textBox4.Text);
                command.Parameters.AddWithValue("Класс", comboBox4.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Ученик добавлен");
            }
            else
            {
                MessageBox.Show(" Поля 'Фамилия', 'Имя', 'Отчество' и 'Класс' должны быть заполнены!");
            }
        }

        private async void Button9_Click(object sender, EventArgs e) //добавление учителя
        {
            if (!string.IsNullOrEmpty(textBox20.Text) && !string.IsNullOrWhiteSpace(textBox20.Text) &&
                !string.IsNullOrEmpty(textBox19.Text) && !string.IsNullOrWhiteSpace(textBox19.Text) &&
                !string.IsNullOrEmpty(textBox18.Text) && !string.IsNullOrWhiteSpace(textBox18.Text) &&
                !string.IsNullOrEmpty(comboBox6.Text) && !string.IsNullOrWhiteSpace(comboBox6.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Учитель] (Фамилия, Имя, Отчество, Предмет) VALUES(@Фамилия, @Имя, @Отчество, @Предмет)", sqlConnection);
                command.Parameters.AddWithValue("Фамилия", textBox20.Text);
                command.Parameters.AddWithValue("Имя", textBox19.Text);
                command.Parameters.AddWithValue("Отчество", textBox18.Text);
                command.Parameters.AddWithValue("Предмет", comboBox6.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Учитель добавлен");
            }
            else
            {
                MessageBox.Show("Поля 'Фамилия', 'Имя', 'Отчество' и 'Предмет' должны быть заполнены!");
            }
        }

        private async void button10_Click(object sender, EventArgs e) //добавление расписания 
        {
            if (!string.IsNullOrEmpty(comboBox8.Text) && !string.IsNullOrWhiteSpace(comboBox8.Text) &&
                !string.IsNullOrEmpty(comboBox10.Text) && !string.IsNullOrWhiteSpace(comboBox10.Text) &&
                !string.IsNullOrEmpty(comboBox9.Text) && !string.IsNullOrWhiteSpace(comboBox9.Text) &&
                !string.IsNullOrEmpty(comboBox11.Text) && !string.IsNullOrWhiteSpace(comboBox11.Text) &&
                !string.IsNullOrEmpty(comboBox12.Text) && !string.IsNullOrWhiteSpace(comboBox12.Text) &&
                !string.IsNullOrEmpty(comboBox13.Text) && !string.IsNullOrWhiteSpace(comboBox13.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Составление_расписания] (Класс, День_недели, Время_урока, Предмет, ФИО_учителя, Номер_кабинета) VALUES(@Класс, @День_недели, @Время_урока, @Предмет, @ФИО_учителя,  @Номер_кабинета)", sqlConnection);
                command.Parameters.AddWithValue("Класс", comboBox8.Text);
                command.Parameters.AddWithValue("День_недели", comboBox10.Text);
                command.Parameters.AddWithValue("Время_урока", comboBox9.Text);
                command.Parameters.AddWithValue("Предмет", comboBox11.Text);
                command.Parameters.AddWithValue("ФИО_учителя", comboBox12.Text);
                command.Parameters.AddWithValue("Номер_кабинета", comboBox13.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Добавлено в расписание");
            }
            else
            {
                MessageBox.Show(" Поля 'Класс','День недели', 'Время урока','ФИО учителя', 'Предмет'и 'Кабинет' должны быть заполнены!");
            }
        }

        private async void Button5_Click(object sender, EventArgs e) // редактирование данных учеников
        {
            if (!string.IsNullOrEmpty(textBox11.Text) && !string.IsNullOrWhiteSpace(textBox11.Text) &&
                !string.IsNullOrEmpty(textBox14.Text) && !string.IsNullOrWhiteSpace(textBox14.Text) &&
                !string.IsNullOrEmpty(textBox13.Text) && !string.IsNullOrWhiteSpace(textBox13.Text) &&
                !string.IsNullOrEmpty(textBox12.Text) && !string.IsNullOrWhiteSpace(textBox12.Text) &&
                !string.IsNullOrEmpty(comboBox5.Text) && !string.IsNullOrWhiteSpace(comboBox5.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Ученик] SET [Фамилия] = @Фамилия, [Имя] = @Имя, [Отчество] = @Отчество, [Класс] = @Класс WHERE [ID_Ученик] = @ID_Ученик", sqlConnection);
                command.Parameters.AddWithValue("ID_Ученик", textBox11.Text);
                command.Parameters.AddWithValue("Фамилия", textBox14.Text);
                command.Parameters.AddWithValue("Имя", textBox13.Text);
                command.Parameters.AddWithValue("Отчество", textBox12.Text);
                command.Parameters.AddWithValue("Класс", comboBox5.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Информация об ученике изменена");
            }
            else
            {
                MessageBox.Show("Поля 'Фамилия', 'Имя', 'Отчество' и 'Класс' должны быть заполнены!");
            }
        }

        private async void Button7_Click(object sender, EventArgs e) //редактирование данных учителей
        {
            if (!string.IsNullOrEmpty(textBox7.Text) && !string.IsNullOrWhiteSpace(textBox7.Text) &&
                !string.IsNullOrEmpty(textBox17.Text) && !string.IsNullOrWhiteSpace(textBox17.Text) &&
                !string.IsNullOrEmpty(textBox16.Text) && !string.IsNullOrWhiteSpace(textBox16.Text) &&
                !string.IsNullOrEmpty(textBox8.Text) && !string.IsNullOrWhiteSpace(textBox8.Text) &&
                !string.IsNullOrEmpty(comboBox1.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [Учитель] SET [Фамилия] = @Фамилия, [Имя] = @Имя, [Отчество] = @Отчество, [Предмет] = @Предмет WHERE [ID_Учитель] = @ID_Учитель", sqlConnection);
                command.Parameters.AddWithValue("ID_Учитель", textBox7.Text);
                command.Parameters.AddWithValue("Фамилия", textBox17.Text);
                command.Parameters.AddWithValue("Имя", textBox16.Text);
                command.Parameters.AddWithValue("Отчество", textBox8.Text);
                command.Parameters.AddWithValue("Предмет", comboBox1.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Информация о преподавателе изменена");

            }
            else
            {
                MessageBox.Show("Поля 'Фамилия', 'Имя', 'Отчество' и 'Класс' должны быть заполнены!");
            }
        }

        private async void Button6_Click(object sender, EventArgs e) // удаление данных ученика
        {
            if (!string.IsNullOrEmpty(textBox15.Text) && !string.IsNullOrWhiteSpace(textBox15.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM[Ученик] WHERE [ID_Ученик] = @ID_Ученик", sqlConnection);
                command.Parameters.AddWithValue("ID_Ученик", textBox15.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Ученик удален");

            }
            else
            {
                MessageBox.Show("Поле 'ID' должны быть заполнены!");
            }
        }

        private async void Button2_Click(object sender, EventArgs e) // удаление данных учителей
        {
            if (!string.IsNullOrEmpty(textBox6.Text) && !string.IsNullOrWhiteSpace(textBox6.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM[Учитель] WHERE [ID_Учитель] = @ID_Учитель", sqlConnection);
                command.Parameters.AddWithValue("ID_Учитель", textBox6.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Учитель удален");

            }
            else
            {
                MessageBox.Show("Поле 'ID' должны быть заполнены!");
            }
        }

        private async void button11_Click(object sender, EventArgs e) //сортировка по классам при составлении расписания
        {

                listView5.Items.Clear();
                if (!string.IsNullOrEmpty(comboBox14.Text) && !string.IsNullOrWhiteSpace(comboBox14.Text)) 
                {
                    SqlDataReader SqlReader = null;
                    SqlCommand command = new SqlCommand("SELECT * FROM [Составление_расписания] WHERE [Класс] = @Класс", sqlConnection);
                    command.Parameters.AddWithValue("Класс", comboBox14.Text);
                    try
                    {
                        SqlReader = await command.ExecuteReaderAsync();
                        while (await SqlReader.ReadAsync())
                        {
                        listView5.Items.Add(Convert.ToString(SqlReader["Id"]) + "          " + Convert.ToString(SqlReader["Класс"]) + "          " + Convert.ToString(SqlReader["День_недели"]) + "          " + Convert.ToString(SqlReader["Время_урока"]) + "          " + Convert.ToString(SqlReader["Предмет"]) + "          " + Convert.ToString(SqlReader["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader["Номер_кабинета"]));
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
                    MessageBox.Show("Поле 'Класс' должно быть заполнено!");
                }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();
        }

        private async void button1_Click(object sender, EventArgs e) //расписание
        {
            listView4.Items.Clear();
            if (!string.IsNullOrEmpty(comboBox2.Text) && !string.IsNullOrWhiteSpace(comboBox2.Text))
            {
                SqlDataReader SqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Составление_расписания] WHERE [Класс] = @Класс", sqlConnection);
                command.Parameters.AddWithValue("Класс", comboBox2.Text);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        listView4.Items.Add((SqlReader["Id"]) + "          " + Convert.ToString(SqlReader["Класс"]) + "          " + Convert.ToString(SqlReader["День_недели"]) + "          " + Convert.ToString(SqlReader["Время_урока"]) + "          " + Convert.ToString(SqlReader["Предмет"]) + "          " + Convert.ToString(SqlReader["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader["Номер_кабинета"]));
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
                MessageBox.Show("Поле 'Класс' должно быть заполнено!");
            }
        }

        private async void button4_Click_1(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            if (!string.IsNullOrEmpty(comboBox3.Text) && !string.IsNullOrWhiteSpace(comboBox3.Text))
            {
                SqlDataReader SqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Ученик] WHERE [Класс] = @Класс", sqlConnection);
                command.Parameters.AddWithValue("Класс", comboBox3.Text);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        listView2.Items.Add(Convert.ToString(SqlReader["Id_Ученик"]) + "          " + Convert.ToString(SqlReader["Фамилия"]) + "          " + Convert.ToString(SqlReader["Имя"]) + "          " + Convert.ToString(SqlReader["Отчество"]) + "          " + Convert.ToString(SqlReader["Класс"]));

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
                MessageBox.Show("Поле 'Предмет' должно быть заполнено!");
            }
        }

        private async void button12_Click(object sender, EventArgs e)// отмена сортировки учеников
        {
            listView2.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString); //ученики
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [Ученик]", sqlConnection);
            try
            {
                SqlReader = await command.ExecuteReaderAsync();
                while (await SqlReader.ReadAsync())
                {
                    listView2.Items.Add(Convert.ToString(SqlReader["Id_Ученик"]) + "          " + Convert.ToString(SqlReader["Фамилия"]) + "          " + Convert.ToString(SqlReader["Имя"]) + "          " + Convert.ToString(SqlReader["Отчество"]) + "          " + Convert.ToString(SqlReader["Класс"]));
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

        private async void button13_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString); //учителя
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader1 = null;
            SqlCommand command1 = new SqlCommand("SELECT * FROM [Учитель]", sqlConnection);
            try
            {
                SqlReader1 = await command1.ExecuteReaderAsync();
                while (await SqlReader1.ReadAsync())
                {
                    listView3.Items.Add(Convert.ToString(SqlReader1["Id_Учитель"]) + "          " + Convert.ToString(SqlReader1["Фамилия"]) + "          " + Convert.ToString(SqlReader1["Имя"]) + "          " + Convert.ToString(SqlReader1["Отчество"]) + "          " + Convert.ToString(SqlReader1["Предмет"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader1 != null)
                    SqlReader1.Close();
            }
        }

        private async void button14_Click(object sender, EventArgs e)
        {
            listView4.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString); //расписание
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader3 = null;
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Составление_расписания]", sqlConnection);
            try
            {
                SqlReader3 = await command3.ExecuteReaderAsync();
                while (await SqlReader3.ReadAsync())
                {
                    listView4.Items.Add((SqlReader3["Id"]) + "          " + Convert.ToString(SqlReader3["Класс"]) + "          " + Convert.ToString(SqlReader3["День_недели"]) + "          " + Convert.ToString(SqlReader3["Время_урока"]) + "          " + Convert.ToString(SqlReader3["Предмет"]) + "          " + Convert.ToString(SqlReader3["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader3["Номер_кабинета"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader3 != null)
                    SqlReader3.Close();
            }

        }
        private async void button15_Click(object sender, EventArgs e)
        {
            listView5.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString); //расписание
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader3 = null;
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Составление_расписания]", sqlConnection);
            try
            {
                SqlReader3 = await command3.ExecuteReaderAsync();
                while (await SqlReader3.ReadAsync())
                {
                    listView5.Items.Add((SqlReader3["Id"]) + "          " + Convert.ToString(SqlReader3["Класс"]) + "          " + Convert.ToString(SqlReader3["День_недели"]) + "          " + Convert.ToString(SqlReader3["Время_урока"]) + "          " + Convert.ToString(SqlReader3["Предмет"]) + "          " + Convert.ToString(SqlReader3["ФИО_учителя"]) + "          " + Convert.ToString(SqlReader3["Номер_кабинета"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReader3 != null)
                    SqlReader3.Close();
            }
        }

        private async void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox1.Text) &&
    !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
    !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox3.Text))
            {
                SqlCommand command = new SqlCommand("INSERT INTO [Питание] (Id_Ученик, Номер, Сумма) VALUES(@Id_Ученик, @Номер, @Сумма)", sqlConnection);
                command.Parameters.AddWithValue("Id_Ученик", textBox1.Text);
                command.Parameters.AddWithValue("Номер", textBox2.Text);
                command.Parameters.AddWithValue("Сумма", textBox3.Text);
                await command.ExecuteNonQueryAsync();
                MessageBox.Show("Оплата добавлена");
            }
            else
            {
                MessageBox.Show("Поля 'Id_Ученик', 'Номер' и 'Сумма' должны быть заполнены!");
            }
        }

        private async void питаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilenameC:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";

            sqlConnection = new SqlConnection(connectionString);
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader5 = null;
            SqlCommand command5 = new SqlCommand("SELECT Ученик.Id_Ученик, Ученик.Фамилия, Ученик.Имя, Ученик.Отчество, Ученик.Класс, Питание.Id_Ученик, Питание.Номер, Питание.Сумма FROM Ученик, Питание WHERE Ученик.Id_Ученик = Питание.Id_Ученик", sqlConnection);
            try
            {
                SqlReader5 = await command5.ExecuteReaderAsync();
                while (await SqlReader5.ReadAsync())
                {
                    listView1.Items.Add(Convert.ToString(Convert.ToString(SqlReader5["Id_Ученик"]) + "          " + Convert.ToString(SqlReader5["Фамилия"]) + "          " + Convert.ToString(SqlReader5["Имя"]) + "          " + Convert.ToString(SqlReader5["Отчество"]) + "          " + Convert.ToString(SqlReader5["Класс"]) + "          " + Convert.ToString(SqlReader5["Номер"]) + "          " + Convert.ToString(SqlReader5["Сумма"])));
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

        private async void button16_Click(object sender, EventArgs e)//отмена сортировки питание
        {
            listView1.Items.Clear();
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString); //питание
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader5 = null;
            SqlCommand command5 = new SqlCommand("SELECT Ученик.Id_Ученик, Ученик.Фамилия, Ученик.Имя, Ученик.Отчество, Ученик.Класс, Питание.Id_Ученик, Питание.Номер, Питание.Сумма FROM Ученик, Питание WHERE Ученик.Id_Ученик = Питание.Id_Ученик", sqlConnection);
            try
            {
                SqlReader5 = await command5.ExecuteReaderAsync();
                while (await SqlReader5.ReadAsync())
                {
                    listView1.Items.Add(Convert.ToString(Convert.ToString(SqlReader5["Id_Ученик"]) + "          " + Convert.ToString(SqlReader5["Фамилия"]) + "          " + Convert.ToString(SqlReader5["Имя"]) + "          " + Convert.ToString(SqlReader5["Отчество"]) + "          " + Convert.ToString(SqlReader5["Класс"]) + "          " + Convert.ToString(SqlReader5["Номер"]) + "          " + Convert.ToString(SqlReader5["Сумма"])));
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

        private async void button17_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (!string.IsNullOrEmpty(textBox10.Text) && !string.IsNullOrWhiteSpace(textBox10.Text))
            {
                SqlDataReader SqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Питание] WHERE [Id_Ученик] = @Id_Ученик", sqlConnection);
                command.Parameters.AddWithValue("Id_Ученик", textBox10.Text);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        listView1.Items.Add(Convert.ToString(SqlReader["Id"]) + "          " + Convert.ToString(SqlReader["Номер"]) + "          " + Convert.ToString(SqlReader["Сумма"]) + "          " + Convert.ToString(SqlReader["Id_Ученик"]));

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
                MessageBox.Show("Поле 'Предмет' должно быть заполнено!");
            }
        }

        private async void button19_Click_1(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString); //питание
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader5 = null;
            SqlCommand command5 = new SqlCommand("SELECT SUM (Питание.Сумма) FROM Питание", sqlConnection);
            try
            {
                SqlReader5 = await command5.ExecuteReaderAsync();
                while (await SqlReader5.ReadAsync())
                {
                    MessageBox.Show("Сумма: ");
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
