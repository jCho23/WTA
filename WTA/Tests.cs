using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace WTA
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
        public void AtlantaWalkThroughTest()
        {
			app.Tap(x => x.Id("NameTextView").Index(1));
            app.Screenshot("Let's start by Tapping on 'Atlanta'");
			app.Tap("showLiveScoresButton");
            app.Screenshot("We Tapped on the 'Live Score' Button");
            app.Tap("showCompletedMatchesButton");
            app.Screenshot("Next we Tapped the 'Completed' Button");
            app.Tap("showScheduleButton");
            app.Screenshot("Then we Tapped the 'Schedule' Button");
            app.Tap("showDrawsButton");
            app.Screenshot("Last, we Tapped the 'Draws' Button");


		
			app.Tap("NameTextView");
			app.Tap("DrawItem");
		}
    }
}
