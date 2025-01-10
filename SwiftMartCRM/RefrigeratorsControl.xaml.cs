using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SwiftMartCRM
{
    /// <summary>
    /// Interaction logic for RefrigeratorsControl.xaml
    /// Allows adding images to the refrigerator product entry.
    /// </summary>
    public partial class RefrigeratorsControl : UserControl
    {
        private int counter = 0;
        private const int MaxImages = 4;  // Maximum number of images allowed

        public RefrigeratorsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for adding images to the refrigerator product.
        /// Opens a file dialog for the user to select images and displays them in the PhotoContainer.
        /// </summary>
        private void AddPhotos_Click(object sender, RoutedEventArgs e)
        {
            // Open file dialog for selecting images
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;"
            };

            if (fileDialog.ShowDialog() == true)
            {
                // Loop through selected files
                foreach (var filePath in fileDialog.FileNames)
                {
                    // Check if the counter exceeds the limit of 4 images
                    if (counter < MaxImages)
                    {
                        counter++;

                        // Create and display the image
                        Image image = new Image
                        {
                            Source = new BitmapImage(new Uri(filePath)),
                            Width = 200,
                            Height = 200,
                            Margin = new Thickness(5)
                        };

                        // Add image to the PhotoContainer
                        PhotoContainer.Children.Add(image);
                    }
                    else
                    {
                        // Show an error message if trying to add more than 4 images
                        MessageBox.Show($"You can only add a maximum of {MaxImages} images.", "Limit Reached", MessageBoxButton.OK, MessageBoxImage.Warning);
                        break; // Exit the loop since no more images should be added
                    }
                }
            }
        }
    }
}
