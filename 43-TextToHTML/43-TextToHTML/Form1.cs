using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _43_TextToHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fontsToolStripMenuItem_Click(object sender, EventArgs e)//Выбор шрифта
        {
            FontDialog font = new FontDialog();//Задаем переменную font относящуюся к диалоговому окну FontDialog(диалоговое окно для задания шрфита)
            if(font.ShowDialog() == DialogResult.OK)//если нажата кнопка ОК
            {
                rich.SelectionFont = font.Font;//выбранные настройки шрифта приравниваются к выделенному тексту
            }
        }

        private void convertToHtmlToolStripMenuItem_Click(object sender, EventArgs e)//Перенос в Html-код
        {
            Form frm = new Form();//Задаем переменную формы,frm-это открывающаяся форма при нажатии на кнопку "Перенести в Html-код"
            frm.Text = "html";//Текст выводится сверху слева в титле формы,даем имя форме
            frm.Width = 300;//Ширина
            frm.Height = 400;//Высота
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;//Фиксация Окна
            frm.StartPosition = FormStartPosition.CenterScreen;//Начальная позиция в центре экрана
            frm.BackColor = Color.White;//Фоновый цвет белый

            RichTextBox rtb = new RichTextBox();
            rtb.Text = new Main1().BuildPartA(rich);//Перевести текст в html
            rtb.Dock = DockStyle.Fill;

            frm.Controls.Add(rtb);
            frm.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)//Фоновый цвет текса
        {
            ColorDialog cor = new ColorDialog();
            if (cor.ShowDialog() == DialogResult.OK)
            {
                rich.SelectionBackColor = cor.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)//Цвет текста
        {
            ColorDialog cor = new ColorDialog();
            if (cor.ShowDialog() == DialogResult.OK)
            {
                rich.SelectionColor = cor.Color;
            }
        }

        private void перенестиВMarkdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form();//Задаем переменную формы,frm-это открывающаяся форма при нажатии на кнопку "Перенести в Html-код"
            frm.Text = "Markdown";//Текст выводится сверху слева в титле формы,даем имя форме
            frm.Width = 300;//Ширина
            frm.Height = 400;//Высота
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;//Фиксация Окна
            frm.StartPosition = FormStartPosition.CenterScreen;//Начальная позиция в центре экрана
            frm.BackColor = Color.White;//Фоновый цвет белый

            RichTextBox rtb = new RichTextBox();
            rtb.Text = new Main1().BuildPartC(rich);//Перевести текст в html
            rtb.Dock = DockStyle.Fill;

            frm.Controls.Add(rtb);
            frm.Show();
        }
    }
}
