using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeptlyAdaptiveChallenge.MyClasses
{
    public class NewsItem
    {
        public enum categoryType
        {
            Financial,
            Food
        }
        public int Id { get; set; }
        public categoryType Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string DateLine { get; set; }
        public string Image { get; set; }
    }
}
