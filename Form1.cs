using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UserInfo aUserInfo = new UserInfo();

        private void creatButton_Click(object sender, EventArgs e)
        {
            //UserInfo aUserInfo = new UserInfo();

            aUserInfo.accountNumber = AccountNumberTextBox.Text;
            aUserInfo.customerName = CustomerNameTextBox.Text;

            MessageBox.Show("Account created successfully");
           // MessageBox.Show(aUserInfo.customerName);
        }

        private void deposirButton_Click(object sender, EventArgs e)
        {
       
           // UserInfo aUserInfo = new UserInfo();

            aUserInfo.amount = Convert.ToDouble(AmountTextBox.Text); 
            MessageBox.Show(Convert.ToString(aUserInfo.GetDiposit()));
            AmountTextBox.Text = "";
        }

       

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            aUserInfo.amount = Convert.ToDouble(AmountTextBox.Text);
            string result = Convert.ToString(aUserInfo.GetDiposit() - aUserInfo.amount);
            MessageBox.Show(result);   
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Convert.ToString(aUserInfo.Withdraw()));


        }
    }
}
