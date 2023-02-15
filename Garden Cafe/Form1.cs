using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garden_Cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           double Caramel, Mocha, Chocolate, Vanilla, Matcha, SubTotal, VAT, FinalTotal;
            Caramel = Convert.ToDouble(textBox11.Text);
            Mocha = Convert.ToDouble(textBox14.Text);
            Chocolate = Convert.ToDouble(textBox16.Text);
            Vanilla = Convert.ToDouble(textBox18.Text);
            Matcha = Convert.ToDouble(textBox20.Text);
            SubTotal = Caramel + Mocha + Chocolate + Vanilla + Matcha;
            textBox1.Text = SubTotal.ToString();
            VAT = SubTotal * 0.10;
            textBox2.Text = VAT.ToString();
            FinalTotal = SubTotal + VAT;
            textBox3.Text = FinalTotal.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            int P, Amount1;
            P = Convert.ToInt32(textBox6.Text);
            Amount1 = P * 150;
            textBox11.Text = Amount1.ToString();
            textBox12.Text = "Caramel";
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            int P, Amount2;
            P = Convert.ToInt32(textBox7.Text);
            Amount2 = P * 140;
            textBox14.Text = Amount2.ToString();
            textBox13.Text = "Mocha";
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            int P, Amount3;
            P = Convert.ToInt32(textBox8.Text);
            Amount3 = P * 130;
            textBox16.Text = Amount3.ToString();
            textBox15.Text = "Chocolate";
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            int P, Amount4;
            P = Convert.ToInt32(textBox9.Text);
            Amount4 = P * 110;
            textBox18.Text = Amount4.ToString();
            textBox17.Text = "Vanilla";
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            int P, Amount5;
            P = Convert.ToInt32(textBox10.Text);
            Amount5 = P * 170;
            textBox20.Text = Amount5.ToString();
            textBox19.Text = "Matcha";
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            double paid, amount, change;
            paid = Convert.ToDouble(textBox4.Text);
            amount = Convert.ToDouble(textBox4.Text);
            change = paid - amount;
            textBox5.Text = change.ToString();
            if (paid >= amount)
                textBox21.Text = "Fully Paid";
            else
                textBox21.Text = "Please Settle your Amount";

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            double AmountPaid, FinalTotal, Change;
            AmountPaid = Convert.ToDouble(textBox4.Text);
            FinalTotal = Convert.ToDouble(textBox3.Text);
            Change = AmountPaid - FinalTotal;
            textBox5.Text = Change.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
       
    }
}
