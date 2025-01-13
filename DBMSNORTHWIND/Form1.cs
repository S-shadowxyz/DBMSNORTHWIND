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

        int ShipperID = 0;
        String companyName = string.Empty;
        String phone = string.Empty;

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
            ShipperID = Convert.ToInt32(dvgShippers.CurrentRow.Cells[0].Value);
            companyName = dvgShippers.CurrentRow.Cells[1].Value.ToString();
            phone = dvgShippers.CurrentRow.Cells[2].Value.ToString();
            //var s = dvgShippers.CurrentRow.Cells;
            //tshipperID.Text = s[0].Value.ToString();
            //tcompanyname.Text = s[1].Value.ToString();
            //tphone.Text = s[2].Value.ToString();

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
            FRMshippers f = new FRMshippers();
            f.status = "insert";
            f.ShowDialog();
            showdata();
            ////ตรวจสอบข้อมูล
            //if (string.IsNullOrEmpty(tcompanyname.Text))
            //{
            //    MessageBox.Show("input Company name ", "Error");
            //    return;
            //}

            //string sql = "Insert into Shippers Values(@companyName,@phone)";
            //cmd = new SqlCommand(sql, connection);
            //cmd.Parameters.AddWithValue("@CompanyName", tcompanyname.Text.Trim());
            //cmd.Parameters.AddWithValue("@phone", tphone.Text.Trim());
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    showdata();
            //    ClearFrom();
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {


            ////ตรวจสอบข้อมูล
            if (ShipperID <= 0)
            {
                MessageBox.Show("Chose shipper ID ", "Error");
                return;
            }
            FRMshippers f = new FRMshippers();
            f.status = "update";
            f.ShipperID = ShipperID;
            f.companyName = companyName;
            f.Phone = phone;
            f.ShowDialog();
            showdata();
            //if (string.IsNullOrEmpty(tcompanyname.Text))
            //{
            //    MessageBox.Show("input Company name ", "Error");
            //    return;
            //}

            //string sql = "UPDATE Shippers set  CompanyName = @companyName, phone = @phone where ShipperID = @shipperID";
            //cmd = new SqlCommand(sql, connection);
            //cmd.Parameters.AddWithValue("@CompanyName", tcompanyname.Text.Trim());
            //cmd.Parameters.AddWithValue("@phone", tphone.Text.Trim());
            //cmd.Parameters.AddWithValue("@shipperID", tshipperID.Text);
            //int n = cmd.ExecuteNonQuery();
            //if (n > 0)
            //{
            //    showdata();
            //    ClearFrom();
            //}
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = " Shipper ID : " + ShipperID.ToString() + Environment.NewLine;
            msg += " Company name :" + companyName;
            msg += "Phone :" + phone;

            if (MessageBox.Show("Delete data ", "Confrim", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (ShipperID <= 0)
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
                    //ClearFrom();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + Environment.NewLine + ex.Message, "Error!!");
            }

        }

        private void dvgShippers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEdit.PerformClick();
        }
    }
}
