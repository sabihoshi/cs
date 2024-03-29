﻿using System;
using System.Windows.Forms;

namespace Login
{
	public partial class Subscription : Form
	{
		public int cost;

		public string[] output = new string[5];
		public double total;

		private readonly User User = new User();

		public Subscription()
		{
			InitializeComponent();
		}

		private void Subscription_Load(object sender, EventArgs e)
		{
			User.CreateUser(Entry.userName);
			ProjectList.SelectedItem = User.userData.Plan.ToString();
			LengthList.SelectedItem = User.userData.Subscription.ToString();
		}

		public void UpdateForm()
		{
			switch (ProjectList.SelectedItem)
			{
				case "C++":
					LengthList.Enabled = true;
					output[0] = "Selected Plan: " + ProjectList.SelectedItem;
					cost = 800;
					output[1] = string.Format("Cost: ${0:n0}/month", cost);
					break;

				case "C#":
					LengthList.Enabled = true;
					output[0] = "Selected Plan: " + ProjectList.SelectedItem;
					cost = 1200;
					output[1] = string.Format("Cost: ${0:n0}/month", cost);
					break;

				case "Python":
					LengthList.Enabled = true;
					output[0] = "Selected Plan: " + ProjectList.SelectedItem;
					cost = 700;
					output[1] = string.Format("Cost: ${0:n0}/month", cost);
					break;

				case "BBTag":
					LengthList.Enabled = true;
					output[0] = "Selected Plan: " + ProjectList.SelectedItem;
					cost = 500;
					output[1] = string.Format("Cost: ${0:n0}/month", cost);
					break;

				default:
					LengthList.Enabled = false;
					PurchaseButton.Enabled = false;
					output[0] = "Selected Plan: None";
					cost = 0;
					output[1] = string.Format("Cost: ${0:n0}/ month", cost);
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
					output[2] = string.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100,
						disCountValue * 1);
					break;

				case "3 months":
					PurchaseButton.Enabled = true;
					disCount = 0.05;
					disCountValue = cost * disCount;
					total = (cost - disCountValue) * 3;
					output[2] = string.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100,
						disCountValue * 3);
					break;

				case "6 months":
					PurchaseButton.Enabled = true;
					disCount = 0.15;
					disCountValue = cost * disCount;
					total = (cost - disCountValue) * 6;
					output[2] = string.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100,
						disCountValue * 6);
					break;

				case "1 year":
					PurchaseButton.Enabled = true;
					disCount = 0.25;
					disCountValue = cost * disCount;
					total = (cost - disCountValue) * 12;
					output[2] = string.Format("\nTotal: ${0:n0}\nDiscount: {1}% ({2:n0})", total, disCount * 100,
						disCountValue * 12);
					break;

				default:
					PurchaseButton.Enabled = false;
					output[2] = "";
					break;
			}

			SubTextBox.Text = string.Join("\n", output);
		}

		private void ProjectList_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateForm();
		}

		private void LengthList_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateForm();
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