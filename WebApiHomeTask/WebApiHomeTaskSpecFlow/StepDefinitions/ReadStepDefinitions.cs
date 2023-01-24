using WebApiHomeTask.Models.Request;
using WebApiHomeTask.Objects;
using System;
using System.Net;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using NUnit.Framework;
using WebApiHomeTask.Models.Response;
using WebApiHomeTask;
using System.Net.Mail;

namespace WebAPIspecflow.StepDefinitions
{
    [Binding]
    public class ReadStepDefinitions
    {
        readonly string bookingtoSend = BookingObjects.CreateABooking();
        Booking? requestBooking;
        Booking? myBooking;
        CreatedBooking? responseBooking;
        HttpResponseMessage? postResponse;
        HttpStatusCode statusCode = HttpStatusCode.OK;
        int id;
        string? responseContent;

        [Given(@"My booking on the server")]
        public void GivenMyBookingOnTheServer()
        {
            postResponse = Crud.PostNewBooking(bookingtoSend);
            responseContent = postResponse.Content.ReadAsStringAsync().Result;
            responseBooking = JsonConvert.DeserializeObject<CreatedBooking>(responseContent);
            id = responseBooking.Bookingid;
            requestBooking = JsonConvert.DeserializeObject<Booking>(bookingtoSend);
        }

        [When(@"I send ID of my booking to the API")]
        public void WhenISendIDOfMyBookingToTheAPI()
        {
            postResponse = Crud.GetBookingById(id);
            responseContent = postResponse.Content.ReadAsStringAsync().Result;
        }

        [Then(@"I get OK status")]
        public void ThenIGetOKStatus()
        {
            statusCode = postResponse.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
        }

        [Then(@"I get my booking data")]
        public void ThenIGetMyBookingData()
        {
            responseContent = postResponse.Content.ReadAsStringAsync().Result;
            myBooking = JsonConvert.DeserializeObject<Booking>(responseContent);
            Assert.AreEqual(requestBooking.Firstname, responseBooking.Booking.Firstname.ToString());
        }

        [Given(@"I have a bad ID")]
        public void GivenIHaveABadID()
        {
           id = 99999;
        }

        [When(@"I send the ID to API")]
        public void WhenISendTheIDToAPI()
        {
            postResponse = Crud.GetBookingById(id);
        }

        [Then(@"I get Not Found status code")]
        public void ThenIGetNotFoundStatusCode()
        {
            statusCode = postResponse.StatusCode;
            Assert.AreEqual(HttpStatusCode.NotFound, statusCode);
        }
    }
}
