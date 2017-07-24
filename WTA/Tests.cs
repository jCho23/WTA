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
        }

        [Test]
        public void Repl()
        {
            app.Repl();
        }

        [Test]
        public void AtlantaWalkthoughTest()
        {
			app.Tap(x => x.Id("NameTextView").Index(1));
			app.Tap("showLiveScoresButton");
        }
    }
}
