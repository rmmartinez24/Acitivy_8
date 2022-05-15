using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_Eight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Start of fat calories

        private int FatCalories(int fat)
        {
            return fat * 9;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int gramsOfFat;
            int fatCalories;

            if (int.TryParse(FatEntered.Text, out gramsOfFat))
            {
                fatCalories = FatCalories(gramsOfFat);
                displayFat.Text = "Calories from Gram Fat Consumed: " + fatCalories + "g";
            }
        }

        //End of fat Calories

        //Start of carb Calories

        private int CarbCalories (int carbs)
        {
            return carbs * 4;
        }

        private void calculateCarbs_Click(object sender, EventArgs e)
        {
            int grasOfCarbs;
            int carbCalories;

            if ( int.TryParse(CarbsEntered.Text, out grasOfCarbs))
            {
                carbCalories = CarbCalories(grasOfCarbs);
                displayCarbs.Text = "Calories from Grams of Carbohydrates Consumed: " + carbCalories + "g";
            }
        }

        //End of carb Calories
    }
}
