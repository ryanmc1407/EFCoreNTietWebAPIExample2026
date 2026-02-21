using ClassLibrary1.Interfaces;
using ClassLibrary1.Respositories;
using ClassLibrary1;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

using Tracker.WebAPIClient;
namespace RAD302Week3Lab12026WebAPIS00236888
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomer<Customer> _repository;

        public CustomerController(ICustomer<Customer> repository)
        {
            _repository = repository;
        }

        // Must decorate for swagger
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            ActivityAPIClient.Track(StudentID: "S00236888", StudentName: "Ryan McClelland", activityName: "Rad302 Week 3 Lab 1", Task: "Testing Basic Controller Call");

            return _repository.GetAll();
        }
    }
}
