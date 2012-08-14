using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsLib;
using NewsLib.Model;

namespace LibTest
{
    public class MockGoogle : INewsUpdater
    {
        public List<NewsItem> Update()
        {
            List<NewsItem> nList = new List<NewsItem>();

            NewsItem ni = new NewsItem();
            ni.Title = "title2goog";
            ni.Description = "desc2goog";

            nList.Add(ni);

            NewsItem ni2 = new NewsItem();
            ni2.Title = "title3goog";
            ni2.Description = "desc3goog";

            nList.Add(ni2);
            return nList;
        }
    }
}
