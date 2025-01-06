using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System.Data;

namespace DBMSNORTHWIND
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection;
        SqlDataAdapter da;
        SqlCommand cmd;
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = connectDB.ConnectNortwind();
            //if (connection.State ==  ConnectionState.Open ){ MessageBox.Show("connect Database complete", "Database Connect");}
            showdata();

        }

        private void showdata()
        {
            string sql = " select * from Shippers";
            cmd = new SqlCommand(sql, connection);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dvgShippers.DataSource = ds.Tables[0];
        }

        private void dvgShippers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            var s = dvgShippers.CurrentRow.Cells;
            tshipperID.Text = s[0].Value.ToString();
            tcompanyname.Text = s[1].Value.ToString();
            tphone.Text = s[2].Value.ToString();
        }

        private void ClearFrom()
        {
            tshipperID.Clear();
            tcompanyname.Clear();
            tphone.Clear();
            tcompanyname.Focus();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearFrom();
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            //ตรวจสอบข้อมูล
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
            if (n > 0)
            {
                showdata();
                ClearFrom();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //ตรวจสอบข้อมูล
            if (string.IsNullOrEmpty(tshipperID.Text))
            {
                MessageBox.Show("Chose shipper ID ", "Error");
                return;
            }
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
            if (n > 0)
            {
                showdata();
                ClearFrom();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete data ", "Confrim",MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            } 

            if (string.IsNullOrEmpty(tshipperID.Text))
            {
                MessageBox.Show("Select shipper ID ", "Error");
                return;
            }


            string sql = "Delete from Shippers  where ShipperID = @shipperID";
            cmd = new SqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@shipperID", tshipperID.Text);
            try
            {
            int n = cmd.ExecuteNonQuery();
            if (n > 0)
            {
                showdata();
                ClearFrom();
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + Environment.NewLine + ex.Message, "Error!!");
            }

        }
    }
}
