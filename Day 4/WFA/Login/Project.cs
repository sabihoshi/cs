using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        public string[] output = new string[5];
        public int cost = 0;
        public double total = 0;

        public void Update()
        {
            switch (ProjectList.SelectedItem)
            {
                case "C++":
                    LengthList.Enabled = true;
                    output[0] = "Selected Plan: " + ProjectList.SelectedItem.ToString();
                    cost = 800;
                    output[1] = String.Format("Cost: ${0:n0}/month", cost);
                    break;

                case "C#":
                    LengthList.Enabled = true;
                    output[0] = "Selected Plan: " + ProjectList.SelectedItem.ToString();
                    cost = 1200;
                    output[1] = String.Format("Cost: ${0:n0}/month", cost);
                    break;

                case "Python":
                    LengthList.Enabled = true;
                    output[0] = "Selected Plan: " + ProjectList.SelectedItem.ToString();
                    cost = 700;
                    output[1] = String.Format("Cost: ${0:n0}/month", cost);
                    break;

                case "BBTag":
                    LengthList.Enabled = true;
                    output[0] = "Selected Plan: " + ProjectList.SelectedItem.ToString();
                    cost = 500;
                    output[1] = String.Format("Cost: ${0:n0}/month", cost);
                    break;

                default:
                    LengthList.Enabled = false;
                    output[0] = "Selected Plan: None";
                    cost = 0;
                    output[1] = String.Format("Cost: ${0:n0}/ month", cost);
                    break;
            }
            double disCount, disCountValue;
            switch (LengthList.SelectedItem)
            {
                case "1 month":
                    total = cost;
                    disCount = 0;
                    disCountValue = cost * disCount;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 1);
                    break;

                case "3 months":
                    disCount = 0.05;
                    disCountValue = cost * disCount;
                    total = (cost - disCountValue) * 3;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 3);
                    break;

                case "6 months":
                    disCount = 0.15;
                    disCountValue = cost * disCount;
                    total = (cost - disCountValue) * 6;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 6);
                    break;

                case "1 year":
                    disCount = 0.25;
                    disCountValue = cost * disCount;
                    total = (cost - disCountValue) * 12;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 12);
                    break;

                default:
                    output[2] = "";
                    break;
            }
            richTextBox.Text = String.Join("\n", output);
        }
    }
}