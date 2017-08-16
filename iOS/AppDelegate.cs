using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using SQLite.Net.Platform.XamarinIOS;
using UIKit;
using Xamarin.Forms;

namespace SampleSQLiteApp.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			

			Forms.Init ();

		string dbPath = FileAccessHelper.GetLocalFilePath("HellowWorld.db3");

		LoadApplication(new App(dbPath, new SQLitePlatformIOS()));

		return base.FinishedLaunching(app, options);


		}
	}
}
