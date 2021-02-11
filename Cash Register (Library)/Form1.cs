using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register__Library_
{
    public partial class Form1 : Form
    {


        public Form1()
        {


            InitializeComponent();
        }

        //Global Variables
        double pricebovd = 4;
        int amountbovd;
        double pricecad = 11;
        int amountcad;
        double pricetds = 7;
        int amounttds;
        double subtotal;
        double tax = 0.13;
        double total;
        double tendered;
        double change;



        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                amountbovd = Convert.ToInt16(input1.Text);
                amountcad = Convert.ToInt16(input2.Text);
                amounttds = Convert.ToInt16(input3.Text);
            }
            catch
            {
                calculateButton.Text = "Please use correct values.";
            }



            subtotal = (amountbovd * pricebovd) + (amountcad * pricecad) + (amounttds * pricetds);
            tax = subtotal * 0.13;
            total = tax + subtotal;

            outputLabelSub.Text = $"{subtotal.ToString("C")}";
            outputLabelTax.Text = $"{tax.ToString("C")}";
            outputLabelTotal.Text = $"{total.ToString("C")}";
           




        }

        private void CalculateChange_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToInt32(input4.Text);
                change = tendered - total;
            }
            catch
            {
                outputLabelChange.Text = "Please use numbers.";
            }
            outputLabelChange.Text = $"{change.ToString("C")}";

        }

        private void ReceiptButton_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Metal_Gong_Dianakc_109711828);
            player.Play();

            receiptOutput.Text = "ACME INC.";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n\n Order # 563";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n Classified Date";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n\n Books of Vile Darkness:  x{amountbovd} @ {(pricebovd).ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n Cursed Artifact of Doom: x{amountcad} @ {(pricecad).ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n Tool of Dark Summoning:  x{amounttds} @ {(pricetds).ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n\n Subtotal:                     {subtotal.ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n Tax:                          {tax.ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n Total:                        {total.ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n\n Tendered:                     {tendered.ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n Change:                       {change.ToString("C")}";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();

            receiptOutput.Text += $"\n     We hope that our service was sufficient.";

            this.Refresh();
            Thread.Sleep(2000);

            player.Play();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            amountbovd = 0;
            amounttds = 0;
            amountcad = 0;
            subtotal = 0;
            total = 0;
            tendered = 0;
            change = 0;

            input1.Text = "";
            input2.Text = "";
            input3.Text = "";
            input4.Text = "";

           
  
           



        }
    }
}
