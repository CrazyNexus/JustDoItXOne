//
// AdMobRenderer.cs
//
// Created by Thomas Dubiel on 25.01.2017
// Copyright 2017 Thomas Dubiel (td@crazynexus.de). All rights reserved.
//
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using justdoitxone;
//using Google.Ads;
using justdoitxone.Droid;
using Android.Gms.Ads;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobRenderer))]

namespace justdoitxone.Droid
{
	public class AdMobRenderer : ViewRenderer<AdMobView, Android.Gms.Ads.AdView>
	{
		const string AdMobID = "ca-app-pub-7760423869401509/8481587870";

		public AdMobRenderer()
		{
		}

		protected override void OnElementChanged(ElementChangedEventArgs<AdMobView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				var ad = new AdView(Forms.Context);
				ad.AdSize = AdSize.Banner;
				ad.AdUnitId = AdMobID;

				var requestBuilder = new AdRequest.Builder();
				ad.LoadAd(requestBuilder.Build());
				SetNativeControl(ad);
			}
		}

	}
}
