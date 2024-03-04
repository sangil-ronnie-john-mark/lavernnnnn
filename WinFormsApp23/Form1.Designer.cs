namespace WinFormsApp23
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            lblDrinkPrice = new Label();
            lblFoodPrice = new Label();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            cboDrinks = new ComboBox();
            label3 = new Label();
            cboFood = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            btnPurchase = new Button();
            txtCash = new TextBox();
            lblTax = new Label();
            label9 = new Label();
            lblTotal = new Label();
            label7 = new Label();
            label6 = new Label();
            lblChange = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(608, 62);
            label1.TabIndex = 0;
            label1.Text = "BASIC ORDERING SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblDrinkPrice);
            panel1.Controls.Add(lblFoodPrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(cboDrinks);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cboFood);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(33, 124);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 284);
            panel1.TabIndex = 1;
            // 
            // lblDrinkPrice
            // 
            lblDrinkPrice.AutoSize = true;
            lblDrinkPrice.Location = new Point(90, 199);
            lblDrinkPrice.Name = "lblDrinkPrice";
            lblDrinkPrice.Size = new Size(27, 20);
            lblDrinkPrice.TabIndex = 10;
            lblDrinkPrice.Text = "---";
            // 
            // lblFoodPrice
            // 
            lblFoodPrice.AutoSize = true;
            lblFoodPrice.Location = new Point(90, 89);
            lblFoodPrice.Name = "lblFoodPrice";
            lblFoodPrice.Size = new Size(27, 20);
            lblFoodPrice.TabIndex = 9;
            lblFoodPrice.Text = "---";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 199);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 90);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(31, 232);
            button1.Name = "button1";
            button1.Size = new Size(186, 29);
            button1.TabIndex = 6;
            button1.Text = "VOID ORDER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cboDrinks
            // 
            cboDrinks.FormattingEnabled = true;
            cboDrinks.Items.AddRange(new object[] { "WATER WITH ICE", "COKE WITH COLA", "MOUNTAIN WITH DEW", "REDHORSE" });
            cboDrinks.Location = new Point(31, 159);
            cboDrinks.Name = "cboDrinks";
            cboDrinks.Size = new Size(190, 28);
            cboDrinks.TabIndex = 5;
            cboDrinks.SelectedIndexChanged += cboDrinks_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 124);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Drinks";
            // 
            // cboFood
            // 
            cboFood.FormattingEnabled = true;
            cboFood.Items.AddRange(new object[] { "CALDERETA", "SISIG", "ADOBONG LECHON", "ASADONG KANGKONG" });
            cboFood.Location = new Point(31, 49);
            cboFood.Name = "cboFood";
            cboFood.Size = new Size(190, 28);
            cboFood.TabIndex = 3;
            cboFood.SelectedIndexChanged += cboFood_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 17);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "Food";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblChange);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(btnPurchase);
            panel2.Controls.Add(txtCash);
            panel2.Controls.Add(lblTax);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(324, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 283);
            panel2.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 158);
            label8.Name = "label8";
            label8.Size = new Size(40, 20);
            label8.TabIndex = 17;
            label8.Text = "Cash";
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.FromArgb(0, 192, 0);
            btnPurchase.Enabled = false;
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.ForeColor = SystemColors.ButtonHighlight;
            btnPurchase.Location = new Point(40, 231);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(186, 29);
            btnPurchase.TabIndex = 11;
            btnPurchase.Text = "PURCHASE";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += button2_Click;
            // 
            // txtCash
            // 
            txtCash.Location = new Point(103, 151);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(123, 27);
            txtCash.TabIndex = 16;
            txtCash.TextChanged += txtCash_TextChanged;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Location = new Point(103, 105);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(27, 20);
            lblTax.TabIndex = 15;
            lblTax.Text = "---";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 105);
            label9.Name = "label9";
            label9.Size = new Size(30, 20);
            label9.TabIndex = 14;
            label9.Text = "Tax";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(103, 52);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(27, 20);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 52);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(103, 16);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 11;
            label6.Text = "Receipt";
            // 
            // lblChange
            // 
            lblChange.AutoSize = true;
            lblChange.Location = new Point(103, 198);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(27, 20);
            lblChange.TabIndex = 19;
            lblChange.Text = "---";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 198);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 18;
            label11.Text = "Change";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 468);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private ComboBox cboDrinks;
        private Label label3;
        private ComboBox cboFood;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label lblDrinkPrice;
        private Label lblFoodPrice;
        private Panel panel2;
        private Label label6;
        private Label lblTotal;
        private Label label7;
        private Label lblTax;
        private Label label9;
        private Button btnPurchase;
        private TextBox txtCash;
        private Label label8;
        private Label lblChange;
        private Label label11;
    }
}
