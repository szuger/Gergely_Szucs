using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebApiHomeTask.Models.Request;
using WebApiHomeTask.Models.Rresponse;

namespace WebApiHomeTask
{
    class WebApPI
    {
        private static readonly string URL = "https://restful-booker.herokuapp.com";
        public static HttpResponseMessage GetBookings()
        {
            var bookingsURL = URL + "/booking/";
            HttpClient httpClient = new();
            try
            {
                var httpResponseMessage = httpClient.GetAsync(bookingsURL);
                var response = httpResponseMessage.Result;
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                httpClient.Dispose();
            }
        }
        public static HttpResponseMessage GetBookingById(int i)
        {
            var bookingUrl = URL + "/booking/" + i;
            HttpClient httpClient = new();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                var httpResponseMessage = httpClient.GetAsync(bookingUrl);
                var response = httpResponseMessage.Result;
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                httpClient.Dispose();
            }
        }
        public static HttpResponseMessage PostNewBooking(string booking)
        {
            var bookingUrl = URL + "/booking/";
            HttpClient httpClient = new();
            HttpRequestMessage request = new() { RequestUri = new Uri(bookingUrl), Method = HttpMethod.Post };
            request.Content = new StringContent(booking, Encoding.UTF8, "application/json");
            request.Headers.Add("Accept", "application/json");
            try
            {
                var response = httpClient.SendAsync(request).Result;
                //Console.WriteLine(response.StatusCode);
                //Console.WriteLine((int)response.StatusCode);
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                httpClient.Dispose();
            }
        }
        public static HttpResponseMessage UpdateBooking(int ID,string booking)
        {
            var bookingUrl = URL + "/booking/" + ID;
            HttpClient httpClient = new();
            HttpRequestMessage request = new() { RequestUri = new Uri(bookingUrl), Method = HttpMethod.Put };
            //httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + "YWRtaW46cGFzc3dvcmQxMjM=");
            request.Content = new StringContent(booking, Encoding.UTF8, "application/json");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", "Basic " + "YWRtaW46cGFzc3dvcmQxMjM=");
            try
            {
                var response = httpClient.SendAsync(request).Result;
                Console.WriteLine(response.StatusCode);
                Console.WriteLine((int)response.StatusCode);
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                httpClient.Dispose();
            }
        }
        public static HttpResponseMessage DeleteBookingById(int i)
        {
            var bookingUrl = URL + "/booking/" + i;
            HttpClient httpClient = new();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + "YWRtaW46cGFzc3dvcmQxMjM=");
            try
            {
                var httpResponseMessage = httpClient.DeleteAsync(bookingUrl);
                var response = httpResponseMessage.Result;
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                httpClient.Dispose();
            }
        }
        private static string CreateABooking()
        {
            Booking newBooking = new();
            BookingDates createBookingDates = new();
            newBooking.Firstname = "Gergely";
            newBooking.Lastname = "Szucs";
            newBooking.Totalprice = 1986;
            newBooking.Depositpaid = true;
            newBooking.Bookingdates = createBookingDates;
            createBookingDates.Checkin = "2022-01-10";
            createBookingDates.Checkout = "2022-01-10";
            newBooking.Additionalneeds = "Breakfast";
            
            return JsonConvert.SerializeObject(newBooking);
        }

        private static string UpdateABooking()
        {
            Booking updatedBooking = new();
            BookingDates createBookingDates = new();
            updatedBooking.Firstname = "Updated_Firstname";
            updatedBooking.Lastname = "Updated_Lastname";
            updatedBooking.Totalprice = 1;
            updatedBooking.Depositpaid = false;
            updatedBooking.Bookingdates = createBookingDates;
            createBookingDates.Checkin = "2022-01-04";
            createBookingDates.Checkout = "2022-01-10";
            updatedBooking.Additionalneeds = "Updated_Breakfast";

            return JsonConvert.SerializeObject(updatedBooking);
        }
        static async Task Main(string[] args)
        {

            var response = PostNewBooking(UpdateABooking());
            var contentString = response.Content.ReadAsStringAsync();
            CreatedBooking createdBooking = JsonConvert.DeserializeObject<CreatedBooking>(await contentString.ConfigureAwait(false));
            //var allbooking =await GetBookings().Content.ReadAsStringAsync();
            //Console.WriteLine(allbooking);
            Console.WriteLine(createdBooking.Bookingid);
            Console.WriteLine(response.StatusCode);
            //DeleteBookingById(1054);
            //UpdateBooking(4293,UpdateABooking());
            Console.WriteLine(UpdateBooking(594, UpdateABooking()).ToString());
        }
    }

}