namespace Djeciji_vrtic
{
    partial class Grupe
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxVaspitaci = new System.Windows.Forms.ComboBox();
            this.Izlistaj = new FontAwesome.Sharp.IconButton();
            this.dataGridViewGrupa = new System.Windows.Forms.DataGridView();
            this.Izbrisi = new FontAwesome.Sharp.IconButton();
            this.Pretrazi = new FontAwesome.Sharp.IconButton();
            this.Unesi = new FontAwesome.Sharp.IconButton();
            this.textBoxBrojPolaznika = new System.Windows.Forms.TextBox();
            this.textBoxImeGrupe = new System.Windows.Forms.TextBox();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBoxVaspitaci);
            this.panel1.Controls.Add(this.Izlistaj);
            this.panel1.Controls.Add(this.dataGridViewGrupa);
            this.panel1.Controls.Add(this.Izbrisi);
            this.panel1.Controls.Add(this.Pretrazi);
            this.panel1.Controls.Add(this.Unesi);
            this.panel1.Controls.Add(this.textBoxBrojPolaznika);
            this.panel1.Controls.Add(this.textBoxImeGrupe);
            this.panel1.Controls.Add(this.iconPictureBox3);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1298, 602);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxVaspitaci
            // 
            this.comboBoxVaspitaci.FormattingEnabled = true;
            this.comboBoxVaspitaci.Location = new System.Drawing.Point(235, 305);
            this.comboBoxVaspitaci.Name = "comboBoxVaspitaci";
            this.comboBoxVaspitaci.Size = new System.Drawing.Size(240, 24);
            this.comboBoxVaspitaci.TabIndex = 53;
            // 
            // Izlistaj
            // 
            this.Izlistaj.AutoSize = true;
            this.Izlistaj.BackColor = System.Drawing.Color.White;
            this.Izlistaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Izlistaj.FlatAppearance.BorderSize = 0;
            this.Izlistaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izlistaj.IconChar = FontAwesome.Sharp.IconChar.List;
            this.Izlistaj.IconColor = System.Drawing.Color.Black;
            this.Izlistaj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Izlistaj.Location = new System.Drawing.Point(531, 64);
            this.Izlistaj.Name = "Izlistaj";
            this.Izlistaj.Size = new System.Drawing.Size(54, 54);
            this.Izlistaj.TabIndex = 52;
            this.Izlistaj.UseVisualStyleBackColor = false;
            this.Izlistaj.Click += new System.EventHandler(this.Izlistaj_Click);
            // 
            // dataGridViewGrupa
            // 
            this.dataGridViewGrupa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupa.Location = new System.Drawing.Point(602, 51);
            this.dataGridViewGrupa.Name = "dataGridViewGrupa";
            this.dataGridViewGrupa.RowHeadersWidth = 51;
            this.dataGridViewGrupa.RowTemplate.Height = 24;
            this.dataGridViewGrupa.Size = new System.Drawing.Size(667, 492);
            this.dataGridViewGrupa.TabIndex = 51;
            this.dataGridViewGrupa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGrupa_CellDoubleClick);
            // 
            // Izbrisi
            // 
            this.Izbrisi.AutoSize = true;
            this.Izbrisi.BackColor = System.Drawing.Color.White;
            this.Izbrisi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Izbrisi.FlatAppearance.BorderSize = 0;
            this.Izbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Izbrisi.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.Izbrisi.IconColor = System.Drawing.Color.Black;
            this.Izbrisi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Izbrisi.Location = new System.Drawing.Point(380, 421);
            this.Izbrisi.Name = "Izbrisi";
            this.Izbrisi.Size = new System.Drawing.Size(54, 54);
            this.Izbrisi.TabIndex = 50;
            this.Izbrisi.UseVisualStyleBackColor = false;
            this.Izbrisi.Click += new System.EventHandler(this.Izbrisi_Click);
            // 
            // Pretrazi
            // 
            this.Pretrazi.AutoSize = true;
            this.Pretrazi.BackColor = System.Drawing.Color.White;
            this.Pretrazi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Pretrazi.FlatAppearance.BorderSize = 0;
            this.Pretrazi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pretrazi.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Pretrazi.IconColor = System.Drawing.Color.Black;
            this.Pretrazi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pretrazi.Location = new System.Drawing.Point(494, 289);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(54, 54);
            this.Pretrazi.TabIndex = 49;
            this.Pretrazi.UseVisualStyleBackColor = false;
            this.Pretrazi.Click += new System.EventHandler(this.Pretrazi_Click);
            // 
            // Unesi
            // 
            this.Unesi.AutoSize = true;
            this.Unesi.BackColor = System.Drawing.Color.White;
            this.Unesi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Unesi.FlatAppearance.BorderSize = 0;
            this.Unesi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Unesi.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Unesi.IconColor = System.Drawing.Color.Black;
            this.Unesi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Unesi.Location = new System.Drawing.Point(310, 421);
            this.Unesi.Name = "Unesi";
            this.Unesi.Size = new System.Drawing.Size(54, 54);
            this.Unesi.TabIndex = 48;
            this.Unesi.UseVisualStyleBackColor = false;
            this.Unesi.Click += new System.EventHandler(this.Unesi_Click);
            // 
            // textBoxBrojPolaznika
            // 
            this.textBoxBrojPolaznika.Location = new System.Drawing.Point(235, 246);
            this.textBoxBrojPolaznika.Name = "textBoxBrojPolaznika";
            this.textBoxBrojPolaznika.Size = new System.Drawing.Size(240, 22);
            this.textBoxBrojPolaznika.TabIndex = 46;
            // 
            // textBoxImeGrupe
            // 
            this.textBoxImeGrupe.Location = new System.Drawing.Point(224, 197);
            this.textBoxImeGrupe.Name = "textBoxImeGrupe";
            this.textBoxImeGrupe.Size = new System.Drawing.Size(240, 22);
            this.textBoxImeGrupe.TabIndex = 45;
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconPictureBox3.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 45;
            this.iconPictureBox3.Location = new System.Drawing.Point(51, 295);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(52, 45);
            this.iconPictureBox3.TabIndex = 44;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 45;
            this.iconPictureBox2.Location = new System.Drawing.Point(52, 238);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(52, 45);
            this.iconPictureBox2.TabIndex = 43;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdBadge;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 45;
            this.iconPictureBox1.Location = new System.Drawing.Point(52, 183);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(52, 45);
            this.iconPictureBox1.TabIndex = 42;
            this.iconPictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Vaspitač";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Broj polaznika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Ime grupe";
            // 
            // Grupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 602);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grupe";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Grupe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxBrojPolaznika;
        private System.Windows.Forms.TextBox textBoxImeGrupe;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Izbrisi;
        private FontAwesome.Sharp.IconButton Pretrazi;
        private FontAwesome.Sharp.IconButton Unesi;
        private FontAwesome.Sharp.IconButton Izlistaj;
        private System.Windows.Forms.DataGridView dataGridViewGrupa;
        private System.Windows.Forms.ComboBox comboBoxVaspitaci;
    }
}