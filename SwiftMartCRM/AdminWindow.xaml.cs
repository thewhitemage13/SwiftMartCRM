using Microsoft.Win32;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 3e623d12e0c8c237763f099b1bd36f60b60bccf9
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SwiftMartCRM
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private int counter = 0;

        public AdminWindow()
        {
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
<<<<<<< HEAD
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

                        PhotoContainer.Children.Add(image);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
=======
                    Image image = new Image
                    {
                        Source = new BitmapImage(new Uri(filePath)),
                        Width = 200,
                        Height = 200,
                        Margin = new Thickness(5)
                    };

                    PhotoContainer.Children.Add(image);
>>>>>>> 3e623d12e0c8c237763f099b1bd36f60b60bccf9
                }
            }
        }
    }
}
