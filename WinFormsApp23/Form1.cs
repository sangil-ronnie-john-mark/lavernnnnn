namespace WinFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculateTotal()
        {
            double num1 = 0;
            double num2 = 0;
            try
            {
                num1 = double.Parse(lblFoodPrice.Text);
            }
            catch (Exception ex)
            {
                num1 = 0;
            }

            try
            {
                num2 = double.Parse(lblDrinkPrice.Text);
            }
            catch (Exception ex)
            {
                num2 = 0;
            }

            double total = num1 + num2;
            lblTotal.Text = total.ToString();
            lblTax.Text = (total * 0.12).ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            cboDrinks.Text = "";
            cboFood.Text = "";
            lblFoodPrice.Text = "---";
            lblDrinkPrice.Text = "---";
            lblTotal.Text = "---";
            lblTax.Text = "---";
            txtCash.Text = "";
            lblChange.Text = string.Empty;
        }

        private void cboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFood.Text == "CALDERETA")
            {
                lblFoodPrice.Text = "60";
            }
            else if (cboFood.Text == "SISIG")
            {
                lblFoodPrice.Text = "25";
            }
            else if (cboFood.Text == "ADOBONG LECHON")
            {
                lblFoodPrice.Text = "99";
            }
            else if (cboFood.Text == "ASADONG KANGKONG")
            {
                lblFoodPrice.Text = "20";
            }
            calculateTotal();
        }

        private void cboDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDrinks.Text)
            {
                case "WATER WITH ICE":
                    lblDrinkPrice.Text = "10";
                    break;

                case "COKE WITH COLA":
                    lblDrinkPrice.Text = "20.5";
                    break;


                case "MOUNTAIN WITH DEW":
                    lblDrinkPrice.Text = "30";
                    break;


                case "REDHORSE":
                    lblDrinkPrice.Text = "40";
                    break;

            }
            calculateTotal();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = double.Parse(lblTotal.Text);
            double cash = double.Parse(txtCash.Text);

            double change = cash - total;
            lblChange.Text = change.ToString();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            double total = double.Parse(lblTotal.Text);
            double cash = double.Parse(txtCash.Text)
            if (cash >= total) {
            btnPurchase.Enabled = true;
            } else
            {
                btnPurchase.Enabled = false;
            }
        }
    }
}
