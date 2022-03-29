namespace Djeciji_vrtic
{
    partial class Djeciji_vrtic
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
            this.menuBar = new System.Windows.Forms.Panel();
            this.Uplate = new System.Windows.Forms.Button();
            this.Grupe = new System.Windows.Forms.Button();
            this.Zaposleni = new System.Windows.Forms.Button();
            this.Polaznici = new System.Windows.Forms.Button();
            this.ChildForm = new System.Windows.Forms.Panel();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(174)))), ((int)(((byte)(80)))));
            this.menuBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuBar.Controls.Add(this.Uplate);
            this.menuBar.Controls.Add(this.Grupe);
            this.menuBar.Controls.Add(this.Zaposleni);
            this.menuBar.Controls.Add(this.Polaznici);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1483, 79);
            this.menuBar.TabIndex = 0;
            // 
            // Uplate
            // 
            this.Uplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(183)))), ((int)(((byte)(93)))));
            this.Uplate.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Uplate.Location = new System.Drawing.Point(329, 11);
            this.Uplate.Name = "Uplate";
            this.Uplate.Size = new System.Drawing.Size(100, 55);
            this.Uplate.TabIndex = 3;
            this.Uplate.Text = "Uplate";
            this.Uplate.UseVisualStyleBackColor = false;
            this.Uplate.Click += new System.EventHandler(this.Uplate_Click);
            // 
            // Grupe
            // 
            this.Grupe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(183)))), ((int)(((byte)(93)))));
            this.Grupe.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grupe.Location = new System.Drawing.Point(223, 11);
            this.Grupe.Name = "Grupe";
            this.Grupe.Size = new System.Drawing.Size(100, 55);
            this.Grupe.TabIndex = 2;
            this.Grupe.Text = "Grupe";
            this.Grupe.UseVisualStyleBackColor = false;
            this.Grupe.Click += new System.EventHandler(this.Grupe_Click);
            // 
            // Zaposleni
            // 
            this.Zaposleni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(183)))), ((int)(((byte)(93)))));
            this.Zaposleni.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zaposleni.Location = new System.Drawing.Point(117, 11);
            this.Zaposleni.Name = "Zaposleni";
            this.Zaposleni.Size = new System.Drawing.Size(100, 55);
            this.Zaposleni.TabIndex = 1;
            this.Zaposleni.Text = "Zaposleni";
            this.Zaposleni.UseVisualStyleBackColor = false;
            this.Zaposleni.Click += new System.EventHandler(this.Zaposleni_Click);
            // 
            // Polaznici
            // 
            this.Polaznici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(183)))), ((int)(((byte)(93)))));
            this.Polaznici.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Polaznici.Location = new System.Drawing.Point(11, 11);
            this.Polaznici.Name = "Polaznici";
            this.Polaznici.Size = new System.Drawing.Size(100, 55);
            this.Polaznici.TabIndex = 0;
            this.Polaznici.Text = "Polaznici";
            this.Polaznici.UseVisualStyleBackColor = false;
            this.Polaznici.Click += new System.EventHandler(this.Polaznici_Click);
            // 
            // ChildForm
            // 
            this.ChildForm.BackColor = System.Drawing.Color.Chartreuse;
            this.ChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChildForm.Location = new System.Drawing.Point(0, 79);
            this.ChildForm.Name = "ChildForm";
            this.ChildForm.Size = new System.Drawing.Size(1483, 679);
            this.ChildForm.TabIndex = 1;
            // 
            // Djeciji_vrtic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 758);
            this.Controls.Add(this.ChildForm);
            this.Controls.Add(this.menuBar);
            this.MaximizeBox = false;
            this.Name = "Djeciji_vrtic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Djeciji vrtic";
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuBar;
        private System.Windows.Forms.Button Uplate;
        private System.Windows.Forms.Button Grupe;
        private System.Windows.Forms.Button Zaposleni;
        private System.Windows.Forms.Button Polaznici;
        private System.Windows.Forms.Panel ChildForm;
    }
}

