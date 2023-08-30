using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Geometrias;

namespace TA29_sgallego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            result.Text = String.Concat(forma.areacuadrado(area1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            result.Text = String.Concat(forma.areaCirculo(area1));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            int area2 = int.Parse(a2.Text);
            result.Text = String.Concat(forma.areatriangulo(area1,area2));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            int area2 = int.Parse(a2.Text);
            result.Text = String.Concat(forma.arearectangulo(area1, area2));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            int area2 = int.Parse(a2.Text);
            result.Text = String.Concat(forma.areapentagono(area1, area2));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            int area2 = int.Parse(a2.Text);
            result.Text = String.Concat(forma.arearombo(area1, area2));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            int area2 = int.Parse(a2.Text);
            result.Text = String.Concat(forma.arearomboide(area1, area2));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Geometria forma = new Geometria();
            int area1 = int.Parse(a1.Text);
            int area2 = int.Parse(a2.Text);
            int area3 = int.Parse(a2.Text);

            result.Text = String.Concat(forma.areatrapecio(area1, area2, area3));
        }
    }
}
