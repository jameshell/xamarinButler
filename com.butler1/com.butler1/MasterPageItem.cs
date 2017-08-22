using System;
using System.Collections.Generic;
using System.Text;

namespace com.butler1
{
    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
        public List<MasterPageItem> getItems()
        {
            List<MasterPageItem> items = new List<MasterPageItem>();
            {
                items.Add(new MasterPageItem
                {
                    Title = "Contacts",
                    IconSource = "Icon.png",
                    TargetType = typeof(Page1)
                });
                items.Add(new MasterPageItem
                {
                    Title = "Perfil",
                    IconSource = "Icon.png",
                    TargetType = typeof(Page1)
                });
                items.Add(new MasterPageItem
                {
                    Title = "Meh",
                    IconSource = "Icon.png",
                    TargetType = typeof(Page1)
                });

            };
            return items;
        }
        
        

    }
}
