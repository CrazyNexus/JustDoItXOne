//
// AdMobRenderer.cs
//
// Created by Thomas Dubiel on 23.01.2017
// Copyright 2017 Thomas Dubiel. All rights reserved.
//
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using justdoitxone;
using Google.MobileAds;
using UIKit;
using justdoitxone.iOS;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobRenderer))]

namespace justdoitxone.iOS
{
	public class AdMobRenderer : ViewRenderer
	{
		const string AdMobID = "ca-app-pub-7760423869401509/8481587870";
		BannerView adView;
		bool viewOnScreen;

		public AdMobRenderer()
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged(e);
			if (e.NewElement == null)
				return;

			if (e.OldElement == null)
			{
				adView = new BannerView(AdSizeCons.SmartBannerPortrait)
				{
					AdUnitID = AdMobID,
					RootViewController = UIApplication.SharedApplication.Windows[0].RootViewController
				};

				adView.AdReceived += (sender, args) =>
				{
					if (!viewOnScreen)
						this.AddSubviews(adView);
					viewOnScreen = true;
				};

				Request request = Request.GetDefaultRequest();
				adView.LoadRequest(request);
				base.SetNativeControl(adView);
			}
		}
	}
}
