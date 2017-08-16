using SQLite.Net.Interop;
using Xamarin.Forms;

namespace SampleSQLiteApp
{
	public partial class App : Application
	{
		public static PersonRepository PersonRepo { get; private set; }

		public App(string dbPath, ISQLitePlatform sqlitePlatform)
		{
			//InitializeComponent();
			PersonRepo = new PersonRepository(sqlitePlatform, dbPath);
			this.MainPage = new SampleSQLiteAppPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
