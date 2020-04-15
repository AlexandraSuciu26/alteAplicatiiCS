using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace lab2
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        private DataSet ds = new DataSet();
        private SqlDataAdapter da1 = new SqlDataAdapter();
        private SqlDataAdapter da2 = new SqlDataAdapter();
        Dictionary<string, TextBox> textBoxes;
        List<Label> labels;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadParent();
            loadChild();
            initLabelAndTextBox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != dataGridView1.NewRowIndex)
                {
                    foreach (var textBox in textBoxes)
                    {
                        textBox.Value.Clear();
                    }
                    textBoxes[ConfigurationManager.AppSettings["fk"]].Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    loadChild();
                }
                else
                {
                    MessageBox.Show("Selecteaza idSite sau idDescriere");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow.Index != dataGridView2.NewRowIndex)
                {
                    int i = dataGridView2.CurrentRow.Index;
                    int count = 0;
                    foreach (var textBox in textBoxes)
                    {
                        textBox.Value.Text = dataGridView2[count, i].Value.ToString();
                        count++;
                    }
                }
                else
                {
                    MessageBox.Show("Selecteaza copil");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void initLabelAndTextBox()
        {
            textBoxes = new Dictionary<string, TextBox>();
            labels = new List<Label>();
            int noCol = ds.Tables["Decoratiune"].Columns.Count;
            for (int i = 0; i < noCol; i++)
            {
                Label label = new Label();
                label.Text = ds.Tables["Decoratiune"].Columns[i].ColumnName;

                Point textP = new Point(80 + 230 * (i % 3), 228 + 22 * (i / 3));
                Point labelP = new Point(10 + 230 * (i % 3), 228 + 22 * (i / 3));
                label.Location = labelP;
                label.AutoSize = true;

                TextBox textBox = new TextBox();
                textBox.Location = textP;
                textBoxes.Add(label.Text, textBox);
                labels.Add(label);

                this.Controls.Add(label);
                this.Controls.Add(textBox);

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    da2.InsertCommand = new SqlCommand(ConfigurationManager.AppSettings["InsertChild"], connection);
                    foreach (var textBox in textBoxes)
                    {
                        da2.InsertCommand.Parameters.AddWithValue(textBox.Key, textBox.Value.Text);
                    }

                    da2.InsertCommand.ExecuteNonQuery();
                    
                    loadChild();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    var command = ConfigurationManager.AppSettings["DeleteChild"];
                    da2.DeleteCommand = new SqlCommand(command, connection);
                    da2.DeleteCommand.Parameters.AddWithValue("@id", dataGridView2.CurrentRow.Cells[ConfigurationManager.AppSettings["idDecoratiune"]].Value);
                    da2.DeleteCommand.ExecuteNonQuery();
                    loadChild();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    da2.UpdateCommand = new SqlCommand(ConfigurationManager.AppSettings["UpdateChild"], connection);
                    foreach (var textBox in textBoxes)
                    {
                        da2.UpdateCommand.Parameters.AddWithValue(textBox.Key, textBox.Value.Text);
                    }

                    da2.UpdateCommand.ExecuteNonQuery();
                    loadChild();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void loadParent()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var select = ConfigurationManager.AppSettings["SelectParent"];
                    da1.SelectCommand = new SqlCommand(select, connection);
                    da1.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadChild()
        {
            if (ds.Tables["Decoratiune"] != null)
                ds.Tables["Decoratiune"].Clear();
            int id= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    var select = ConfigurationManager.AppSettings["SelectChild"];
                    da2.SelectCommand = new SqlCommand(select, connection);
                    da2.SelectCommand.Parameters.AddWithValue("@id", id);
                    da2.Fill(ds, "Decoratiune");
                    dataGridView2.DataSource = ds.Tables["Decoratiune"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       
    }

}
