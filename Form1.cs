using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRefresh1_Click(object sender, EventArgs e)
        {
            fileName.Text = string.Empty;
            Data.Text = string.Empty;
            UserName.Text = string.Empty;
            MessageBox.Show("Refresh button clicked");
        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked");
        }

        private void btnDownload1_Click(object sender, EventArgs e)
        {
            string dataToDownload = $"{fileName.Text} {Data.Text} {UserName.Text}";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save As";
            saveFileDialog.FileName = "DownloadedData.txt";

            if (dataToDownload.Length > 2 && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                string fileName = saveFileDialog.FileName;

                try
                {
                   
                    File.WriteAllText(fileName, dataToDownload);
                    MessageBox.Show("Download successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No Data to Download", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    file.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnUpload1_Click(object sender, EventArgs e)
        {
           

            MyDataModel newRecord = new MyDataModel
            {
                Filename = fileName.Text,
                Data = Data.Text,
                UserName = UserName.Text
            };

            
            DatabaseHelper dbHelper = new DatabaseHelper();
            dbHelper.InsertRecord(newRecord);

            string message = "uploaded successfully !!";
            MessageBox.Show(message);
            file.Text="chooseFile";
        }

        private void file_Click(object sender, EventArgs e)
        {

        }


        private void Form_Load(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            DatabaseHelper dbHelper = new DatabaseHelper();
            List<MyDataModel> records = dbHelper.GetRecords();

            
        }


    }
}
