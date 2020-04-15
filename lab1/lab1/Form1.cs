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

namespace lab1
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=DESKTOP-HN0UKT6\SQLDEVELOPER;Database=Anul2Sem2SGBDLab1;Integrated Security=True";
        DataSet ds = new DataSet();
        SqlDataAdapter adapter1 = new SqlDataAdapter();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                {
                    connection.Open();
                    MessageBox.Show(connection.State.ToString());
                    adapter1.SelectCommand = new SqlCommand("SELECT * FROM SiteVanzari;", connection);//umplem gridView cu datele din sql
                    adapter1.Fill(ds, "SiteVanzari");//setam numele Cosmetice pt tabelul care se va crea aici
                    dataGridView1.DataSource = ds.Tables["SiteVanzari"];//legam gridView cu tabelul din sql
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }

        }
        private void Form1_Load_2(int id)
        {

            if (ds.Tables["Decoratiune"] != null)
                ds.Tables["Decoratiune"].Clear();
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    adapter2.SelectCommand = new SqlCommand("SELECT * FROM Decoratiune WHERE fk_Site = @id; ", connection);
                    adapter2.SelectCommand.Parameters.AddWithValue("@id", id);
                    adapter2.Fill(ds, "Decoratiune");
                    dataGridView2.DataSource = ds.Tables["Decoratiune"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void clickParinte(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedCells[0].Value is int)
                {
                    int id = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
                    textBoxSite.Text = id.ToString();
                    Form1_Load_2(id);
                }
                else
                {
                    MessageBox.Show("Selecteaza idSite!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    
                    string nume = textBoxNume.Text;
                    int pret = int.Parse(textBoxPret.Text);
                    string provenienta = textBoxProvenienta.Text;
                    string material = textBoxMaterial.Text;
                    int site = int.Parse(textBoxSite.Text);
                    int descriere = int.Parse(textBoxDescriere.Text);
                    
                    adapter2.SelectCommand= new SqlCommand("INSERT INTO Decoratiune " +
                        "(nume,pret,provenienta,material,fk_Site,fk_Descriere) VALUES (@nume, @pret, @provenienta, @material, @fk_Site,@fk_Descriere); ", connection);
                    
                    adapter2.SelectCommand.Parameters.AddWithValue("@nume", nume);
                    adapter2.SelectCommand.Parameters.AddWithValue("@pret", pret);
                    adapter2.SelectCommand.Parameters.AddWithValue("@provenienta", provenienta);
                    adapter2.SelectCommand.Parameters.AddWithValue("@material", material);
                    adapter2.SelectCommand.Parameters.AddWithValue("@fk_Site", site);
                    adapter2.SelectCommand.Parameters.AddWithValue("@fk_Descriere", descriere);
                    dataGridView2.DataSource = ds.Tables["Decoratiune"];

                    int insertRowCount = adapter2.SelectCommand.ExecuteNonQuery();
                    Console.WriteLine($"Nr de inreg inserate: {insertRowCount}");
                    Form1_Load_2(site);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();
                    int id1 = int.Parse(textBoxId.Text);
                    int id2 = int.Parse(textBoxSite.Text);
                    adapter2.SelectCommand = new SqlCommand("DELETE FROM Decoratiune WHERE " +
                                "idDecoratiune=@id1;", connection);

                    adapter2.SelectCommand.Parameters.AddWithValue("@id1", id1);

                    int deleteRowCount = adapter2.SelectCommand.ExecuteNonQuery();
                    Console.WriteLine($"Nr de inregistrari sterse: {deleteRowCount}");
                    Form1_Load_2(id2);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                {

                    connection.Open();

                    int id = int.Parse(textBoxId.Text);
                    string nume = textBoxNume.Text;
                    int pret = int.Parse(textBoxPret.Text);
                    string provenienta = textBoxProvenienta.Text;
                    string material = textBoxMaterial.Text;
                    int site = int.Parse(textBoxSite.Text);
                    int descriere = int.Parse(textBoxDescriere.Text);
                    
                    adapter2.SelectCommand= new SqlCommand("UPDATE Decoratiune SET nume=@nume, pret=@pret, " +
                        "provenienta=@provenienta, material=@material, fk_Site=@site ,fk_Descriere=@descriere " +
                        "WHERE idDecoratiune=@id", connection);
                    
                    adapter2.SelectCommand.Parameters.AddWithValue("@id", id);
                    adapter2.SelectCommand.Parameters.AddWithValue("@nume", nume);
                    adapter2.SelectCommand.Parameters.AddWithValue("@pret", pret);
                    adapter2.SelectCommand.Parameters.AddWithValue("@provenienta", provenienta);
                    adapter2.SelectCommand.Parameters.AddWithValue("@material", material);
                    adapter2.SelectCommand.Parameters.AddWithValue("@site", site);
                    adapter2.SelectCommand.Parameters.AddWithValue("@descriere", descriere);

                    int modificaRowCount = adapter2.SelectCommand.ExecuteNonQuery();
                    Console.WriteLine($"Nr de inregistrari modificate: {modificaRowCount}");
                    Form1_Load_2(site);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clickFiu(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView2.SelectedCells[0].Value is int & e.ColumnIndex.ToString() == "0")
                {
                    int r = e.RowIndex;
                    textBoxId.Text = dataGridView2[0, r].Value.ToString();
                    textBoxNume.Text= dataGridView2[1, r].Value.ToString();
                    textBoxPret.Text = dataGridView2[2, r].Value.ToString();
                    textBoxProvenienta.Text = dataGridView2[3, r].Value.ToString();
                    textBoxMaterial.Text= dataGridView2[4, r].Value.ToString();
                    textBoxSite.Text = dataGridView2[5, r].Value.ToString();
                    textBoxDescriere.Text= dataGridView2[6, r].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Selecteaza idDecoratiune!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}
