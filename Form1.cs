using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Pizza
{
    public partial class Form1 : Form
    {
        private float _SizeSalary = 0;
        private float _ToppingsSalary = 0;
        private float _CrustTypeSalary = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private float CalculateSalary()
        {
            return _SizeSalary + _ToppingsSalary + _CrustTypeSalary;
        }
        private void UpdateSalary()
        {
            lblSalary.Text = "$" + CalculateSalary().ToString();
        }
        private void Size_CheckedChanged(object sender, EventArgs e)
        {
            _SizeSalary = 0;
            if (rbtSmall.Checked) { _SizeSalary = Convert.ToSingle(rbtSmall.Tag); lblSize.Text = rbtSmall.Text; }
            else if (rbtMeduim.Checked) { _SizeSalary = Convert.ToSingle(rbtMeduim.Tag); lblSize.Text = rbtMeduim.Text; }
            else if (rbtLarg.Checked) { _SizeSalary = Convert.ToSingle(rbtLarg.Tag); lblSize.Text = rbtLarg.Text; }
            UpdateSalary();
        }
        private void CrustType_CheckedChanged(object sender, EventArgs e)
        {
            _CrustTypeSalary = 0;
            if (rbtThin.Checked) { _CrustTypeSalary = Convert.ToSingle(rbtThin.Tag); lblThin.Text = rbtThin.Text; }
            else if (rbtThick.Checked) { _CrustTypeSalary = Convert.ToSingle(rbtThick.Tag); lblThin.Text = rbtThick.Text; }
            UpdateSalary();
        }
        private void WhereToEat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtIn.Checked) { lblWhere.Text = rbtIn.Text; }
            else if (rbtOut.Checked) { lblWhere.Text = rbtOut.Text; }
        }
        private void Toppings_CheckedChanged(object sender, EventArgs e)
        {
            _ToppingsSalary = 0;
            StringBuilder Toppings = new StringBuilder();
            if (chExtra.Checked) { _ToppingsSalary += Convert.ToSingle(chExtra.Tag); Toppings.Append(chExtra.Text); }
            if (chMush.Checked) { _ToppingsSalary += Convert.ToSingle(chMush.Tag); Toppings.Append(", " + chMush.Text); }
            if (chTomatoes.Checked) { _ToppingsSalary += Convert.ToSingle(chTomatoes.Tag); Toppings.Append(", " + chTomatoes.Text); }
            if (chOnion.Checked) { _ToppingsSalary += Convert.ToSingle(chOnion.Tag); Toppings.Append(", " + chOnion.Text); }
            if (chOlives.Checked) { _ToppingsSalary += Convert.ToSingle(chOlives.Tag); Toppings.Append(", " + chOlives.Text); }
            if (chGreen.Checked) { _ToppingsSalary += Convert.ToSingle(rbtThick.Tag); Toppings.Append(", " + chGreen.Text); }
            if (Toppings.ToString().StartsWith(",")) lblToppings.Text = Toppings.ToString().Substring(1, Toppings.Length - 1);
            else if (Toppings.Length == 0) lblToppings.Text = "No Toppings";
            else lblToppings.Text = Toppings.ToString();
            UpdateSalary();
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            btOrder.Enabled = true;

            rbtSmall.Checked = true;
            rbtThin.Checked = true;
            rbtIn.Checked = true;

            chExtra.Checked = false;
            chMush.Checked = false;
            chTomatoes.Checked = false;
            chOnion.Checked = false;
            chOlives.Checked = false;
            chGreen.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rbtSmall.Checked = true;
            rbtThin.Checked = true;
            rbtIn.Checked = true;
        }
        private void btOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order.", "Confirm", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gbSize.Enabled = false;
                gbCrust.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
            else MessageBox.Show("Update Your Order.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
