using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiHomeTask.Models.Rresponse
{
    public class BookingResponse
    {
        [JsonProperty("firstname")]
        public string Firstname { get; set; }

        [JsonProperty("lastname")]
        public string Lastname { get; set; }

        [JsonProperty("totalprice")]
        public int Totalprice { get; set; }

        [JsonProperty("depositpaid")]
        public bool Depositpaid { get; set; }

        [JsonProperty("bookingdates")]
        public Bookingdates Bookingdates { get; set; }

        [JsonProperty("additionalneeds")]
        public string Additionalneeds { get; set; }
    }

    public class Bookingdates
    {
        [JsonProperty("checkin")]
        public string Checkin { get; set; }

        [JsonProperty("checkout")]
        public string Checkout { get; set; }
    }

    public class CreatedBooking
    {
        [JsonProperty("bookingid")]
        public int Bookingid { get; set; }

        [JsonProperty("booking")]
        public BookingResponse Booking { get; set; }
    }

}
