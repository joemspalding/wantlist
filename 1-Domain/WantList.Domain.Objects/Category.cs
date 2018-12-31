using System;
using System.Collections.Generic;

namespace WantList.Domain.Objects {
    public class Category : BaseWantListObject {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<Item> MyProperty { get; set; }
    }
}