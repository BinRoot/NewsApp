using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsLib;
using NewsLib.Model;

namespace LibTest
{
    public class MockBBC : INewsUpdater
    {
        public List<NewsItem> Update()
        {
            List<NewsItem> nList = new List<NewsItem>();

            NewsItem ni = new NewsItem();
            ni.Title = "title1";
            ni.Description = "desc1";
            
            nList.Add(ni);
            return nList;
        }
    }
}
