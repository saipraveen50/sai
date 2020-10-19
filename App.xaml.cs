using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //database name
        public static string databaseName = "Contacts.db";
        //folderpath for database
        public static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //database path
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);

    }
}
