namespace U2UConsult
{
    using System.Windows;

    /// <summary>
    /// Displays a range of Circular ProgressBar Controls.
    /// </summary>
    public partial class Window1 : Window
    {
        /// <summary>
        /// Initializes a new instance of the Window1 class.
        /// </summary>
        public Window1()
        {
            InitializeComponent();

            // Mouse.OverrideCursor = Cursors.UpArrow;
        }

        /// <summary>
        /// Somebody activated a ProgressBar.
        /// </summary>
        /// <param name="sender">Sender of the event: a CheckBox.</param>
        /// <param name="e">Event arguments.</param>
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CircularProgressBar pb =
                this.FindName((sender as FrameworkElement).Tag.ToString()) as CircularProgressBar;

            if (pb != null)
            {
                pb.Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// Somebody deactivated a ProgressBar.
        /// </summary>
        /// <param name="sender">Sender of the event: a CheckBox.</param>
        /// <param name="e">Event arguments.</param>
        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            CircularProgressBar pb =
                this.FindName((sender as FrameworkElement).Tag.ToString()) as CircularProgressBar;

            if (pb != null)
            {
                pb.Visibility = Visibility.Hidden;
            }
        }
    }
}
