using System.Collections.Generic;

public class MyProduct
    {
        public int id { get; set; }
        public int quantity { get; set; }
    }

    public class CartPostDto
    {
        public List<MyProduct> products { get; set; }
    }