using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Registration
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string folderLocation = @"E:\Data\Apps\";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var p = new Person();
                p.FirstName = txtFirstName.Text;
                p.LastName = txtLastName.Text;
                p.Age = Convert.ToInt32(txtAge.Text);

                string text = $"{p.FirstName} {p.LastName} {p.Age}";
                string filePath = folderLocation + text + ".txt";
                File.WriteAllText(filePath,text);
                MessageBox.Show("File has been saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Found", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnViewAll_Click(object sender, RoutedEventArgs e)
        {
            txtInfo.Text = "";

            string[] files = Directory.GetFiles(folderLocation);
            foreach (var file in files)
            {
                string text = File.ReadAllText(file);
                txtInfo.Text += text + "\n";
            }
        }
    }
}
