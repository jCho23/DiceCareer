using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace DiceCareer
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("intro_btn_next");
			app.Screenshot("Let's start by Tapping on the 'Next' Button");
			app.Tap("intro_btn_skip");
			app.Screenshot("Then we Tapped on the 'Skip' Button");

			app.Tap("ll_dashboard_search_main");
			app.Screenshot("Next we Tapped on the 'Search Banner' middle icon");
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("navigation");
			app.Screenshot("We Tapped on the 'Hamburger Icon' Button");
			Thread.Sleep(4000);

			app.Tap("Job Search");
			app.Screenshot("Then we Tapped on the 'Job Search' Button");
			app.ScrollDown();
			app.Screenshot("Then we Scrolled down for more information");
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("Settings");
			app.Screenshot("Then we Tapped on the 'Settings' Button");
			//app.Tap("tl_notification");
			//app.Screenshot("We Toggled the 'Notification' Switch off");
			//app.Tap("tl_loc_service");
			//app.Screenshot("We Toggled the 'Location Service' Switch off");

			//app.Tap("tv_privacy_policy");
			//app.Screenshot("We Toggled the 'Privacy Policy' Switch off");
			//app.ScrollDown();
			//app.Screenshot("Then we scrolled down the page");
		}
	}
}
