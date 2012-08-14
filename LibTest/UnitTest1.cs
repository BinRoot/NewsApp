using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using NewsLib;
using NewsLib.Model;

namespace LibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LatLongTest()
        {
            NewsItem ni = new NewsItem();
            ni.setLocation(2.0, -4.2);

            bool latMatch = 2.0 == ni.Latitude;
            bool lonMatch = -4.2 == ni.Longitude;

            Assert.IsTrue(latMatch && lonMatch);
        }

        [TestMethod]
        public void NewsSourcesTest()
        {
            INewsUpdater bbcNews = new MockBBC();
            INewsUpdater googNews = new MockGoogle();
            List<INewsUpdater> newsSources = new List<INewsUpdater>();
            newsSources.Add(bbcNews);
            newsSources.Add(googNews);
            NewsReader nr = new NewsReader(newsSources);
            List<NewsItem> allNews = nr.ReadAllNews();

            bool found = false;
            foreach (NewsItem n in allNews)
            {
                if (n.Title == "title3goog")
                {
                    found = true;
                }
            }

            Assert.IsTrue(found);
        }
    }
}
