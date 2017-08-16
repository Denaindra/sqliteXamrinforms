using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace SampleSQLiteApp
{
	public partial class SampleSQLiteAppPage : ContentPage
	{
		public SampleSQLiteAppPage()
		{
			InitializeComponent();
		}

		public async void OnNewButtonClicked(object sender, EventArgs args)
		{
			statusMessage.Text = "";

			await App.PersonRepo.AddNewPersonAsync(newPerson.Text);
			statusMessage.Text = App.PersonRepo.StatusMessage;
		}

		public async void OnGetButtonClicked(object sender, EventArgs args)
		{
			statusMessage.Text = "";

			List<Person> pplList = await App.PersonRepo.GetAllPeopleAsync();

			ObservableCollection<Person> pplCollection = new ObservableCollection<Person>(pplList);
			peopleList.ItemsSource = pplCollection;
		}
	}
}
