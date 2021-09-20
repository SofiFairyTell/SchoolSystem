using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Входвсистему : Form
    {
        Thread th;
        public Входвсистему()
        {
            InitializeComponent();
            
            
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Входвсистему_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) //вход ученика
        {



        }

        private void button3_Click(object sender, EventArgs e) //вход администратора
        {
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e) //вход учителя
        {

        }
        public void open(object obj)
        {
            Application.Run(new Пользователь());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    
}
