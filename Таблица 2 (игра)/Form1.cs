using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Таблица_2__игра_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(
                "Показать таблицу?",
                "Сообщение",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1))
            {
                case DialogResult.Yes:
                    {
                        dataGridView1.Columns.Add("№", "Номер");
                        dataGridView1.Columns.Add("Наименование", "Наименование");
                        dataGridView1.Columns.Add("Месяц", "Месяц");
                        dataGridView1.Columns.Add("День", "День");
                        dataGridView1.Columns.Add("Магазин", "Магазин");
                        dataGridView1.Columns.Add("Продано", "Продано");
                        dataGridView1.Columns.Add("Заказчик", "Заказчик");

                        dataGridView1.Rows.Add("1", "Пион", "Январь", "21", "Левобережная, 15", "28", "Иванов");
                        dataGridView1.Rows.Add("2", "Тюльпан", "Февраль", "20", "Оболонь, 24", "12", "Петров");
                        dataGridView1.Rows.Add("3", "Орхидея", "Март", "16", "Соболева, 125", "120", "Сидоров");
                        dataGridView1.Rows.Add("4", "Ромашка", "Апрель", "13", "Левобережная, 123", "54", "Смирнова");
                        dataGridView1.Rows.Add("5", "Лилия", "Май", "08", "Левобережная, 46", "48", "Иванова");
                        dataGridView1.Rows.Add("6", "Роза", "Июнь", "19", "Оболонь, 46", "65", "Петрова");
                        dataGridView1.Rows.Add("7", "Гвоздика", "Июль", "24", "Соболева, 133", "77", "Сидорова");
                        dataGridView1.Rows.Add("8", "Астра", "Август", "05", "Левобережная, 167", "40", "Смирнов");
                        dataGridView1.Rows.Add("9", "Фикус", "Сентябрь", "10", "Соболева, 20", "12", "Шевченко");
                        dataGridView1.Rows.Add("10", "Фиалка", "Октябрь", "11", "Оболонь, 100", "6", "Васильев");

                        dataGridView1.Rows[2].Cells["Месяц"].Value = "Сентябрь";
                        dataGridView1.Rows[6].Cells[2].Value = "Декабрь";
                        break;
                    }
                case DialogResult.No: MessageBox.Show("Вы выбрали Нет"); break;
                case DialogResult.Cancel: MessageBox.Show("Вы выбрали Отмена"); break;
            }


            
        }
    }
}
