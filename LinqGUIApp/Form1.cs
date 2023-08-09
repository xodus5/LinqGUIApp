using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUIApp
{
    public partial class Form1 : Form
    {
        static private List<Food> foodList = new List<Food>() 
        { 
            new Food() { Name="떡볶이", Price=3500}, 
            new Food() { Name="탕후루", Price=3000}, 
            new Food() { Name="햄버거", Price=9000}, 
            new Food() { Name="짜장면", Price=8000}, 
            new Food() { Name="토스트", Price=2500}, 
            new Food() { Name="껌", Price=1000}, 
            new Food() { Name="빼빼로", Price=1700}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foodBindingSource.DataSource = foodList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foodBindingSource.DataSource = from item in foodList
                                           where item.Price >= 1500
                                           orderby item.Price descending
                                           select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foodBindingSource.DataSource = from item in foodList
                                           orderby item.Name descending
                                           select item;
        }
    }
}
