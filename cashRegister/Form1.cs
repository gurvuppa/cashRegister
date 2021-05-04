using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cashRegister
{
    public partial class background : Form
    {
        double shoePrice = 50.00;
        double ballPrice = 20.00;
        double bandPrice = 10.00;

        double totalShoes;
        double totalBalls;
        double totalBands;

        double subTotal;
        double taxRate = 0.13;
        double taxAmount;
        double totalCost;
        double amountTendered;
        double changeAmount;






        public background()
        {
            InitializeComponent();
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            totalLabel.Visible = false;

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                totalShoes = Convert.ToDouble(textLabelShoes.Text);
                totalBands = Convert.ToDouble(textLabelBasketball.Text);
                totalBalls = Convert.ToDouble(textLabelHeadbands.Text);

                subTotal = (totalShoes * shoePrice) + (totalBalls * ballPrice) + (totalBands * ballPrice);

                taxAmount = subTotal * taxRate;

                totalCost = subTotal + taxRate;

                totalLabel.Visible = true;

                priceLabel.Text = $"{subTotal.ToString("C")}";
                priceLabel.Text += $"\n\n{taxAmount.ToString("C")}";
                priceLabel.Text += $"\n\n{totalCost.ToString("C")}";

                changeButton.Enabled = true;
            }
            catch
            {
                receiptLabel.Text = "\n\nPlease Enter The Amount Each Item You Would Like As a Number\n\nEnter a 0 If You Wouldn't Like to Buy a Certain Item\n\nThank You!!";
            }




        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            amountTendered = Convert.ToDouble(tenderedBox.Text);
            
            if (amountTendered > totalCost)
            {
                changeAmount = amountTendered - totalCost;

                changeBackLabel.Text = $"{changeAmount.ToString("C")}";
               
                receiptButton.Enabled = true;
            }
            else
            {
                receiptLabel.Text = "\n\n\nYou dont have enough money!!!\n\nPlease leave or pay the rest\n\nThank You!";
            }    


        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "\n\nThe Best Real Authentic Basketball Shop\n\nOrder Number 102";
            receiptLabel.Text += $"\n\nergdfgr";
        }
    }
}
