using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiFacebook.Domain.Entity
{
    public class HistoricoVendasHotmart
    {
        public class Producer
        {
            public string name { get; set; }
            public string ucode { get; set; }
        }

        public class Buyer
        {
            public string name { get; set; }
            public string ucode { get; set; }
        }

        public class Payment
        {
            public string type { get; set; }
            public string method { get; set; }
            public int installments_number { get; set; }
        }

        public class Price
        {
            public string currency_code { get; set; }
            public double value { get; set; }
        }

        public class Offer
        {
            public string payment_mode { get; set; }
            public string code { get; set; }
        }

        public class HotmartFee
        {
            public double @base { get; set; }
            public string currency_code { get; set; }
            public int @fixed { get; set; }
        }

        public class Tracking
        {
            public string source { get; set; }
            public string source_sck { get; set; }
        }

        public class Purchase
        {
            public Payment payment { get; set; }
            public Price price { get; set; }
            public object order_date { get; set; }
            public string commission_as { get; set; }
            public Offer offer { get; set; }
            public string transaction { get; set; }
            public object approved_date { get; set; }
            public HotmartFee hotmart_fee { get; set; }
            public int recurrency_number { get; set; }
            public string status { get; set; }
            public bool is_subscription { get; set; }
            public Tracking tracking { get; set; }
        }

        public class Product
        {
            public string name { get; set; }
            public int id { get; set; }
        }

        public class Item
        {
            public Producer producer { get; set; }
            public Buyer buyer { get; set; }
            public Purchase purchase { get; set; }
            public Product product { get; set; }
        }

        public class PageInfo
        {
            public int results_per_page { get; set; }
            public string next_page_token { get; set; }
            public int total_results { get; set; }
        }

        public class Root
        {
            public List<Item> items { get; set; }
            public PageInfo page_info { get; set; }
        }
    }
}
