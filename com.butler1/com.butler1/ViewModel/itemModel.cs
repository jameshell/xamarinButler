using System;
using System.Collections.Generic;
using System.Text;

namespace com.butler1.ViewModel
{
    public class itemModel
    {
        public List<MasterPageItem> items { get; set; }

        public itemModel()
        {
            items = new MasterPageItem().getItems();
        }
        

    }
}
