using Implementation;
using Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using System;
using TechTalk.SpecFlow;
using Types;

namespace CustomersGherkinTests
{
    [Binding]
    public class CustomersSearchSteps
    {
        ICustomerService customerService = new CustomersService(new CustomersRepository());
        Customer customer;

        [Given(@"I have entered (.*)")]
        public void GivenIHaveEntered(string p0)
        {
            customer = customerService.GetCustomer(p0);
        }
        
        [When(@"I press Next")]
        public void WhenIPressNext()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"a customer with '(.*)' and '(.*)' should be returned")]
        public void ThenACustomerWithAndShouldBeReturned(string eponymia, string afm)
        {
            Assert.IsNotNull(customer);
            Assert.AreEqual(customer.EponumiaPelath, eponymia);
            Assert.AreEqual(customer.Afm, afm);
        }
    }
}
