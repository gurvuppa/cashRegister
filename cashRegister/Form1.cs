/*
 * Gurvir Uppal
 * Cash Register Summative 
 * May 5, 2021 
 * Mr. T 
 * ICS3U
 * */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace cashRegister
{
    public partial class background : Form
    {
        double shoePrice = 50.00;
        double ballPrice = 20.00;
        double bandPrice = 10.00;
        double taxRate = 0.13;

        double totalShoes;
        double totalBalls;
        double totalBands;

        double subTotal;
        double taxAmount;
        double totalCost;
        double amountTendered;
        double changeAmount;






        public background()
        {
            InitializeComponent();
            changeButton.Enabled = false;           // buttons are not able to be pressed
            receiptButton.Enabled = false;          // buttons are not able to be pressed
            totalLabel.Visible = false;            //a tex box is invisable  

            timerLabel.Visible = false;           //the date wont be seen until receipt is print
            

            timer1.Stop();



        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer buttonPressPlayer = new SoundPlayer(Properties.Resources.Button_SoundBible_com_1420500901);

                buttonPressPlayer.Play();



                if (textLabelHeadbands.Text == "")                                  //if  user no does not put 0's into the textBox, it will automatically be filled
                    textLabelShoes.Text = "0";

                if (textLabelBasketball.Text == "")                                  //if  user no does not put 0's into the textBox, it will automatically be filled           
                    textLabelBasketball.Text = "0";

                if (textLabelHeadbands.Text == "")                                  //if  user no does not put 0's into the textBox, it will automatically be filled
                    textLabelHeadbands.Text = "0";

                totalShoes = Convert.ToDouble(textLabelShoes.Text);
                totalBands = Convert.ToDouble(textLabelBasketball.Text);
                totalBalls = Convert.ToDouble(textLabelHeadbands.Text);

                

                    subTotal = (totalShoes * shoePrice) + (totalBalls * ballPrice) + (totalBands * bandPrice);      //add all the prices to get the sub total
                    
                taxAmount = subTotal * taxRate;             //get the amount of tax

                totalCost = subTotal + taxAmount;           //to get the total cost

                totalLabel.Visible = true;      //set the label that shows the total cost to visable

                priceLabel.Text = $"{subTotal.ToString("C")}";                      //print the totals
                priceLabel.Text += $"\n\n{taxAmount.ToString("C")}";                //print the totals
                priceLabel.Text += $"\n\n{totalCost.ToString("C")}";                //print the totals

                changeButton.Enabled = true;                            //set the change button to enabled 
                
            }
            catch
            {
                receiptLabel.Text = "\n\nPlease Enter The Amount of Each Item You Would Like As a Number\n\nThank You!!";     //print this if the costumer does not put the values in correctly
            }




        }

        private void changeButton_Click(object sender, EventArgs e)
        {


            try
            {
                SoundPlayer chaChingPlayer = new SoundPlayer(Properties.Resources.Cha_Ching_Register_Muska666_173262285);

                chaChingPlayer.Play();

                amountTendered = Convert.ToDouble(tenderedBox.Text);




                if (amountTendered >= totalCost)
                {
                    amountTendered = Convert.ToDouble(tenderedBox.Text);

                    changeAmount = amountTendered - totalCost;

                    changeBackLabel.Text = $"{changeAmount.ToString("C")}";

                    receiptButton.Enabled = true;                           //enable the receipt button
                }
                else
                {
                    receiptLabel.Text = "\n\n\nYou dont have enough money!!!\n\nPlease leave or pay the rest\n\nThank You!";
                }

            }

            catch
            {
                receiptLabel.Text = "Please Enter a Valid Amount of Money";
            }


        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer printerPlayer = new SoundPlayer(Properties.Resources.Dot_Matrix_Printer_SoundBible_com_790333844);
            printerPlayer.Play();

            receiptLabel.Text = "\n\n                100% Authentic Not Fake Basketball Shop\n\n\n   Order Number 102";

            timerLabel.Visible = true;                                      //set the date to be visable
            timer1.Start();                                                 //print the date
           

                receiptLabel.Text += $"\n\n\n\n   Micael Jordane Shoes x{totalShoes}";
                receiptLabel.Text += $"\n\n   Basketball x{totalBalls}";
                receiptLabel.Text += $"\n\n   Headband x{totalBands}";

                priceReceiptLabel.Text = $"\n\n @{shoePrice.ToString("C")}";
                priceReceiptLabel.Text += $"\n\n @{ballPrice.ToString("C")}";
                priceReceiptLabel.Text += $"\n\n @{bandPrice.ToString("C")}";

                receiptLabel.Text += $"\n\n\n   Subtotal";
                receiptLabel.Text += $"\n\n   Tax";
                receiptLabel.Text += $"\n\n   Total";

                priceReceiptLabel.Text += $"\n\n\n {subTotal.ToString("C")}";
                priceReceiptLabel.Text += $"\n\n {taxAmount.ToString("C")}";
                priceReceiptLabel.Text += $"\n\n {totalCost.ToString("C")}";

                receiptLabel.Text += $"\n\n\n   Tendered";
                receiptLabel.Text += $"\n\n   Change";

                priceReceiptLabel.Text += $"\n\n\n {amountTendered.ToString("C")}";
                priceReceiptLabel.Text += $"\n\n {changeAmount.ToString("C")}";

                receiptLabel.Text += "\n\n   Thank You! Have a Nice Day!!";

        }

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            background NewForm = new background();
            NewForm.Show();
            this.Dispose(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerLabel.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
    }
}
