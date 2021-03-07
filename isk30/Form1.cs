using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace isk30
{
    public partial class Form1 : Form
    {
        Pont pont1 = new Pont();
        Pont pont2 = new Pont();

        public Form1()
        {
            InitializeComponent();
        }

        #region Buttons
        private void pont1update_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(pont1x.Text);
                double y = double.Parse(pont1y.Text);

                pont1.X = x;
                pont1.Y = y;

                MessageBox.Show("Felujitva!");
            } catch (FormatException)
            {
                MessageBox.Show("Invalid bevitel!");
            }
        }
        
        private void pont2update_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(pont2x.Text);
                double y = double.Parse(pont2y.Text);

                pont2.X = x;
                pont2.Y = y;

                MessageBox.Show("Felujitva!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid bevitel!");
            }
        }
        #endregion

        class Pont {
            private double x;
            private double y;

            public double X { 
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }

            public double Tavolsag(Pont _pont)
            {

                return Math.Sqrt(Math.Pow(this.x - _pont.X, 2) + Math.Pow(this.y - _pont.Y, 2));
            }
            public void Elmozgat(double dx, double dy)
            {

                this.x += dx;
                this.y+= dy;
            }
        }

        private void TavlosagBtn_Click(object sender, EventArgs e)
        {
            resultLabel.Text = $"Tavolsag: {pont1.Tavolsag(pont2)}";
        }

        #region Move button
        private void MoveBtn_Click(object sender, EventArgs e)
        {
            switch(pontToMove.SelectedItem)
            {
                case "Pont 1":
                    try
                    {
                        double x = double.Parse(xMove.Text);
                        double y = double.Parse(yMove.Text);

                        pont1.Elmozgat(x, y);
                        pont1x.Text = pont1.X.ToString();
                        pont1y.Text = pont1.Y.ToString();

                        MessageBox.Show("Elmozgatva");
                    } catch(FormatException)
                    {
                        MessageBox.Show("Invalid format!");
                    }
                    break;
                case "Pont 2":
                    try
                    {
                        double x = double.Parse(xMove.Text);
                        double y = double.Parse(yMove.Text);

                        pont2.Elmozgat(x, y);
                        pont2x.Text = pont2.X.ToString();
                        pont2y.Text = pont2.Y.ToString();

                        MessageBox.Show("Elmozgatva");
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid format!");
                    }
                    break;
                default:
                    MessageBox.Show("Pont nincs kivalostva!");
                    break;
            }
        }
        #endregion
    }
}
