// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using System.Collections.Generic;

public class QuantityWarnings
    {
        public string _108044197 { get; set; }
    }

    public class Allocation
    {
        public double unit_price { get; set; }
        public int quantity { get; set; }
    }

    public class Notification
    {
        public string type { get; set; }
        public string code { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public List<Value> values { get; set; }
    }

    public class CartItem
    {
        public string date_added { get; set; }
        public int product_id { get; set; }
        public double sub_total { get; set; }
        public int quantity { get; set; }
        public List<Allocation> allocations { get; set; }
        public List<object> missed_promotions { get; set; }
        public List<Notification> notifications { get; set; }
    }

    public class Images
    {
        public string small { get; set; }
        public string large { get; set; }
        public string listing { get; set; }
        public string full { get; set; }
        public string fb { get; set; }
    }

    public class ShippingInformation
    {
        public bool is_in_stock { get; set; }
        public string message { get; set; }
    }

    public class Product
    {
        public int product_id { get; set; }
        public string plid { get; set; }
        public int tsin_id { get; set; }
        public Images images { get; set; }
        public bool is_preorder { get; set; }
        public bool is_active { get; set; }
        public bool is_available { get; set; }
        public bool is_tv_license_required { get; set; }
        public bool is_ebook { get; set; }
        public bool is_prepaid { get; set; }
        public bool is_voucher { get; set; }
        public bool is_liquor { get; set; }
        public bool is_unboxed { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public double original_price { get; set; }
        public int selling_price { get; set; }
        public int web_selling_price { get; set; }
        public ShippingInformation shipping_information { get; set; }
        public string sponsored_ads_seller_id { get; set; }
    }

    public class FreeDeliveryInfo
    {
        public bool can_add_more_items_to_qualify { get; set; }
        public bool is_qualified { get; set; }
        public double additional_amount_needed { get; set; }
        public int worth { get; set; }
        public int free_shipping_threshold { get; set; }
    }

    public class Pill
    {
        public string display_text { get; set; }
        public string type { get; set; }
    }

    public class Value
    {
        public string value_id { get; set; }
        public string type { get; set; }
        public string value { get; set; }
    }

    public class EstimatedDateDisplay
    {
        public string title { get; set; }
        public List<Notification> notifications { get; set; }
    }

    public class EstimatedDelivery
    {
        public Pill pill { get; set; }
        public string subtitle { get; set; }
        public EstimatedDateDisplay estimated_date_display { get; set; }
        public string estimated_date { get; set; }
        public string estimated_days { get; set; }
    }

    public class Total
    {
        public double value { get; set; }
        public string title { get; set; }
    }

    public class SubTotal
    {
        public double value { get; set; }
        public string title { get; set; }
    }

    public class CartSummary
    {
        public Total total { get; set; }
        public SubTotal sub_total { get; set; }
    }

    public class CartItemDto
    {
        public int customer { get; set; }
        public QuantityWarnings quantity_warnings { get; set; }
        public double total_saving { get; set; }
        public double total { get; set; }
        public int items { get; set; }
        public double sub_total { get; set; }
        public List<List<object>> summary { get; set; }
        public List<object> promotions { get; set; }
        public List<CartItem> cart_items { get; set; }
        public List<Product> products { get; set; }
        public List<object> notifications { get; set; }
        public string price_disclaimer { get; set; }
        public FreeDeliveryInfo free_delivery_info { get; set; }
        public EstimatedDelivery estimated_delivery { get; set; }
        public CartSummary cart_summary { get; set; }
    }

