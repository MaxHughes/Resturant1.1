using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant1._1
{
    public partial class Resturant : Form
    {
        //set all labels as false
        bool item1 = false, item2 = false, item3 = false, item4 = false, item5 = false, item6 = false,
            item7 = false, item8 = false, item9 = false, item10 = false;

        public Resturant()
        {
            InitializeComponent();
            hideBasketLabels();
        }

        #region Main Buttons

        private void starters_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        //STARTERS MENU BUTTON
        private void menu_btn1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void mains_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        //MAINS MENU BUTTON
        private void menu_btn2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void sides_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        //SIDES MENU BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void desserts_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage5);
        }
        
        //DESSERTS MENU BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void drinks_btn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage6);
        }

        //DRINKS MENU BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }


        #endregion

        //TOMATO SOUP
        private void button1_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Tomato Soup");
        }

        private void i1r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(1);
            if (item1_lbl.Text != "")
            {
                item1 = true;
            }
            else
            {
                item1 = false;
                i1r_btn.Hide();
            }
          
        }

        private void i2r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(2);
            if (item2_lbl.Text != "")
            {
                item2 = true;
            }
            else
            {
                item2 = false;
                i2r_btn.Hide();
            }
        }

        /// <summary>
        /// sorting method for the basket
        /// </summary>
        /// <param name="i"></param>
        private void basketClearSort(int i)
        {
            if (i == 1)
            {
                item1_lbl.Text = "";
                item1_lbl.Text = item2_lbl.Text;
                i++;
            }
            if (i == 2)
            {
                item2_lbl.Text = "";
                item2_lbl.Text = item3_lbl.Text;
                i++;
            }
            if (i == 3)
            {
                item3_lbl.Text = "";
                item3_lbl.Text = item4_lbl.Text;
                i++;
            }
            if (i == 4)
            {
                item4_lbl.Text = "";
                item4_lbl.Text = item5_lbl.Text;
                i++;
            }
            if (i == 5)
            {
                item5_lbl.Text = "";
                item5_lbl.Text = item6_lbl.Text;
                i++;
            }
            if (i == 6)
            {
                item6_lbl.Text = "";
                item6_lbl.Text = item7_lbl.Text;
                i++;
            }
            if (i == 7)
            {
                item7_lbl.Text = "";
                item7_lbl.Text = item8_lbl.Text;
                i++;
            }
            if (i == 8)
            {
                item8_lbl.Text = "";
                item8_lbl.Text = item9_lbl.Text;
                i++;
            }
            if (i == 9)
            {
                item9_lbl.Text = "";
                item9_lbl.Text = item10_lbl.Text;
                item10_lbl.Text = "";
            }
        }

        /// <summary>
        /// Checks if the labels are empty to use, false = empty, true = filled.
        /// Also shows the label once used
        /// </summary>
        /// <param name="i">input from the buttons</param>
        private void basketCheckLabels (string i)
        {
        
            if (item1 == false)
            {
                item1_lbl.Text = i;
                item1 = true;
                item1_lbl.Show();
                i1r_btn.Show();
            }
            else if (item2 == false)
            {
                item2_lbl.Text = i;
                item2 = true;
                item2_lbl.Show();
                i2r_btn.Show();
            }
            else if (item3 == false)
            {
                item3_lbl.Text = i;
                item3 = true;
                item3_lbl.Show();
                i3r_btn.Show();
            }
            else if (item4 == false)
            {
                item4_lbl.Text = i;
                item4 = true;
                item4_lbl.Show();
                i4r_btn.Show();
            }
            else if (item5 == false)
            {
                item5_lbl.Text = i;
                item5 = true;
                item5_lbl.Show();
                i5r_btn.Show();
            }
            else if (item6 == false)
            {
                item6_lbl.Text = i;
                item6 = true;
                item6_lbl.Show();
                i6r_btn.Show();
            }
            else if (item7 == false)
            {
                item7_lbl.Text = i;
                item7 = true;
                item7_lbl.Show();
                i7r_btn.Show();
            }
            else if (item8 == false)
            {
                item8_lbl.Text = i;
                item8 = true;
                item8_lbl.Show();
                i8r_btn.Show();
            }
            else if (item9 == false)
            {
                item9_lbl.Text = i;
                item9 = true;
                item9_lbl.Show();
                i9r_btn.Show();
            }
            else if (item10 == false)
            {
                item10_lbl.Text = i;
                item10 = true;
                item10_lbl.Show();
                i10r_btn.Show();
            }
        }

        /// <summary>
        /// Hides Basket labels at the begining.
        /// </summary>
        private void hideBasketLabels()
        {
            if (item1 == false)
            {
                item1_lbl.Hide();
                i1r_btn.Hide();
            }
            if (item2 == false)
            {
                item2_lbl.Hide();
                i2r_btn.Hide();
            }
            if (item3 == false)
            {
                item3_lbl.Hide();
                i3r_btn.Hide();
            }
            if (item4 == false)
            {
                item4_lbl.Hide();
                i4r_btn.Hide();
            }
            if (item5 == false)
            {
                item5_lbl.Hide();
                i5r_btn.Hide();
            }
            if (item6 == false)
            {
                item6_lbl.Hide();
                i6r_btn.Hide();
            }
            if (item7 == false)
            {
                item7_lbl.Hide();
                i7r_btn.Hide();
            }
            if (item8 == false)
            {
                item8_lbl.Hide();
                i8r_btn.Hide();
            }
            if (item9 == false)
            {
                item9_lbl.Hide();
                i9r_btn.Hide();
            }
            if (item10 == false)
            {
                item10_lbl.Hide();
                i10r_btn.Hide();
            }
        }

    }
}
