using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingSite.Helpers.TagHelpers
{
    public class PanelContext
    {
        public IHtmlContent Title { get; set; }
        public IHtmlContent Body { get; set; }
        public IHtmlContent Footer { get; set; }
    }
}
