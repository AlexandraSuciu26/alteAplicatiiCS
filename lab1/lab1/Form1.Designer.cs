namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxProvenienta = new System.Windows.Forms.TextBox();
            this.textBoxMaterial = new System.Windows.Forms.TextBox();
            this.textBoxSite = new System.Windows.Forms.TextBox();
            this.textBoxDescriere = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(204, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickParinte);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 220);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(702, 193);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clickFiu);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(259, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(403, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Provenienta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(403, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Site";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(403, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descriere";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(499, 9);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 12;
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(499, 43);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 20);
            this.textBoxNume.TabIndex = 13;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(499, 70);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(100, 20);
            this.textBoxPret.TabIndex = 14;
            // 
            // textBoxProvenienta
            // 
            this.textBoxProvenienta.Location = new System.Drawing.Point(499, 103);
            this.textBoxProvenienta.Name = "textBoxProvenienta";
            this.textBoxProvenienta.Size = new System.Drawing.Size(100, 20);
            this.textBoxProvenienta.TabIndex = 15;
            // 
            // textBoxMaterial
            // 
            this.textBoxMaterial.Location = new System.Drawing.Point(499, 135);
            this.textBoxMaterial.Name = "textBoxMaterial";
            this.textBoxMaterial.Size = new System.Drawing.Size(100, 20);
            this.textBoxMaterial.TabIndex = 16;
            // 
            // textBoxSite
            // 
            this.textBoxSite.Location = new System.Drawing.Point(499, 165);
            this.textBoxSite.Name = "textBoxSite";
            this.textBoxSite.Size = new System.Drawing.Size(100, 20);
            this.textBoxSite.TabIndex = 17;
            // 
            // textBoxDescriere
            // 
            this.textBoxDescriere.Location = new System.Drawing.Point(499, 194);
            this.textBoxDescriere.Name = "textBoxDescriere";
            this.textBoxDescriere.Size = new System.Drawing.Size(100, 20);
            this.textBoxDescriere.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(615, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sunt intre 1 si 5 siteuri disponibile";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(615, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sunt intre 1 si 6 descrieri disponibile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxDescriere);
            this.Controls.Add(this.textBoxSite);
            this.Controls.Add(this.textBoxMaterial);
            this.Controls.Add(this.textBoxProvenienta);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxProvenienta;
        private System.Windows.Forms.TextBox textBoxMaterial;
        private System.Windows.Forms.TextBox textBoxSite;
        private System.Windows.Forms.TextBox textBoxDescriere;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

