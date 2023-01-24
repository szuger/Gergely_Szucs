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
    public class DeleteStepDefinitions
    {
        string bookingToSend = BookingObjects.CreateABooking();
        CreatedBooking? responseBooking;
        HttpResponseMessage? postResponse;
        HttpStatusCode statusCode = HttpStatusCode.OK;
        int id;
    
        [Given(@"I have my booking on the server")]
        public void GivenIHaveMyBookingOnTheServer()
        {
            postResponse = Crud.PostNewBooking(bookingToSend);
            responseBooking = JsonConvert.DeserializeObject<CreatedBooking>(postResponse.Content.ReadAsStringAsync().Result);
            id = responseBooking.Bookingid;
        }

        [When(@"I send my booking ID to the server")]
        public void WhenISendMyBookingIDToTheServer()
        {
            postResponse = Crud.DeleteBookingById(id);
        }

        [Then(@"I get back the Created status code")]
        public void ThenIGetBackTheCreatedStatusCode()
        {
            statusCode = postResponse.StatusCode;
            Assert.AreEqual(HttpStatusCode.Created, statusCode);
        }

        [Given(@"I have my deleted booking ID")]
        public void GivenIHaveMyDeletedBookingID()
        {
            Console.WriteLine("I use the id that I used in the steps before_" + id);
        }

        [When(@"I send the ID to delete booking")]
        public void WhenISendTheIDToDeleteBooking()
        {
            postResponse = Crud.DeleteBookingById(id);
        }

        [Then(@"I get back a Method Not Allowed status")]
        public void ThenIGetBackAMethodNotAllowedStatus()
        {
            statusCode = postResponse.StatusCode;
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, statusCode);
        }
    }
}
