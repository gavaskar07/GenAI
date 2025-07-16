using System.Data;
using System.Text.RegularExpressions;

namespace PH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        dbutilities util = new dbutilities();
        private void button1_Click(object sender, EventArgs e)
        {
            gp_cp.Visible = true;
            string input = textBox1.Text;
            string pattern = "#[^#]+#"; // Matches three-letter words
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
            {
                // Console.WriteLine("Match found: " + match.Value);
                dg1.Rows.Add(match.Value);
            }
        }

        private void dg1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //cmd_save.Text = "Update";
            //cmd_delete.Enabled = true;
            //role_cmb.Text = "";
            //lb1_id.Text = grd_user.SelectedRows[0].Cells[0].Value.ToString();
            //user_name_txt.Text = grd_user.SelectedRows[0].Cells[1].Value.ToString();
            //user_password_txt.Text = grd_user.SelectedRows[0].Cells[2].Value.ToString();
            //role_cmb.SelectedText = grd_user.SelectedRows[0].Cells[3].Value.ToString();
            cmb_cp.Text = dg1.SelectedRows[0].Cells[0].Value.ToString();
            load_grid(dg1.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gp_cp.Visible = false;
        }
        private void load_grid(String value)
        {
            txt_cp.Text = "";
            DataSet login_ds = new DataSet();
            login_ds = util.load_dataset("select f2 from data where f1='" + value + "'");
            foreach (DataRow drow in login_ds.Tables[0].Rows)
            {
                txt_cp.Text = drow["f2"].ToString();
            }
        }

        private void cmb_cp_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_grid(cmb_cp.SelectedText);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String insert = util.iud("INSERT INTO data ( f1, f2) values ('"+ cmb_cp.Text+"','"+ rt_cr.Text+"')");
            if (insert == "sucess")
            {
                MessageBox.Show("Data updated Sucessfully");
            }
        }
    }
}
