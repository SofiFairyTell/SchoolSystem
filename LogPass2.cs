using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogPass2 : Form
    {
        Thread th;
        public string Login, Password;
        int start = 0;
        int k = 2;
        int p = 3;
        public LogPass2()
        {
            InitializeComponent();
        }

        public void open(object obj)
        {
            Application.Run(new Учитель(Login));
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            Login = textBox1.Text;
            Password = textBox2.Text;

            if (k != 0)
            {
                if (Login == "2" && Password == "123")
                {
                    this.Close();
                    th = new Thread(open);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
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
    }
}
