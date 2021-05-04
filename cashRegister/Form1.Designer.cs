
namespace cashRegister
{
    partial class background
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.shoeNumber = new System.Windows.Forms.Label();
            this.basketballNumber = new System.Windows.Forms.Label();
            this.headbandNumber = new System.Windows.Forms.Label();
            this.textLabelShoes = new System.Windows.Forms.TextBox();
            this.textLabelHeadbands = new System.Windows.Forms.TextBox();
            this.textLabelBasketball = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.receiptLabel = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.changeBackLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // shoeNumber
            // 
            this.shoeNumber.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoeNumber.Location = new System.Drawing.Point(26, 107);
            this.shoeNumber.Name = "shoeNumber";
            this.shoeNumber.Size = new System.Drawing.Size(235, 23);
            this.shoeNumber.TabIndex = 0;
            this.shoeNumber.Text = "Number of Micael Jordane Shoes";
            // 
            // basketballNumber
            // 
            this.basketballNumber.AutoSize = true;
            this.basketballNumber.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basketballNumber.Location = new System.Drawing.Point(26, 155);
            this.basketballNumber.Name = "basketballNumber";
            this.basketballNumber.Size = new System.Drawing.Size(151, 16);
            this.basketballNumber.TabIndex = 1;
            this.basketballNumber.Text = "Number of Basketballs";
            // 
            // headbandNumber
            // 
            this.headbandNumber.AutoSize = true;
            this.headbandNumber.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headbandNumber.Location = new System.Drawing.Point(27, 201);
            this.headbandNumber.Name = "headbandNumber";
            this.headbandNumber.Size = new System.Drawing.Size(150, 16);
            this.headbandNumber.TabIndex = 2;
            this.headbandNumber.Text = "Number of Headbands";
            // 
            // textLabelShoes
            // 
            this.textLabelShoes.Location = new System.Drawing.Point(253, 106);
            this.textLabelShoes.Name = "textLabelShoes";
            this.textLabelShoes.Size = new System.Drawing.Size(36, 20);
            this.textLabelShoes.TabIndex = 3;
            // 
            // textLabelHeadbands
            // 
            this.textLabelHeadbands.Location = new System.Drawing.Point(253, 200);
            this.textLabelHeadbands.Name = "textLabelHeadbands";
            this.textLabelHeadbands.Size = new System.Drawing.Size(36, 20);
            this.textLabelHeadbands.TabIndex = 4;
            // 
            // textLabelBasketball
            // 
            this.textLabelBasketball.Location = new System.Drawing.Point(253, 155);
            this.textLabelBasketball.Name = "textLabelBasketball";
            this.textLabelBasketball.Size = new System.Drawing.Size(36, 20);
            this.textLabelBasketball.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(64, 243);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(197, 31);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Totals";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(27, 293);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(85, 103);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Sub Total \r\n\r\nTax \r\n\r\nTotal";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 20);
            this.label1.TabIndex = 8;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(27, 438);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(68, 16);
            this.tenderedLabel.TabIndex = 9;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(196, 434);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(95, 20);
            this.tenderedBox.TabIndex = 10;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(81, 470);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(159, 30);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(26, 516);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(69, 23);
            this.changeLabel.TabIndex = 12;
            this.changeLabel.Text = "Change";
            // 
            // receiptButton
            // 
            this.receiptButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.Location = new System.Drawing.Point(81, 552);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(159, 30);
            this.receiptButton.TabIndex = 13;
            this.receiptButton.Text = "Print Receipt ";
            this.receiptButton.UseVisualStyleBackColor = true;
            this.receiptButton.Click += new System.EventHandler(this.receiptButton_Click);
            // 
            // receiptLabel
            // 
            this.receiptLabel.BackColor = System.Drawing.Color.Snow;
            this.receiptLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.receiptLabel.Location = new System.Drawing.Point(343, 106);
            this.receiptLabel.Name = "receiptLabel";
            this.receiptLabel.Size = new System.Drawing.Size(292, 446);
            this.receiptLabel.TabIndex = 14;
            this.receiptLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(415, 564);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(161, 33);
            this.newOrderButton.TabIndex = 15;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(126, 293);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(165, 81);
            this.priceLabel.TabIndex = 16;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // changeBackLabel
            // 
            this.changeBackLabel.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBackLabel.Location = new System.Drawing.Point(189, 516);
            this.changeBackLabel.Name = "changeBackLabel";
            this.changeBackLabel.Size = new System.Drawing.Size(100, 23);
            this.changeBackLabel.TabIndex = 17;
            this.changeBackLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(657, 609);
            this.Controls.Add(this.changeBackLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptLabel);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.textLabelBasketball);
            this.Controls.Add(this.textLabelHeadbands);
            this.Controls.Add(this.textLabelShoes);
            this.Controls.Add(this.headbandNumber);
            this.Controls.Add(this.basketballNumber);
            this.Controls.Add(this.shoeNumber);
            this.Name = "background";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shoeNumber;
        private System.Windows.Forms.Label basketballNumber;
        private System.Windows.Forms.Label headbandNumber;
        private System.Windows.Forms.TextBox textLabelShoes;
        private System.Windows.Forms.TextBox textLabelHeadbands;
        private System.Windows.Forms.TextBox textLabelBasketball;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label receiptLabel;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label changeBackLabel;
    }
}

