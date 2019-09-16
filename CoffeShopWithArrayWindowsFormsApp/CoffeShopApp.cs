using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeShopWithArrayWindowsFormsApp
{
    public partial class coffeShopForm : Form
    {
        public coffeShopForm()
        {
            InitializeComponent();
        }

        int count = 0;
        string result = "";
        const int size = 3;

        string[] customerName = new string[size];
        string[] contactNo = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        double[] coffeCost = new double[size];

        private void saveButton_Click(object sender, EventArgs e)
        {

            if (count < size)
            {
                if (customerNameTextBox.Text == "" || contactNoTextBox.Text == "" || addressTextBox.Text == ""
                    || orderComboBox.Text == "" || quantityTextBox.Text == "")
                {
                    MessageBox.Show("Please, Field Out this field.Every field is required information.");
                }
                else
                {
                    try
                    {
                        customerName[count] = customerNameTextBox.Text;
                        contactNo[count] = contactNoTextBox.Text;
                        address[count] = addressTextBox.Text;
                        order[count] = orderComboBox.Text;

                        quantity[count] = Convert.ToInt32(quantityTextBox.Text);
                        if (order[count] == "Black-120")
                        {
                            coffeCost[count] = quantity[count] * 120;
                        }
                        else if (order[count] == "Cold-100")
                        {
                            coffeCost[count] = quantity[count] * 100;
                        }
                        else if (order[count] == "Hot-90")
                        {
                            coffeCost[count] = quantity[count] * 90;
                        }
                        else
                        {
                            coffeCost[count] = quantity[count] * 80;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Quantity field required  numeric value: ");
                        quantityTextBox.Text = "";
                    }

                    count++;
                    Clear();
                }
            }
            else
            {
                MessageBox.Show("Array is full..");
            }
            Clear();


            if (count == size)
            {
                for (int i = 0; i < size; i++)
                {
                    result += "Custome Name:   " + customerName[i] + "\nContact Number:   " + contactNo[i]
                              + "\nAddress:   " + address[i] + "\nOrder:   " + order[i] + "\nQuantity:   "
                              + quantity[i] +"\nUnit Price:   "+ coffeCost[i]/ quantity[i]+"" +
                              "\nTotal Price:   "+ coffeCost[i]+"\n\n";
                }

                showAllRichTextBox.Text = result;
                count++;
            }


        }

        private void Clear()
        {
            customerNameTextBox.Clear();
            contactNoTextBox.Clear();
            addressTextBox.Clear();
            orderComboBox.Text = "";
            contactNoTextBox.Clear();
            quantityTextBox.Clear();
        }

    }
}
