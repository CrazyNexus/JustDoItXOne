//
// MainPage.xaml.cs
//
// Created by Thomas Dubiel on 11.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace justdoitxone
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		void OnSaveClicked(object sender, EventArgs e)
		{
			lbTest.Text = "Button clicked";
		}

		void OnSwitchToggled(object sender, EventArgs e)
		{
			lbTest.Text = "Switch toggled";
		}
	}
}
