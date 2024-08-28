using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCrudApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please upload a photo before inserting.");
                return; 
            }

            SqlConnection con = new SqlConnection("Data Source=PRASAD_CHANDIMA\\SQLEXPRESS;Initial Catalog=crudForm;User ID=sa;password=123456;Encrypt=False");
            con.Open();
            try
            {
                
                SqlCommand cmd = new SqlCommand("insert into emp values(@empID,@Name,@Adress,@dob,@telno,@photo)", con);
                cmd.Parameters.AddWithValue("@empID", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@Name", textBox7.Text);
                cmd.Parameters.AddWithValue("@Adress", textBox8.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@telno", int.Parse(textBox10.Text));
                cmd.Parameters.AddWithValue("@photo", getPhoto());
                cmd.ExecuteNonQuery();
                

                MessageBox.Show("Successfully saved");

                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBox10.Clear();
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream,pictureBox1.Image.RawFormat);

            return stream.GetBuffer();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PRASAD_CHANDIMA\\SQLEXPRESS;Initial Catalog=crudForm;User ID=sa;password=123456;Encrypt=False");
            con.Open();


            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE emp SET Name=@Name, Adress=@Adress, dob=@dob, telno=@telno, photo=@photo WHERE empID=@empID", con);

                cmd.Parameters.AddWithValue("@empID", int.Parse(textBox6.Text));
                cmd.Parameters.AddWithValue("@Name", textBox7.Text);
                cmd.Parameters.AddWithValue("@Adress", textBox8.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@telno", int.Parse(textBox10.Text));
                cmd.Parameters.AddWithValue("@photo", getPhoto());

                cmd.ExecuteNonQuery();

                MessageBox.Show("Update Successful");

                //clear text boxes
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBox10.Clear();
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close(); 
            }
            LoadEmployeeIDs();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PRASAD_CHANDIMA\\SQLEXPRESS;Initial Catalog=crudForm;User ID=sa;password=123456;Encrypt=False");
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("delete emp where empID=@empID", con);
                cmd.Parameters.AddWithValue("@empID", int.Parse(textBox6.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Delete Successful");

                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBox10.Clear();
                pictureBox1.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            LoadEmployeeIDs();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PRASAD_CHANDIMA\\SQLEXPRESS;Initial Catalog=crudForm;User ID=sa;password=123456;Encrypt=False");
            con.Open();
            SqlCommand cmd;


            if (String.IsNullOrWhiteSpace(textBox6.Text))
            {
                cmd = new SqlCommand("select * from emp", con);
            }
            else
            {
                cmd = new SqlCommand("select * from emp where empID=@empID", con);
                cmd.Parameters.AddWithValue("@empID", int.Parse(textBox6.Text));
            }
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crudFormDataSet2.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter2.Fill(this.crudFormDataSet2.emp);
            this.empTableAdapter1.Fill(this.crudFormDataSet1.emp);
            this.empTableAdapter.Fill(this.crudFormDataSet.emp);

            LoadEmployeeIDs();

        }

        private void LoadEmployeeIDs()
        {
            SqlConnection con = new SqlConnection("Data Source=PRASAD_CHANDIMA\\SQLEXPRESS;Initial Catalog=crudForm;User ID=sa;password=123456;Encrypt=False");
            con.Open();
                
            SqlCommand cmd = new SqlCommand("SELECT empID FROM emp", con);
            SqlDataReader reader = cmd.ExecuteReader();

            comboBox1.Items.Clear();

            // "All" option
            comboBox1.Items.Add("All");

            // Populate the ComboBox with Employee IDs
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["empID"].ToString());
            }

            comboBox1.SelectedIndex = 0; 
           
            con.Close();
          
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() != "All")
            {
                LoadEmployeeData(comboBox1.SelectedItem.ToString());
            }
            else
            {
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                dateTimePicker1.Value = DateTime.Now;
                textBox10.Clear();
                pictureBox1.Image = null;
            }
        }

        private void LoadEmployeeData(string empID)
        {
            SqlConnection con = new SqlConnection("Data Source=PRASAD_CHANDIMA\\SQLEXPRESS;Initial Catalog=crudForm;User ID=sa;password=123456;Encrypt=False");

                con.Open();
                // Create a command to select employee details based on the employee ID
                SqlCommand cmd = new SqlCommand("SELECT * FROM emp WHERE empID = @empID", con);
                cmd.Parameters.AddWithValue("@empID", empID);

                SqlDataReader reader = cmd.ExecuteReader();

                // Check if data exists
                if (reader.Read())
                {
                    //Populate textboxes with the retrieved data
                    textBox6.Text = reader["empID"].ToString();
                    textBox7.Text = reader["Name"].ToString();
                    textBox8.Text = reader["Adress"].ToString();
                    dateTimePicker1.Value = DateTime.Parse(reader["dob"].ToString());
                    textBox10.Text = reader["telno"].ToString();

                    //Assuming that the photo is stored as a byte array in the database
                    byte[] photoBytes = (byte[])reader["photo"];
                    MemoryStream stream = new MemoryStream(photoBytes);
                    pictureBox1.Image = Image.FromStream(stream);
                }
                else
                {
                    MessageBox.Show("No data found for the selected Employee ID.");
                }

                reader.Close();
                con.Close();
            
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
