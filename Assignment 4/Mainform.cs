using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace CricketTeamManager
{
    public partial class MainWindow : Window
    {
        // ObservableCollection to hold the list of players
        public ObservableCollection<string> Players { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Players = new ObservableCollection<string>();
            PlayerListBox.ItemsSource = Players; // Bind the ListBox to the collection
        }

        // Add Player button click handler
        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            string playerName = PlayerNameTextBox.Text.Trim();

            // Validation: Prevent empty or duplicate names
            if (string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("Player name cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Players.Contains(playerName))
            {
                MessageBox.Show("Player name already exists.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Add the player to the list
            Players.Add(playerName);
            PlayerNameTextBox.Clear();
            MessageBox.Show($"Player '{playerName}' added successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        // Remove Player button click handler
        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            if (PlayerListBox.SelectedItem is string selectedPlayer)
            {
                Players.Remove(selectedPlayer);
                MessageBox.Show($"Player '{selectedPlayer}' removed successfully.", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Please select a player to remove.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
