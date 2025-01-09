using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
    /// Логика взаимодействия для RefrigeratorsControl.xaml
    /// </summary>
    public partial class RefrigeratorsControl : UserControl
    {
        private int counter = 0;
        public RefrigeratorsControl()
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

                }
            }
        }
    }
}
