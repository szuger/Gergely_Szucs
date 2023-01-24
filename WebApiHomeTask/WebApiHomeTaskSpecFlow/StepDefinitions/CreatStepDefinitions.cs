using WebApiHomeTask.Models.Request;
using WebApiHomeTask.Objects;
using System;
using System.Net;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using NUnit.Framework;
using WebApiHomeTask.Models.Response;
using WebApiHomeTask;

namespace WebAPIspecflow.StepDefinitions
{
    [Binding]
    public class CreatStepDefinitions
    {
        string bookingToSend = BookingObjects.CreateABooking();
        Booking? requestBooking;
        CreatedBooking? responseBooking;
        HttpResponseMessage? postResponse;
        HttpStatusCode statusCode = HttpStatusCode.OK;
        string? responseContent;
        
        [Given(@"I have the data for a new booking")]
        public void GivenIHaveTheDataForANewBooking()
        {
            requestBooking = JsonConvert.DeserializeObject<Booking>(bookingToSend);
        }

        [When(@"I send the booking to the online service\.")]
        public void WhenISendTheBookingToTheOnlineService_()
        {
            postResponse = Crud.PostNewBooking(bookingToSend);
        }

        [Then(@"I get back the OK status code")]
        public void ThenIGetBackTheOKStatusCode()
        {
            statusCode = postResponse.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
        }

        [Then(@"I get back new booking data")]
        public void ThenIGetBackNewBookingData()
        {
            responseContent = postResponse.Content.ReadAsStringAsync().Result;
            responseBooking = JsonConvert.DeserializeObject<CreatedBooking>(responseContent);
            Assert.AreEqual(requestBooking.Firstname, responseBooking.Booking.Firstname);
        }


        [Given(@"I have deficient data for a new booking")]
        public void GivenIHaveDeficientDataForANewBooking()
        {
            bookingToSend = BookingObjects.CreateABadBodyBooking();
            requestBooking = JsonConvert.DeserializeObject<Booking>(bookingToSend);
        }

        [When(@"I send the deficient booking data to the online service\.")]
        public void WhenISendTheDeficientBookingDataToTheOnlineService_()
        {
            postResponse = Crud.PostNewBooking(bookingToSend);
        }

        [Then(@"I get back an Internal Server Error status code\.")]
        public void ThenIGetBackAnInternalServerErrorStatusCode_()
        {
            statusCode = postResponse.StatusCode;
            Assert.AreEqual(HttpStatusCode.InternalServerError, statusCode);
        }
    }
}
