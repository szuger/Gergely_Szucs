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
    public class UpdateStepDefinitions
    {
        readonly string bookingToSend = BookingObjects.CreateABooking();
        readonly string updateBooking = BookingObjects.CreateUpdateBooking();
        Booking? requestBooking;
        Booking? myBooking;
        CreatedBooking? responseBooking;
        HttpResponseMessage? postResponese;
        HttpStatusCode statusCode = HttpStatusCode.OK;
        string? responseContent;
        int id;

        [Given(@"I have the id of the updated booking")]
        public void GivenIHaveTheIdOfTheUpdatedBooking()
        {
            postResponese = Crud.PostNewBooking(bookingToSend);
            responseContent = postResponese.Content.ReadAsStringAsync().Result;
            responseBooking = JsonConvert.DeserializeObject<CreatedBooking>(responseContent);
            id = responseBooking.Bookingid;
            requestBooking = JsonConvert.DeserializeObject<Booking>(bookingToSend);
        }

        [When(@"I send booking with updated firstname")]
        public void WhenISnedBookingWithUpdatedFirstname()
        {
            postResponese = Crud.UpdateBooking(id, updateBooking);
        }

        [Then(@"I get back the Ok statuse code")]
        public void ThenIGetBackTheOkStatuseCode()
        {
            statusCode = postResponese.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);
        }

        [Then(@"I get back the booking with the updated first name")]
        public void ThenIGetBackTheBookingWithTheUpdatedFirstName()
        {
            responseContent = postResponese.Content.ReadAsStringAsync().Result;
            myBooking = JsonConvert.DeserializeObject<Booking>(responseContent);
            Booking updatebokingObject = JsonConvert.DeserializeObject<Booking>(updateBooking);
            Assert.AreEqual(updatebokingObject.Firstname, myBooking.Firstname);
        }

        [Given(@"I have a non exisitng booking ID")]
        public void GivenIHaveANonExisitngBookingID()
        {
            id =99999;
        }

        [When(@"I try to update the booking")]
        public void WhenITryToUpdateTheBooking()
        {
            postResponese = Crud.UpdateBooking(id, updateBooking);
        }

        [Then(@"I get back a Method Not Allowed status code\.")]
        public void ThenIGetBackAMethodNotAllowedStatusCode_()
        {
            statusCode = postResponese.StatusCode;
            Assert.AreEqual(HttpStatusCode.MethodNotAllowed, statusCode);
        }
    }
}
