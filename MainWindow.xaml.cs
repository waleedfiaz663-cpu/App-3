using System.Windows;

namespace NameManagerApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string newName = txtAdd.Text.Trim();

            
            if (string.IsNullOrWhiteSpace(newName))
            {
                MessageBox.Show("Please enter a valid name.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);

                return;
            }

           
            if (_1stNames.Items.Contains(newName))
            {
                MessageBox.Show("This name already exists in the list.", "Duplicate Error", MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }

            
            _1stNames.Items.Add(newName);

            txtAdd.Clear();
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            
            if (_1stNames.SelectedItem == null)
            {
                MessageBox.Show("Please select a name from the list first.", "Selection Error", MessageBoxButton.OK, MessageBoxImage.Warning);

                return;
            }

            
            _1stNames.Items.Remove(_1stNames.SelectedItem);

            txtAdd.Clear();
        }
    }
}