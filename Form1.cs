using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguresProject
{
    public partial class Form1 : Form
    {
        List<Figure> figureList = new List<Figure>();
        public Form1()
        {
            InitializeComponent();
            mainComboBox.Items.Add("Прямоугольник");
            mainComboBox.Items.Add("Окружность");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void createAndAddFigureToList()
        {
            string stringa = (string)mainComboBox.SelectedItem;
            if (stringa == null)
            {
                MessageBox.Show("Выберете тип фигуры!");
            }
            else
            {
                int x = Convert.ToInt32(xTextBox.Text);
                int y = Convert.ToInt32(yTextBox.Text);
                if (stringa == "Окружность")
                {
                    int radius = Convert.ToInt32(radiusTextBox.Text);
                    Circle circ = new Circle(x, y, radius);
                    figureList.Add(circ);
                    listBox1.Items.Add("Окружность с radius = " + (string.Join("", radius) + " и X = " + string.Join("", x) + " Y = " + string.Join("", y)));
                }
                if (stringa == "Прямоугольник")
                {
                    int height = Convert.ToInt32(heightTextBox.Text);
                    int width = Convert.ToInt32(widthTextBox.Text);
                    Rectangle rect = new Rectangle(x, y, width, height);
                    figureList.Add(rect);
                    listBox1.Items.Add("Прямоугольник с height = " + (string.Join("", height) + " width = " + (string.Join("", width) + " и X = " + string.Join("", x) + " Y = " + string.Join("", y))));
                }
            }
        }
        private void drawAllButton_Click(object sender, EventArgs e)
        {
            if (figureList.Count == 0)
            {
                MessageBox.Show("Вы не добавили ни одной фигуры!");
            }
            else
            {
                Form2 newForm = new Form2();
                newForm.Show();
                foreach (Figure f in figureList)
                {
                    f.drawFigure(newForm.bmp);
                }
            }
        }

        private void drawCirclesButton_Click(object sender, EventArgs e)
        {
            if (figureList.Count == 0)
            {
                MessageBox.Show("Вы не добавили ни одной фигуры!");
            }
            else
            {
                Form2 newForm = new Form2();
                newForm.Show();
                foreach (Figure f in figureList)
                {
                    if (f is Circle)
                    {
                        f.drawFigure(newForm.bmp);
                    }
                }
            }
        }

        private void mainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string stringa = (string)mainComboBox.SelectedItem;
            if (stringa == "Окружность")
            {
                radiusTextBox.Visible = true;
                widthTextBox.Visible = false;
                heightTextBox.Visible = false;
            }
            if (stringa == "Прямоугольник")
            {
                radiusTextBox.Visible = false;
                widthTextBox.Visible = true;
                heightTextBox.Visible = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            createAndAddFigureToList();
        }
    }
}
