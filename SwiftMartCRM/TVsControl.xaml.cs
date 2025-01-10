using Microsoft.Win32;
using SwiftMartCRM.ProductEntity;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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

namespace SwiftMartCRM
{
    /// <summary>
    /// Логика взаимодействия для TVsControl.xaml
    /// </summary>
    public partial class TVsControl : UserControl
    {
        private int counter = 0;
        private string? fileContent;
        private List<string> photoFiles;
        public TVsControl()
        {
            photoFiles = new List<string>();
            InitializeComponent();
        }

        private void AddPhotos_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;"
            };

            if (fileDialog.ShowDialog() == true)
            {
                foreach (var filePath in fileDialog.FileNames)
                {

                    if (counter < 4)
                    {
                        counter++;
                        Image image = new Image
                        {
                            Source = new BitmapImage(new Uri(filePath)),
                            Width = 200,
                            Height = 200,
                            Margin = new Thickness(5)
                        };

                        photoFiles.Add(filePath);
                        PhotoContainer.Children.Add(image);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    fileContent = File.ReadAllText(openFileDialog.FileName);

                    MessageBox.Show("Description added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool dvbC = converterToBool(DVBC.ToString());
            bool dvbS2 = converterToBool(DVBS2.ToString());
            bool dvbT2 = converterToBool(DVBT2.ToString());

            TV tV = new TV()
            {
               Name = TVName.ToString(),
               Price = Price.ToString(),
               Description = fileContent, 
               ScreenDiagonal = ScreenDiagonal.ToString(),
               ScreenFrequency = ScreenFrequency.ToString(),
               ScreenResolution = ScreenResolution.ToString(),
               OS = OS.ToString(),
               DVB_C = dvbC,
               DVB_S2 = dvbS2,
               DVB_T2 = dvbT2,
               photos = photoFiles
            };
        }


        private bool converterToBool(string text)
        {
            if(text == "Yes")
                return true;
            return false;
        }
    }
}
