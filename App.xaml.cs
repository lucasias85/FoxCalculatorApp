using FoxCalculatorApp.AppCode.Helpers;

namespace FoxCalculatorApp
{
    public partial class App : Application
    {
        static SQLiteDatabaseHelper? database;

        public static SQLiteDatabaseHelper Database
        {
            get
            {
                if (database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dbFoxCalculator.db3");
                    database = new SQLiteDatabaseHelper(dbPath);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
