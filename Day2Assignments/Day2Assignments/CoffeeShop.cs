using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2Assignments
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void CoffeeShop_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            string name = nameTextBox.Text;
            string contactNo = contactNoTextBox.Text;
            string address = addressTextBox.Text;
            string order = orderComboBox.Text;
            int quantity = Convert.ToInt32(quantityTextBox.Text);
            int price=0;


            if(order == "Black-120"){
                 price = quantity*120;
            }
            else if (order == "Cold-100")
            {
                price = quantity * 100;
            }
            else if (order == "Hot-90")
            {
                price = quantity * 90;
            }
            else if (order == "Regular-80")
            {
                price = quantity * 80;
            }
            
            richTextBox.Text = "\n Customer Name: "+ name +"\n\n Contact No: "+ contactNo +
                               "\n\n Address: "+ address +"\n\n Order: " +order +
                               "\n\n Quantity: "+ quantity +"\n\n Total Price: "+ price.ToString();

        }


       
    }
}
