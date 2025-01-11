using Microsoft.Win32;
using SwiftMartCRM.ProductEntity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SwiftMartCRM
{
    /// <summary>
    /// Interaction logic for TVsControl.xaml
    /// </summary>
    public partial class TVsControl : UserControl
    {
        /// <summary>
        /// Counter to track the number of images added to the container.
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// Stores the content of a text file containing the product description.
        /// </summary>
        private string? fileContent;

        /// <summary>
        /// A list of file paths for the images added to the product.
        /// </summary>
        private List<string> photoFiles;

        /// <summary>
        /// Initializes a new instance of the <see cref="TVsControl"/> class.
        /// </summary>
        public TVsControl()
        {
            photoFiles = new List<string>();
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click event for adding photos.
        /// Opens a file dialog to select up to 4 image files and displays them in the <see cref="PhotoContainer"/>.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
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

                        // Create an image element and add it to the container
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
                        MessageBox.Show("Error: You can only add up to 4 images.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Handles the click event for adding a description from a text file.
        /// Opens a file dialog to select a text file and stores its content in <see cref="fileContent"/>.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the click event for saving a new TV product.
        /// Creates a new instance of the <see cref="TV"/> class with the entered data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Converts a string representation ("Yes"/"No") to a boolean value.
        /// </summary>
        /// <param name="text">The string to convert.</param>
        /// <returns>Returns <c>true</c> if the text is "Yes"; otherwise, <c>false</c>.</returns>
        private bool converterToBool(string text)
        {
            return text == "Yes";
        }
    }
}
