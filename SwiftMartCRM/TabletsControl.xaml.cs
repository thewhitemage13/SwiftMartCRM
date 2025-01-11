using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SwiftMartCRM
{
    /// <summary>
    /// Interaction logic for TabletsControl.xaml
    /// </summary>
    public partial class TabletsControl : UserControl
    {
        /// <summary>
        /// A counter to track the number of added images.
        /// Ensures that no more than 4 images are added to the container.
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="TabletsControl"/> class.
        /// </summary>
        public TabletsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event of the "Add Photos" button.
        /// Opens a file dialog to select image files and adds up to 4 selected images to the <see cref="PhotoContainer"/>.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void AddPhotos_Click(object sender, RoutedEventArgs e)
        {
            // Configure the file dialog to allow multiple image selections
            OpenFileDialog fileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;"
            };

            // Show the dialog and process the selected files
            if (fileDialog.ShowDialog() == true)
            {
                foreach (var filePath in fileDialog.FileNames)
                {
                    if (counter < 4)
                    {
                        counter++;

                        // Create a new Image control for each selected file
                        Image image = new Image
                        {
                            Source = new BitmapImage(new Uri(filePath)),
                            Width = 200,
                            Height = 200,
                            Margin = new Thickness(5)
                        };

                        // Add the image to the PhotoContainer
                        PhotoContainer.Children.Add(image);
                    }
                    else
                    {
                        // Show an error message if more than 4 images are added
                        MessageBox.Show("Error: You can only add up to 4 images.");
                    }
                }
            }
        }
    }
}
