using System;
using System.Collections.Generic;
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
using static ContactsApp.Classes.Contacts;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Contact> contacts;
        public MainWindow()
        {
            InitializeComponent();
            contacts = new List<Contact>();
            ReadDatabase();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //instance of new contact window
            NewContactWindow newContactWindow = new NewContactWindow();
            // open new contact window on button click
            newContactWindow.ShowDialog();
            ReadDatabase();
        }

        void ReadDatabase()
        {

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.databasePath))
            {
                conn.CreateTable<Contact>();
                contacts = conn
                          .Table<Contact>()
                          .ToList()
                          .OrderBy(c => c.Name)
                          .ToList();
            }

            if (contacts != null)
            {
                contactsListView.ItemsSource = contacts;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox searchTextBox = sender as TextBox;
            var filteredList = contacts
                              .Where(c => c.Name.ToLower()
                              .Contains(searchTextBox.Text.ToLower()))
                              .ToList();
            contactsListView.ItemsSource = filteredList;
        }

        private void ContactsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact selectedContact = (Contact)contactsListView.SelectedItem;

            if (selectedContact != null)
            {
                //instance of contactdetailswindow
                ContactDetailsWindow contactDetailsWindow = new ContactDetailsWindow(selectedContact);
                contactDetailsWindow.ShowDialog();
            }
        }

    }
}
