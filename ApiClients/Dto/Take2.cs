using System.Collections.Generic;

public class Entries
{
    public string id { get; set; }
    public string type { get; set; }
    public string value { get; set; }

}
public class App_entries
{
    public string id { get; set; }
    public string type { get; set; }
    public string value { get; set; }

}
public class Badges
{
    public IList<Entries> entries { get; set; }
    public IList<App_entries> app_entries { get; set; }
    public IList<object> promotion_id { get; set; }

}
public class Delivery_charges
{

}
public class Buybox_summary
{
    public int listing_price { get; set; }
    public string pretty_price { get; set; }
    public string app_pretty_price { get; set; }
    public IList<int> prices { get; set; }
    public IList<int> app_prices { get; set; }
    public string saving { get; set; }
    public string app_saving { get; set; }
    public bool is_add_to_cart_available { get; set; }
    public bool is_shop_all_options_available { get; set; }
    public bool is_add_to_wish_list_available { get; set; }
    public int product_id { get; set; }
    public Delivery_charges delivery_charges { get; set; }
    public int tsin { get; set; }
    public bool is_preorder { get; set; }
    public string add_to_cart_text { get; set; }
    public IList<int> promotion_qty { get; set; }
    public IList<int> promotion_qty_display_text { get; set; }

}
public class Core
{
    public int id { get; set; }
    public string title { get; set; }
    public string subtitle { get; set; }
    public string brand { get; set; }
    public string brand_url { get; set; }
    public int reviews { get; set; }
    public double star_rating { get; set; }
    public string slug { get; set; }
    public IList<string> authors { get; set; }
    public IList<string> formats { get; set; }

}
public class Gallery
{
    public IList<string> images { get; set; }
    public IList<string> size_guide { get; set; }
    public int count { get; set; }
    public string display_count { get; set; }

}
public class Products
{
    public string id { get; set; }
    public string name { get; set; }
    public string brand { get; set; }
    public string category { get; set; }
    public string variant { get; set; }
    public string dimension1 { get; set; }
    public int dimension2 { get; set; }
    public int price { get; set; }
    public int quantity { get; set; }
    public int position { get; set; }

}
public class Add
{
    public IList<Products> products { get; set; }

}
public class Ecommerce
{
    public string currencyCode { get; set; }
    public Add add { get; set; }

}
public class Enhanced_ecommerce_add_to_cart
{
    public string @event { get; set; }
    public Ecommerce ecommerce { get; set; }

}
public class ActionField
{
    public string list { get; set; }
    public string action { get; set; }

}
// public class Products
// {
//     public string id { get; set; }
//     public string name { get; set; }
//     public IList<undefined> brand { get; set; }
//     public string category { get; set; }
//     public IList<undefined> variant { get; set; }
//     public IList<undefined> dimension1 { get; set; }
//     public int dimension2 { get; set; }
//     public int price { get; set; }
//     public int quantity { get; set; }
//     public int position { get; set; }

// }
public class Click
{
    public ActionField actionField { get; set; }
    public IList<Products> products { get; set; }

}
public class Ecommerce
{
    public Click click { get; set; }

}
public class Enhanced_ecommerce_click
{
    public string @event { get; set; }
    public Ecommerce ecommerce { get; set; }
    public string eventCallback { get; set; }

}
public class Impressions
{
    public string id { get; set; }
    public string name { get; set; }
    public string list { get; set; }
    public string brand { get; set; }
    public string category { get; set; }
    public string variant { get; set; }
    public string dimension1 { get; set; }
    public int dimension2 { get; set; }
    public int position { get; set; }
    public int price { get; set; }

}
public class Ecommerce
{
    public string currencyCode { get; set; }
    public IList<Impressions> impressions { get; set; }

}
public class Enhanced_ecommerce_impression
{
    public string @event { get; set; }
    public Ecommerce ecommerce { get; set; }

}
public class Promotions_summary
{
    public bool is_displayed { get; set; }
    public string label { get; set; }

}
public class Distribution_centres
{
    public string id { get; set; }
    public string text { get; set; }
    public string info_mode { get; set; }
    public string description { get; set; }

}
public class Stock_availability_summary
{
    public bool is_leadtime { get; set; }
    public bool is_imported { get; set; }
    public string status { get; set; }
    public IList<Distribution_centres> distribution_centres { get; set; }

}
public class Variant_summary
{
    public bool has_more_colours { get; set; }

}
public class Distribution
{
    public int num_1_star_ratings { get; set; }
    public int num_2_star_ratings { get; set; }
    public int num_3_star_ratings { get; set; }
    public int num_4_star_ratings { get; set; }
    public int num_5_star_ratings { get; set; }

}
public class Review_summary
{
    public double star_rating { get; set; }
    public int review_count { get; set; }
    public Distribution distribution { get; set; }

}
public class Product_views
{
    public Badges badges { get; set; }
    public Buybox_summary buybox_summary { get; set; }
    public Core core { get; set; }
    public Gallery gallery { get; set; }
    public Enhanced_ecommerce_add_to_cart enhanced_ecommerce_add_to_cart { get; set; }
    public Enhanced_ecommerce_click enhanced_ecommerce_click { get; set; }
    public Enhanced_ecommerce_impression enhanced_ecommerce_impression { get; set; }
    public Promotions_summary promotions_summary { get; set; }
    public Stock_availability_summary stock_availability_summary { get; set; }
    public Variant_summary variant_summary { get; set; }
    public Review_summary review_summary { get; set; }

}
public class Results
{
    public string type { get; set; }
    public Product_views product_views { get; set; }

}
public class Paging
{
    public string next_is_after { get; set; }
    public string previous_is_before { get; set; }
    public string num_found_text { get; set; }
    public int total_num_found { get; set; }
    public bool is_approximate { get; set; }

}
public class Products
{
    public string name { get; set; }
    public string id { get; set; }
    public IList<Results> results { get; set; }
    public Paging paging { get; set; }
    public bool is_paged { get; set; }
    public string search_request_id { get; set; }

}
public class Sections
{
    public Products products { get; set; }

}
public class Filters
{
    public IList<string> Sellers { get; set; }

}
public class Search_request
{
    public string context { get; set; }
    public IList<string> document_collections { get; set; }
    public Filters filters { get; set; }
    public IList<string> qsearch { get; set; }
    public int rows { get; set; }
    public IList<string> custom { get; set; }
    public IList<string> before { get; set; }
    public IList<string> after { get; set; }
    public IList<string> start { get; set; }
    public IList<string> category_slug { get; set; }
    public IList<string> department_slug { get; set; }
    public string sort { get; set; }
    public IList<string> experiment { get; set; }

}
public class Application
{
    public Sections sections { get; set; }
    public IList<string> section_keys { get; set; }
    public Search_request search_request { get; set; }

}