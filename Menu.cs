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
            displayTime();
        }

        private void displayTime()
        {
            //00:00 format time
            time_lbl.Text = DateTime.Now.ToShortTimeString();
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

        #region Starters
        //STARTERS BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Tomato Soup", "5" );
        }

        private void itm2_btn_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Scallops with Peking Duck", "10");
        }

        private void itm3_btn_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Salmon and Dill tartare", "8");
        }

        private void itm4_btn_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Blue Cheese Mousse with Beetroot", "7");
        }

        private void itm5_btn_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Smoked Chicken and Parma Ham", "7");
        }

        private void itm6_btn_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Duck Liver and Sour Bread", "7");
        }
        #endregion

        #region Mains

        private void button6_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Filet Steak", "14");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Rib-Eye Steak", "18");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Spitroast Chicken and BBQ Ribs", "13");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Spitroast Chicken", "9");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Beef Burger", "11");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Halloumi Burger", "11");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Hot Dog", "8");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Margarita Pizza", "12");
        }

        #endregion

        #region Sides

        private void button14_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Chips", "3");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Sweet Potato Fries", "3");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Onion Rings", "3");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Mozzarella Sticks", "4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Salad", "2");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Garlic Bread", "3");
        }

        #endregion

        #region Desserts

        private void button20_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Creme Brulee", "5");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Chocolate Brulee Sundae", "5");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Waffles and Syrup", "5");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Cheese Cake", "5");
        }

        #endregion

        #region Drinks

        private void button24_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Coca Cola", "3");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Sprite", "3");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Fosters", "4");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Carlsberg", "4");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Guinness", "4");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Martini", "6");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            basketCheckLabels("Mojito", "6");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            basketCheckLabels("On The Beach", "6");
        }

        #endregion

        //The buttons with the X which clears that line of order
        #region Basket Clear Buttons
        private void i1r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(1);
        }

        private void i2r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(2);
        }

        private void i3r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(3);
        }

        private void i4r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(4);
        }

        private void i5r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(5);
        }

        private void i6r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(6);
        }

        private void i7r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(7);
        }

        private void i8r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(8);
        }

        private void i9r_btn_Click(object sender, EventArgs e)
        {
            basketClearSort(9);
        }

        private void i10r_btn_Click(object sender, EventArgs e)
        {
            item10_lbl.Text = "";
            basketClearSort(10);
        }

        #endregion

        /// <summary>
        /// sorting method for the basket
        /// </summary>
        /// <param name="i"></param>
        private void basketClearSort(int i)
        {
            if (i == 1)
            {
                //set label text as empty
                item1_lbl.Text = "";
                price1_lbl.Text = "";
                //set label text as label underneath
                item1_lbl.Text = item2_lbl.Text;
                price1_lbl.Text = price2_lbl.Text;

                //carry on till it reaches the end of the method
                i++;
            }
            if (i == 2)
            {
                item2_lbl.Text = "";
                price2_lbl.Text = "";
                item2_lbl.Text = item3_lbl.Text;
                price2_lbl.Text = price3_lbl.Text;

                i++;
            }
            if (i == 3)
            {
                item3_lbl.Text = "";
                price3_lbl.Text = "";
                item3_lbl.Text = item4_lbl.Text;
                price3_lbl.Text = price4_lbl.Text;

                i++;
            }
            if (i == 4)
            {
                item4_lbl.Text = "";
                price4_lbl.Text = "";
                item4_lbl.Text = item5_lbl.Text;
                price4_lbl.Text = price5_lbl.Text;

                i++;
            }
            if (i == 5)
            {
                item5_lbl.Text = "";
                price5_lbl.Text = "";
                item5_lbl.Text = item6_lbl.Text;
                price5_lbl.Text = price6_lbl.Text;

                i++;
            }
            if (i == 6)
            {
                item6_lbl.Text = "";
                price6_lbl.Text = "";
                item6_lbl.Text = item7_lbl.Text;
                price6_lbl.Text = price7_lbl.Text;

                i++;
            }
            if (i == 7)
            {
                item7_lbl.Text = "";
                price7_lbl.Text = "";
                item7_lbl.Text = item8_lbl.Text;
                price7_lbl.Text = price8_lbl.Text;

                i++;
            }
            if (i == 8)
            {
                item8_lbl.Text = "";
                price8_lbl.Text = "";
                item8_lbl.Text = item9_lbl.Text;
                price8_lbl.Text = price9_lbl.Text;
                i++;
            }
            if (i == 9)
            {
                item9_lbl.Text = "";
                price9_lbl.Text = "";
                item9_lbl.Text = item10_lbl.Text;
                price9_lbl.Text = price10_lbl.Text;
                item10_lbl.Text = "";
                price10_lbl.Text = "";
                i++;
            }
            if (i == 10)
            {
                if (item1_lbl.Text == "")
                {
                    item1 = false;
                    gbp1_lbl.Hide();
                    i1r_btn.Hide();
                }
                if (item2_lbl.Text == "")
                {
                    item2 = false;
                    gbp2_lbl.Hide();
                    i2r_btn.Hide();
                }
                if (item3_lbl.Text == "")
                {
                    item3 = false;
                    gbp3_lbl.Hide();
                    i3r_btn.Hide();
                }
                if (item4_lbl.Text == "")
                {
                    item4 = false;
                    gbp4_lbl.Hide();
                    i4r_btn.Hide();
                }
                if (item5_lbl.Text == "")
                {
                    item5 = false;
                    gbp5_lbl.Hide();
                    i5r_btn.Hide();
                }
                if (item6_lbl.Text == "")
                {
                    item6 = false;
                    gbp6_lbl.Hide();
                    i6r_btn.Hide();
                }
                if (item7_lbl.Text == "")
                {
                    item7 = false;
                    gbp7_lbl.Hide();
                    i7r_btn.Hide();
                }
                if (item8_lbl.Text == "")
                {
                    item8 = false;
                    gbp8_lbl.Hide();
                    i8r_btn.Hide();
                }
                if (item9_lbl.Text == "")
                {
                    item9 = false;
                    gbp9_lbl.Hide();
                    i9r_btn.Hide();
                }
                if (item10_lbl.Text == "")
                {
                    item10 = false;
                    gbp10_lbl.Hide();
                    i10r_btn.Hide();
                }

            }

        }

        /// <summary>
        /// Checks if the labels are empty to use, false = empty, true = filled.
        /// Also shows the label once used
        /// </summary>
        /// <param name="i">input from the buttons</param>
        private void basketCheckLabels (string i , string j)
        {
            if (item1 == false)
            {
                //change text of item and price label
                item1_lbl.Text = i;
                price1_lbl.Text = j;
                //set item boolean to true so its taken
                item1 = true;
                //show pound sign and the remove button
                gbp1_lbl.Show();
                i1r_btn.Show();
            }
            else if (item2 == false)
            {
                item2_lbl.Text = i;
                price2_lbl.Text = j;
                item2 = true;
                gbp2_lbl.Show();
                i2r_btn.Show();
            }
            else if (item3 == false)
            {
                item3_lbl.Text = i;
                price3_lbl.Text = j;
                item3 = true;
                gbp3_lbl.Show();
                i3r_btn.Show();
            }
            else if (item4 == false)
            {
                item4_lbl.Text = i;
                price4_lbl.Text = j;
                item4 = true;
                gbp4_lbl.Show();
                i4r_btn.Show();
            }
            else if (item5 == false)
            {
                item5_lbl.Text = i;
                price5_lbl.Text = j;
                item5 = true;
                gbp5_lbl.Show();
                i5r_btn.Show();
            }
            else if (item6 == false)
            {
                item6_lbl.Text = i;
                price6_lbl.Text = j;
                item6 = true;
                gbp6_lbl.Show();
                i6r_btn.Show();
            }
            else if (item7 == false)
            {
                item7_lbl.Text = i;
                price7_lbl.Text = j;
                item7 = true;
                gbp7_lbl.Show();
                i7r_btn.Show();
            }
            else if (item8 == false)
            {
                item8_lbl.Text = i;
                price8_lbl.Text = j;
                item8 = true;
                gbp8_lbl.Show();
                i8r_btn.Show();
            }
            else if (item9 == false)
            {
                item9_lbl.Text = i;
                price9_lbl.Text = j;
                item9 = true;
                gbp9_lbl.Show();
                i9r_btn.Show();
            }
            else if (item10 == false)
            {
                item10_lbl.Text = i;
                price10_lbl.Text = j;
                item10 = true;
                gbp10_lbl.Show();
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
                item1_lbl.Text = "";
                price1_lbl.Text = "";
                gbp1_lbl.Hide();
                i1r_btn.Hide();
            }
            if (item2 == false)
            {
                item2_lbl.Text = "";
                price2_lbl.Text = "";
                gbp2_lbl.Hide();
                i2r_btn.Hide();
            }
            if (item3 == false)
            {
                item3_lbl.Text = "";
                price3_lbl.Text = "";
                gbp3_lbl.Hide();
                i3r_btn.Hide();
            }
            if (item4 == false)
            {
                item4_lbl.Text = "";
                price4_lbl.Text = "";
                gbp4_lbl.Hide();
                i4r_btn.Hide();
            }
            if (item5 == false)
            {
                item5_lbl.Text = "";
                price5_lbl.Text = "";
                gbp5_lbl.Hide();
                i5r_btn.Hide();
            }
            if (item6 == false)
            {
                item6_lbl.Text = "";
                price6_lbl.Text = "";
                gbp6_lbl.Hide();
                i6r_btn.Hide();
            }
            if (item7 == false)
            {
                item7_lbl.Text = "";
                price7_lbl.Text = "";
                gbp7_lbl.Hide();
                i7r_btn.Hide();
            }
            if (item8 == false)
            {
                item8_lbl.Text = "";
                price8_lbl.Text = "";
                gbp8_lbl.Hide();
                i8r_btn.Hide();
            }
            if (item9 == false)
            {
                item9_lbl.Text = "";
                price9_lbl.Text = "";
                gbp9_lbl.Hide();
                i9r_btn.Hide();
            }
            if (item10 == false)
            {
                item10_lbl.Text = "";
                price10_lbl.Text = "";
                gbp10_lbl.Hide();
                i10r_btn.Hide();
            }
        }

        private void totalCost()
        {

            int p1 = Convert.ToInt32(price1_lbl.Text),
                p2 = Convert.ToInt32(price2_lbl.Text),
                p3 = Convert.ToInt32(price3_lbl.Text),
                p4 = Convert.ToInt32(price4_lbl.Text),
                p5 = Convert.ToInt32(price5_lbl.Text),
                p6 = Convert.ToInt32(price6_lbl.Text),
                p7 = Convert.ToInt32(price7_lbl.Text),
                p8 = Convert.ToInt32(price8_lbl.Text),
                p9 = Convert.ToInt32(price9_lbl.Text),
                p10 = Convert.ToInt32(price10_lbl.Text);


            int total = p1 + p2 + p3 + p4 + p5 + p6 + p7 + p8 + p9 + p10;
            totalCost_lbl.Text = total.ToString();
        }


    }
}
