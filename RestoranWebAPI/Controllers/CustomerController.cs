using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Interfaces;
using Application.Requests.CustomerRequests;
using Application.Responses.CustomerResponses;
using Domain.Entities;

namespace RestoranWebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    private readonly IBaseService<Customer> _customerService;
    private readonly IMapper _mapper;

    public CustomerController(IBaseService<Customer> customerService, IMapper mapper)
    {
        _customerService = customerService;
        _mapper = mapper;
    }

    [HttpPost(ApiEndpoints.Customer.Create)]
    public async Task<IActionResult> Create([FromBody] CreateCustomerRequestModel request, CancellationToken token)
    {
        var customer = _mapper.Map<Customer>(request);

        var response = await _customerService.CreateAsync(customer, token);
        return CreatedAtAction(nameof(Get), new { id = response.Id }, response);
    }
    [HttpGet(ApiEndpoints.Customer.Get)]
    public async Task<IActionResult> Get([FromRoute] int id, CancellationToken token)
    {
        var isCustomerExist = await _customerService.GetAsync(id);
        if (isCustomerExist == null)
        {
            return NotFound();
        }
        var response = _mapper.Map<CustomerResponseModel>(isCustomerExist);
        return response == null ? NotFound() : Ok(response);
    }

    [HttpPut(ApiEndpoints.Customer.Update)]
    public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateCustomerRequestModel? request, CancellationToken token)
    {
        if (request == null)
        {
            return BadRequest("Invalid request data.");
        }

        Customer customer = _mapper.Map<Customer>(request);

        await _customerService.UpdateAsync(customer, token);

        var response = _mapper.Map<CustomerRequestModel>(customer);

        return response == null ? NotFound() : Ok(response);
    }

    [HttpDelete(ApiEndpoints.Customer.Delete)]
    public async Task<IActionResult> Delete([FromRoute] int id, CancellationToken token)
    {
        var response = await _customerService.DeleteAsync(id, token);

        return response ? Ok() : NotFound($"Customer with ID {id} not found.");
    }
}


