using Application.Common.Interfaces.Repositories;
using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;

namespace Application.Services;

public class CustomerService : IBaseService<Customer>
{
    private readonly IBaseRepository<Customer> _customerRepository;

    public CustomerService(IBaseRepository<Customer> customerRepository)
    {
        _customerRepository = customerRepository;
    }

    public async Task<Customer> CreateAsync(Customer customer, CancellationToken token = default)
    {
        return await _customerRepository.CreateAsync(customer, token);

    }

    public async Task<bool> DeleteAsync(int id, CancellationToken token = default)
    {
        var customer = await _customerRepository.GetAsync(id);
        if (customer == null)
        {
            return false;
        }
        return await _customerRepository.DeleteAsync(customer, token);
    }

    public async Task<IEnumerable<Customer>> GetAllAsync(CancellationToken token = default)
    {
        return await _customerRepository.GetAllAsync(token);
    }

    public async Task<Customer> GetAsync(int id, CancellationToken token = default)
    {
        return await _customerRepository.GetAsync(id, token);
    }

    public async Task<bool> UpdateAsync(Customer customer, CancellationToken token = default)
    {
        var isCustomerExist = await _customerRepository.GetAsync(customer.Id, token);

        if (isCustomerExist == null)
        {
            return false;
        }
        return await _customerRepository.UpdateAsync(customer, token);
    }
}
