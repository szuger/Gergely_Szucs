using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WebApiHomeTask
{
    public class Crud
    {
        private static readonly string URL = "https://restful-booker.herokuapp.com";

        public static HttpResponseMessage GetBookings()
        {
            var bookingUrl = URL + "/booking/";
            HttpClient httpClient = new HttpClient();
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
        public static HttpResponseMessage GetBookingById(int i)
        {
            var bookingUrl = URL + "/booking/" + i;
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage { RequestUri = new Uri(bookingUrl), Method = HttpMethod.Get };
            try
            {
                request.Headers.Add("Accept", "application/json");
                var response = httpClient.SendAsync(request).Result;
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
            HttpClient httpClient = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage { RequestUri = new Uri(bookingUrl), Method = HttpMethod.Post };
            try
            {
                request.Content = new StringContent(booking, Encoding.UTF8, "application/json");
                request.Headers.Add("Accept", "application/json");
                var response = httpClient.SendAsync(request).Result;
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally { httpClient.Dispose(); }
        }
        public static HttpResponseMessage UpdateBooking(int ID, string booking)
        {
            var bookingUrl = URL + "/booking/" + ID;
            HttpClient httpClient = new();
            HttpRequestMessage request = new() { RequestUri = new Uri(bookingUrl), Method = HttpMethod.Put };
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
            finally { httpClient.Dispose(); }
        }
        public static HttpResponseMessage DeleteBookingById(int i)
        {
            var bookingUrl = URL + "/booking/" + i;
            HttpClient httpClient = new HttpClient();
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
            finally { httpClient.Dispose(); }
        }
    }
}
