using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignments_6._3
{
    public partial class Form1 : Form
    {
        // instance Q class to manage call Q
        private Q callQueue = new Q();
        
        // var for tracking current color on btnShow
        private int currentColorIndex = 0;
        // color array to swap between btnShow
        private Color[] colors = { Color.Red, Color.LightCoral };
        public Form1()
        {
            InitializeComponent();
            
            // add column name and phone number to datagrid
            dataCustomer.Columns.Add("Name", "Name");
            dataCustomer.Columns.Add("PhoneNumber", "Phone Number");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }

        private void btnEnq_Click(object sender, EventArgs e)
        {
            // check for empty string and default placeholder txt "Enter Name"
            if (txtName.Text == "" || txtName.Text == "Enter Name")
            {
                // error message if name not entered
                MessageBox.Show("Please enter customer name","Error");
            }
            // add customer to queue
            else
            {
                // store customer name entered by "call center operator" 
                string customerName = txtName.Text;
                // generate random phone number as the "customer is calling in"
                string phoneNumber = GeneratePhoneNumber();

                // create a new customer instance to enQ
                Customer customer = new Customer(customerName, phoneNumber);
                // enQ the customer into the call Q
                callQueue.Enqueue(customer);

                // add the customer to the datagrid display
                dataCustomer.Rows.Add(customer.Name, customer.PhoneNumber);
            }
            // clear the input field and reset appearance
            txtName.Text = "Enter Name";
            txtName.ForeColor = Color.Silver;
            txtName.Visible = false;
            btnEnq.Visible = false;
        }
        private void btnDeq_Click(object sender, EventArgs e)
        {
            // check current list of callers in the Q
            if (callQueue.Length > 0)
            {
                // dequeue the customer from the Q
                Customer customer = callQueue.Dequeue();

                // remove the customer from the datagrid display
                dataCustomer.Rows.RemoveAt(0);

                // show a message indicating return call to the customer
                MessageBox.Show($"Calling {customer.Name} : {customer.PhoneNumber}", "Return Call");
            }
            else
            {
                // display message box when Q is empty
                MessageBox.Show("Call queue is empty.", "Empty");
            }
        }
        private string GeneratePhoneNumber()
        {
            // generate new phone numbers using random method
            // split phone num in 3 sections **makes it easier to work around**
            Random phone = new Random();
            int areaCode = phone.Next(900, 1000); // keep it in the 900's
            int preFix = phone.Next(100, 1000);
            int lineNumber = phone.Next(1000, 10000);

            // format the phone number to display 1-000-000-0000
            string formatPhoneNumber = $"1-{areaCode:D3}-{preFix:D3}-{lineNumber:D4}";
            return formatPhoneNumber;
        }

        private void txtName_Click(object sender, EventArgs e)
        {
            // display black color when the "call center operator" inputs the customer name
            if (txtName.Text == "Enter Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Black;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // display text box and button to enqueue customer
            txtName.Visible = true;
            btnEnq.Visible = true;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // timer tick event to change text color on btnShow
        private void timer1_Tick(object sender, EventArgs e)
        {
            // set forecolor to colorindex
            btnShow.ForeColor = colors[currentColorIndex];

            // switch between colors in color array (0 1)
            currentColorIndex = (currentColorIndex + 1) % colors.Length;

        }
    }
}
