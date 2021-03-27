using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _3PL2_NetMySqlConnection
{
	public partial class Form1 : Form
	{

		public Form1()
		{
			InitializeComponent();
		}

		private void btnTestConnenction_Click(object sender, EventArgs e)
		{
			var connectionString = ConfigurationManager.ConnectionStrings["parduoutuvėDbConnection"].ConnectionString;

			using (MySqlConnection testConnection = new MySqlConnection(connectionString)) {
				try {
					testConnection.Open();
					MessageBox.Show("Success!");
				} catch (Exception ex) {
					MessageBox.Show(ex.Message.ToString());
				}
			}
		}

		private void btnGeneruokParduotuvę_Click(object sender, EventArgs e)
		{
			var random = new Random();
			var adresas = $"Adreso g. {random.Next(1, 150)}";

			var connectionString = ConfigurationManager.ConnectionStrings["parduoutuvėDbConnection"].ConnectionString;

			using (MySqlConnection generuokParduotuvęConnection = new MySqlConnection(connectionString)) {
				generuokParduotuvęConnection.Open();

				var command = $"INSERT INTO Parduotuvės (Adresas) VALUES ('{adresas}')";
				MySqlCommand generuokParduotuvęCommand = new MySqlCommand(command, generuokParduotuvęConnection);

				var eilutės = generuokParduotuvęCommand.ExecuteNonQuery();
				MessageBox.Show($"Rows affected: {eilutės}");
			}
		}

		private void btnGaukParduotuves_Click(object sender, EventArgs e)
		{
			var connectionString = ConfigurationManager.ConnectionStrings["parduoutuvėDbConnection"].ConnectionString;

			using (MySqlConnection gaukParduotuvesConnection = new MySqlConnection(connectionString)) {
				gaukParduotuvesConnection.Open();

				var command = "SELECT Adresas FROM Parduotuvės";
				MySqlCommand gaukParduotuvesCommand = new MySqlCommand(command, gaukParduotuvesConnection);

				var reader = gaukParduotuvesCommand.ExecuteReader();

				var parduotuvės = "";
				while (reader.Read()) {
					parduotuvės += reader.GetString("Adresas") + "\n";
				}

				MessageBox.Show(parduotuvės);
			}
		}

		private void btnGeneruokPreke_Click(object sender, EventArgs e)
		{

		}

		private void btnIeškotiPrekės_Click(object sender, EventArgs e)
		{

		}
	}
}
