//
// MainPage.xaml.cs
//
// Created by Thomas Dubiel on 11.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;

namespace justdoitxone
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			taskText.Text = Helpers.Settings.GeneralSettings;
		}

		void OnSaveClicked(object sender, EventArgs e)
		{
			var text = taskText.Text;
			if (!string.IsNullOrWhiteSpace(text))
			{
				// save text to user settings
				Helpers.Settings.GeneralSettings = text;
				ShowAlert("Success", "Task saved ... now do it!");
			}
			else {
				// message to user about empty text
				ShowAlert("Error", "No Task to save!");
			}
		}

		void OnSwitchToggled(object sender, EventArgs e)
		{
			lbTest.Text = "Switch toggled";
		}

		void ShowAlert(string title, string message)
		{
			DisplayAlert(title, message, "OK");
		}
	}

	public class AdMobView : ContentView
	{
		public AdMobView()
		{

		}
	}
}
