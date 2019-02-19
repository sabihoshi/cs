using System;
using System.Windows.Forms;

namespace Login
{
    public partial class Subscription : Form
    {
        public Subscription()
        {
            InitializeComponent();
        }

        public string[] output = new string[5];
        public int cost = 0;
        public double total = 0;

        private User User = new User();

        private void Subscription_Load(object sender, EventArgs e)
        {
            User.CreateUser(Entry.userName);
            ProjectList.SelectedItem = User.userData.Plan.ToString();
            LengthList.SelectedItem = User.userData.Subscription.ToString();
        }

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
                    PurchaseButton.Enabled = false;
                    output[0] = "Selected Plan: None";
                    cost = 0;
                    output[1] = String.Format("Cost: ${0:n0}/ month", cost);
                    break;
            }
            double disCount, disCountValue;
            switch (LengthList.SelectedItem)
            {
                case "1 month":
                    PurchaseButton.Enabled = true;
                    total = cost;
                    disCount = 0;
                    disCountValue = cost * disCount;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 1);
                    break;

                case "3 months":
                    PurchaseButton.Enabled = true;
                    disCount = 0.05;
                    disCountValue = cost * disCount;
                    total = (cost - disCountValue) * 3;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 3);
                    break;

                case "6 months":
                    PurchaseButton.Enabled = true;
                    disCount = 0.15;
                    disCountValue = cost * disCount;
                    total = (cost - disCountValue) * 6;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 6);
                    break;

                case "1 year":
                    PurchaseButton.Enabled = true;
                    disCount = 0.25;
                    disCountValue = cost * disCount;
                    total = (cost - disCountValue) * 12;
                    output[2] = String.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100, disCountValue * 12);
                    break;

                default:
                    PurchaseButton.Enabled = false;
                    output[2] = "";
                    break;
            }
            SubTextBox.Text = String.Join("\n", output);
        }

        private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void LengthList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            User.userData.Plan = ProjectList.Text;
            User.userData.Subscritption = LengthList.Text;
            User.JsonUpdate
                (User.userFile, User.userData);
        }
    }
}