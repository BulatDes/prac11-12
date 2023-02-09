using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_11_12
{
    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.name = textBox1.Text;
            stud.rost = (int)numericUpDown1.Value;
           // stud.ves = (int)numericUpDown2.Value;
            stud.eda = (double)numericUpDown3.Value;
            MessageBox.Show(string.Format("Студент: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat()));
            stud.SetEat(stud.eda); 
            MessageBox.Show(string.Format("Студент съел {3} кг еды: {0} \nрост: {1} \nвес: {2}", stud.name, stud.rost, stud.GetEat(),stud.eda));
           


            //рассчет веса, если студент съел 5 кг

        }
    }
}
