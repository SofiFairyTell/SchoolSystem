using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Пользователь : Form
    {
        Thread th;
        Thread th1;
        Thread th2;
        public Пользователь()
        {
            InitializeComponent();

        }

        public void open(object obj)
        {
            Application.Run(new LogPass());
        }
        public void open1(object obj)
        {
            Application.Run(new Ученик());
        }
        public void open2(object obj)
        {
            Application.Run(new LogPass2());
        }
        private void button1_Click(object sender, EventArgs e) //Вход в систему ученик
        {
            this.Close();
            th = new Thread(open1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e) //Вход в систему админ
        {
            this.Close();
            th2 = new Thread(open);
            th2.SetApartmentState(ApartmentState.STA);
            th2.Start();
        }

        private void Учитель_Click(object sender, EventArgs e)//Вход в систему учитель
        {
            this.Close();
            th2 = new Thread(open2);
            th2.SetApartmentState(ApartmentState.STA);
            th2.Start();
        }
    }
}
