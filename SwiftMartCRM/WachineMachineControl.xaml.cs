using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SwiftMartCRM
{
    /// <summary>
    /// Interaction logic for WachineMachineControl.xaml
    /// </summary>
    public partial class WachineMachineControl : UserControl
    {
        /// <summary>
        /// Counter to track the number of images added to the container.
        /// Ensures that no more than 4 images can be added.
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="WachineMachineControl"/> class.
        /// </summary>
        public WachineMachineControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for adding photos.
        /// Opens a file dialog to select image files and displays them in the <see cref="PhotoContainer"/>.
        /// Limits the maximum number of images to 4.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void AddPhotos_Click(object sender, RoutedEventArgs e)
        {
            // Configure file dialog to select image files
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;"
            };

            // Show the dialog and process selected files
            if (fileDialog.ShowDialog() == true)
            {
                foreach (var filePath in fileDialog.FileNames)
                {
                    if (counter < 4)
                    {
                        counter++;

                        // Create a new Image element for each file
                        Image image = new Image
                        {
                            Source = new BitmapImage(new Uri(filePath)),
                            Width = 200,
                            Height = 200,
                            Margin = new Thickness(5)
                        };

                        // Add the image to the container
                        PhotoContainer.Children.Add(image);
                    }
                    else
                    {
                        // Display an error message if the limit is exceeded
                        MessageBox.Show("Error: You can only add up to 4 images.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Placeholder for additional button click functionality.
        /// Currently, this method is not implemented.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // TODO: Add functionality for this button click event
        }
    }
}
