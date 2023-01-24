using Newtonsoft.Json;
using WebApiHomeTask.Models.Request;

namespace WebApiHomeTask.Objects
{
    public class BookingObjects
    {
        public static string CreateABooking()
        {
            Booking createABooking = new Booking();
            BookingDates createBookingDates = new BookingDates();

            createABooking.Firstname = "Gergely";
            createABooking.Lastname = "Szucs";
            createABooking.Totalprice = 1986;
            createABooking.Depositpaid = true;
            createABooking.Bookingdates = createBookingDates;
            createBookingDates.Checkin = "2022-01-10";
            createBookingDates.Checkout = "2022-01-10";
            createABooking.Additionalneeds = "Breakfast";

            return JsonConvert.SerializeObject(createABooking);
        }
        public static string CreateABadBodyBooking()
        {
            Booking createABooking = new Booking();
            BookingDates createBookingDates = new BookingDates();

            //createABooking.Firstname = "Gergely";
            createABooking.Lastname = "Szucs";
            createABooking.Totalprice = 1986;
            createABooking.Depositpaid = true;
            createABooking.Bookingdates = createBookingDates;
            createBookingDates.Checkin = "2022-01-10";
            createBookingDates.Checkout = "2022-01-10";
            createABooking.Additionalneeds = "Breakfast";

            return JsonConvert.SerializeObject(createABooking);
        }
        public static string CreateUpdateBooking()
        {
            Booking createABooking = new Booking();
            BookingDates createBookingDates = new BookingDates();

            createABooking.Firstname = "Updated_Gergely";
            createABooking.Lastname = "Szucs";
            createABooking.Totalprice = 1986;
            createABooking.Depositpaid = true;
            createABooking.Bookingdates = createBookingDates;
            createBookingDates.Checkin = "2022-01-10";
            createBookingDates.Checkout = "2022-01-10";
            createABooking.Additionalneeds = "Breakfast";

            return JsonConvert.SerializeObject(createABooking);
        }
    }
}
