using Enhance.Models;
using NUnit.Framework;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Enhance.Steps
{
    [Binding]
    class APISteps
    {
        List<Charity> charities = new List<Charity>();
        [Given(@"I retrieve the charities list")]
        public async Task GivenIRetrieveTheCharitiesListAsync()
        {            
            var client = new RestClient("https://api.trademe.co.nz/v1/");
            var request = new RestRequest("Charities.json");
            charities = await client.GetAsync<List<Charity>>(request);            
            
        }

        [Then(@"I verified the St John is included in the list")]
        public void ThenIVerifiedTheStJohnIsIncludedInTheList()
        {
            var flag = false;
            foreach (var charity in charities)
            {
                if (charity.Description == "St John")                
                    flag = true;
            }
            Assert.IsTrue(flag);
        }

    }
}
