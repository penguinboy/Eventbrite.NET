using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



    public class summary
    {

        public filters filters { get; set; }
        public string first_event { get; set; }
        public string last_event { get; set; }
        public string num_showing { get; set; }
        public string total_items { get; set; }


    }
    



//summary node
//    The search results summary with the following structure:

//    first_event integer
//        The first event ID returned.
//    last_event integer
//        The last event ID returned.
//    num_showing integer
//        The number of events showing on page.
//    total_items integer