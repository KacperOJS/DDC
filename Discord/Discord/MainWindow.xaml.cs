using Discord.Data;
using Discord.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Discord
{
    public partial class MainWindow : Window
    {
        private readonly data _context;
        private List<User> _users;
        private List<Message> _messages;
        private List<string> Wiadomosci = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            // Build the DbContextOptions with the connection string
            var optionsBuilder = new DbContextOptionsBuilder<data>();
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-M9LJK3Q\SQLEXPRESS03;Initial Catalog=dcs;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");

            // Initialize the data context with the options
            _context = new data(optionsBuilder.Options);

            // Load users when the application starts
            LoadUsers();
        }

        // Method to load users from the database and display in the ListView
        private void LoadUsers()
        {
            try
            {
                _users = _context.Users.ToList();
                nazwyUzytkownikowOnline.ItemsSource = _users;

                if (_users.Any())
                {
                    messageLabel.Content = "First user: " + _users.First().Name;
                }
                else
                {
                    messageLabel.Content = "No users found.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading users: " + ex.Message);
            }
        }

        // Method to add a new user to the database
        private void AddNewUser(string userName)
        {
            try
            {
                var newUser = new User { Name = userName };
                _context.Users.Add(newUser);
                _context.SaveChanges();

                // Reload users after adding a new one
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding a new user: " + ex.Message);
            }
        }

        // Event handler for the button click to add a message and potentially a new user
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string message = messageTextBox.Text;
            Wiadomosci.Add(message);
            string allMessages = string.Join("\n", Wiadomosci);

            messageLabel.Content = allMessages;
            messageTextBox.Clear();

            // Optionally add a new user on button click (you can decide when to trigger this)
            AddNewUser("miska");  // You can replace "miska" with any input or logic
        }

        // Event handler for selection changed in the ListView
        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (_users == null || !_users.Any())
            {
                MessageBox.Show("No users to display.");
                return;
            }

            var selectedUser = (User)nazwyUzytkownikowOnline.SelectedItem;
            if (selectedUser != null)
            {
                messageLabel.Content = $"Selected user: {selectedUser.Name}";
            }
        }
    }
}
