
namespace _3PL2_NetMySqlConnection
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
			if (disposing && (components != null)) {
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
			this.btnTestConnenction = new System.Windows.Forms.Button();
			this.btnGeneruokParduotuvę = new System.Windows.Forms.Button();
			this.btnGaukParduotuves = new System.Windows.Forms.Button();
			this.btnGeneruokPreke = new System.Windows.Forms.Button();
			this.txtPrekėsPavadinimas = new System.Windows.Forms.TextBox();
			this.btnIeškotiPrekės = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnTestConnenction
			// 
			this.btnTestConnenction.Location = new System.Drawing.Point(13, 13);
			this.btnTestConnenction.Name = "btnTestConnenction";
			this.btnTestConnenction.Size = new System.Drawing.Size(119, 23);
			this.btnTestConnenction.TabIndex = 0;
			this.btnTestConnenction.Text = "Test Connection";
			this.btnTestConnenction.UseVisualStyleBackColor = true;
			this.btnTestConnenction.Click += new System.EventHandler(this.btnTestConnenction_Click);
			// 
			// btnGeneruokParduotuvę
			// 
			this.btnGeneruokParduotuvę.Location = new System.Drawing.Point(13, 43);
			this.btnGeneruokParduotuvę.Name = "btnGeneruokParduotuvę";
			this.btnGeneruokParduotuvę.Size = new System.Drawing.Size(119, 23);
			this.btnGeneruokParduotuvę.TabIndex = 1;
			this.btnGeneruokParduotuvę.Text = "Generuok parduotuvę";
			this.btnGeneruokParduotuvę.UseVisualStyleBackColor = true;
			this.btnGeneruokParduotuvę.Click += new System.EventHandler(this.btnGeneruokParduotuvę_Click);
			// 
			// btnGaukParduotuves
			// 
			this.btnGaukParduotuves.Location = new System.Drawing.Point(13, 73);
			this.btnGaukParduotuves.Name = "btnGaukParduotuves";
			this.btnGaukParduotuves.Size = new System.Drawing.Size(119, 23);
			this.btnGaukParduotuves.TabIndex = 2;
			this.btnGaukParduotuves.Text = "Gauk parduotuves";
			this.btnGaukParduotuves.UseVisualStyleBackColor = true;
			this.btnGaukParduotuves.Click += new System.EventHandler(this.btnGaukParduotuves_Click);
			// 
			// btnGeneruokPreke
			// 
			this.btnGeneruokPreke.Location = new System.Drawing.Point(13, 103);
			this.btnGeneruokPreke.Name = "btnGeneruokPreke";
			this.btnGeneruokPreke.Size = new System.Drawing.Size(119, 23);
			this.btnGeneruokPreke.TabIndex = 3;
			this.btnGeneruokPreke.Text = "Generuok prekę";
			this.btnGeneruokPreke.UseVisualStyleBackColor = true;
			this.btnGeneruokPreke.Click += new System.EventHandler(this.btnGeneruokPreke_Click);
			// 
			// txtPrekėsPavadinimas
			// 
			this.txtPrekėsPavadinimas.Location = new System.Drawing.Point(13, 133);
			this.txtPrekėsPavadinimas.Name = "txtPrekėsPavadinimas";
			this.txtPrekėsPavadinimas.Size = new System.Drawing.Size(100, 20);
			this.txtPrekėsPavadinimas.TabIndex = 4;
			// 
			// btnIeškotiPrekės
			// 
			this.btnIeškotiPrekės.Location = new System.Drawing.Point(119, 131);
			this.btnIeškotiPrekės.Name = "btnIeškotiPrekės";
			this.btnIeškotiPrekės.Size = new System.Drawing.Size(75, 23);
			this.btnIeškotiPrekės.TabIndex = 5;
			this.btnIeškotiPrekės.Text = "Ieškoti";
			this.btnIeškotiPrekės.UseVisualStyleBackColor = true;
			this.btnIeškotiPrekės.Click += new System.EventHandler(this.btnIeškotiPrekės_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 289);
			this.Controls.Add(this.btnIeškotiPrekės);
			this.Controls.Add(this.txtPrekėsPavadinimas);
			this.Controls.Add(this.btnGeneruokPreke);
			this.Controls.Add(this.btnGaukParduotuves);
			this.Controls.Add(this.btnGeneruokParduotuvę);
			this.Controls.Add(this.btnTestConnenction);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTestConnenction;
		private System.Windows.Forms.Button btnGeneruokParduotuvę;
		private System.Windows.Forms.Button btnGaukParduotuves;
		private System.Windows.Forms.Button btnGeneruokPreke;
		private System.Windows.Forms.TextBox txtPrekėsPavadinimas;
		private System.Windows.Forms.Button btnIeškotiPrekės;
	}
}

