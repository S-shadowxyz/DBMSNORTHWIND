using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSNORTHWIND
{
    public partial class FRMshippers : Form
    {
        public FRMshippers()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;

        public int ShipperID { get; set; }
        public String companyName { get; set; }
        public String Phone { get; set; }
        public String status { get; set; }


        private void FRMshippers_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();
            tshipperID.Text = ShipperID.ToString();
            tcompanyname.Text = companyName ?? string.Empty;
            tphone.Text = Phone ?? string.Empty;
            tcompanyname.Focus();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (status == "insert")
            {
                insertShippers();
            }
            else if (status == "update")
            {
                UpdateShippers();
            }
            this.Close();
        }

        private void UpdateShippers()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");
            if (string.IsNullOrEmpty(tcompanyname.Text))
            {
                MessageBox.Show("input Company name ", "Error");
                return;
            }
            string sql = "UPDATE Shippers set  CompanyName = @companyName, phone = @phone where ShipperID = @shipperID";
            cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@CompanyName", tcompanyname.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", tphone.Text.Trim());
            cmd.Parameters.AddWithValue("@shipperID", tshipperID.Text);
            int n = cmd.ExecuteNonQuery();
        }

        private void insertShippers()
        {
            MessageBox.Show("เพิ่มข้อมูล");
            if (string.IsNullOrEmpty(tcompanyname.Text))
            {
                MessageBox.Show("input Company name ", "Error");
                return;
            }

            string sql = "Insert into Shippers Values(@companyName,@phone)";
            cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@CompanyName", tcompanyname.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", tphone.Text.Trim());
            int n = cmd.ExecuteNonQuery();
        }
    }
}
