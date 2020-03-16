using Implementation;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;
using TechTalk.SpecFlow;
using Types;

namespace DummyGherkinTests
{
    [Binding]
    public class CustomersSearchSteps
    {
        ICustomerService _customerService = new CustomersService(new CustomersRepository());
        Customer customerResult;

        //[Given(@"that we have some customers")]
        //public void GivenThatWeHaveSomeCustomers()
        //{
            
        //}

        [Given(@"I have entered (.*) into the ΣΥΔΙΠΕΛ field")]
        public void GivenIHaveEnteredIntoTheΣΥΔΙΠΕΛField(string p0)
        {
            customerResult = _customerService.GetCustomer(p0);
        }
        
        [When(@"I press '(.*)'")]
        public void WhenIPress(string p0)
        {
            // for now we do nothing
        }
        
        [Then(@"a customer with the ΣΥΔΙΠΕΛ equal to (.*) should be returned")]
        public void ThenACustomerWithTheSameΣΥΔΙΠΕΛShouldBeReturned(string p0)
        {
            Assert.IsNotNull(customerResult, "No customer was found with Sydipel = " + p0);
            Assert.AreEqual(customerResult.Sydipel, p0);
        }
    }
}
