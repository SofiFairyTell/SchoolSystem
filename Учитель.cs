using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Учитель : Form
    {
        private string login;
        public Учитель(string Login)
        {
            InitializeComponent();
            login = Login;
        }
        SqlConnection sqlConnection;
        // вернуть позже
        // string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\!БГТУ\WindowsFormsApp1\Database1.mdf;Integrated Security=True";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\projects\Database1.mdf;Integrated Security=True";
        private async void УчительForm_Load(object sender, EventArgs e) //отображение информации которая имеется в базе данных
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
                    УченикиСписок.Rows.Add(
                            Convert.ToString(SqlReader["Id_Ученик"]),
                            Convert.ToString(SqlReader["Фамилия"]),
                            Convert.ToString(SqlReader["Имя"]),
                            Convert.ToString(SqlReader["Отчество"]),
                            Convert.ToString(SqlReader["Класс"])
                        );
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

            sqlConnection = new SqlConnection(connectionString); //расписание
            await sqlConnection.OpenAsync();
            SqlDataReader SqlReader3 = null;
            SqlCommand command3 = new SqlCommand("SELECT * FROM [Составление_расписания]", sqlConnection);
            try
            {
                SqlReader3 = await command3.ExecuteReaderAsync();
                while (await SqlReader3.ReadAsync())
                {
                    РасписаниеЗанятий.Rows.Add(
                        Convert.ToString(SqlReader3["Номер_кабинета"]),
                        Convert.ToString(SqlReader3["Время_урока"]),
                        Convert.ToString(SqlReader3["Предмет"]),
                        Convert.ToString(SqlReader3["ФИО_учителя"]),
                        Convert.ToString(SqlReader3["День_недели"]),
                        Convert.ToString(SqlReader3["Класс"])
                        );
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

            SqlDataReader SqlReaderTeacher = null;
            SqlCommand commandTeacher = new SqlCommand("SELECT * FROM [Учитель] WHERE [Id_Учитель] = @Id", sqlConnection);
            commandTeacher.Parameters.AddWithValue("Id", login);
            try
            {
                SqlReaderTeacher = await commandTeacher.ExecuteReaderAsync();
                while (await SqlReaderTeacher.ReadAsync())
                {
                    полеФамилия.Text = Convert.ToString(SqlReaderTeacher["Фамилия"]);
                    полеИмя.Text = Convert.ToString(SqlReaderTeacher["Имя"]);
                    полеОтчество.Text = Convert.ToString(SqlReaderTeacher["Отчество"]);
                    полеПредмет.Text = Convert.ToString(SqlReaderTeacher["Предмет"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (SqlReaderTeacher != null)
                    SqlReaderTeacher.Close();
            }

        }

        private async void НайтиУченика_Click(object sender, EventArgs e)
        {
            УченикиСписок.Rows.Clear();
            if (!string.IsNullOrEmpty(КлассыСписок.Text) && !string.IsNullOrWhiteSpace(КлассыСписок.Text))
            {
                SqlDataReader SqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Ученик] WHERE [Класс]=@Класс ", sqlConnection);
                command.Parameters.AddWithValue("Класс", КлассыСписок.Text);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        УченикиСписок.Rows.Add(
                                Convert.ToString(SqlReader["Id_Ученик"]),
                                Convert.ToString(SqlReader["Фамилия"]),
                                Convert.ToString(SqlReader["Имя"]),
                                Convert.ToString(SqlReader["Отчество"]),
                                Convert.ToString(SqlReader["Класс"])
                        );
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

        private void инструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private async void базуРасписанияToolStripMenuItem_Click(object sender, EventArgs e) //обновление базы данных с составлением расписания
        {
            //listView5.Items.Clear();
            РасписаниеЗанятий.Rows.Clear();
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
                    РасписаниеЗанятий.Rows.Add(
                            Convert.ToString(SqlReader["Номер_кабинета"]),
                            Convert.ToString(SqlReader["Время_урока"]),
                            Convert.ToString(SqlReader["Предмет"]),
                            Convert.ToString(SqlReader["ФИО_учителя"]),
                            Convert.ToString(SqlReader["День_недели"]),
                            Convert.ToString(SqlReader["Класс"])
                            );
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
        private async void НайтиРасписание_Click(object sender, EventArgs e) //расписание
        {
            РасписаниеЗанятий.Rows.Clear();
            if (!string.IsNullOrEmpty(ВыборКласса.Text) && !string.IsNullOrWhiteSpace(ВыборКласса.Text))
            {
                SqlDataReader SqlReader = null;
                string[] m = ВыборКласса.Text.Split(',').ToArray();
                for (int i=0; i<m.Length; i++)
                {                  
                    SqlCommand command = new SqlCommand("SELECT * FROM [Составление_расписания] WHERE [Класс]=@Класс", sqlConnection);  
                    command.Parameters.AddWithValue("Класс", m[i]);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        РасписаниеЗанятий.Rows.Add(
                            Convert.ToString(SqlReader["Номер_кабинета"]),
                            Convert.ToString(SqlReader["Время_урока"]),
                            Convert.ToString(SqlReader["Предмет"]),
                            Convert.ToString(SqlReader["ФИО_учителя"]),
                            Convert.ToString(SqlReader["День_недели"]),
                            Convert.ToString(SqlReader["Класс"])
                            );
                    }
                        SqlReader.Close();
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
                }
            else
            {
                MessageBox.Show("Поле 'Класс' должно быть заполнено!");
            }
        }
        private async void СортировкаРасписание_Click(string ФИО) //сортировка по классам при составлении расписания
        {
            РасписаниеЗанятий.Rows.Clear();
                SqlDataReader SqlReader = null;
                SqlCommand command = new SqlCommand("SELECT * FROM [Составление_расписания] WHERE [ФИО_учителя] = @ФИО", sqlConnection);
                command.Parameters.AddWithValue("ФИО", ФИО);
                try
                {
                    SqlReader = await command.ExecuteReaderAsync();
                    while (await SqlReader.ReadAsync())
                    {
                        РасписаниеЗанятий.Rows.Add(
                            Convert.ToString(SqlReader["Номер_кабинета"]),
                            Convert.ToString(SqlReader["Время_урока"]),
                            Convert.ToString(SqlReader["Предмет"]),
                            Convert.ToString(SqlReader["ФИО_учителя"]),
                            Convert.ToString(SqlReader["День_недели"]),
                            Convert.ToString(SqlReader["Класс"])
                            );
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
        private async void ОтменаСортировкиРасписание_Click(object sender, EventArgs e)//ОтменаСортировки
        {
            РасписаниеЗанятий.Rows.Clear();
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
                    РасписаниеЗанятий.Rows.Add(
                        Convert.ToString(SqlReader3["Номер_кабинета"]),
                        Convert.ToString(SqlReader3["Время_урока"]),
                        Convert.ToString(SqlReader3["Предмет"]),
                        Convert.ToString(SqlReader3["ФИО_учителя"]),
                        Convert.ToString(SqlReader3["День_недели"]),
                        Convert.ToString(SqlReader3["Класс"])
                        );
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

        private void НайтиМоеРасписание_Click(object sender, EventArgs e)
        {
            УчительПанель.SelectedTab = УчительРасписание;
            СортировкаРасписание_Click(полеФамилия.Text.Trim() + ' '+ полеИмя.Text.Trim() + ' '+ полеОтчество.Text.Trim());
        }
    }
}
