using System;

namespace WantList.Domain.Objects {
    public class Item : BaseWantListObject {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}