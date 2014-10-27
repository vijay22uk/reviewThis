using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reviewThis.Web.ViewModel
{
    public class ToReviewEntityVM
    {
        public int ToReviewEntityID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public string MsgToClient { get; set; }
    }
}