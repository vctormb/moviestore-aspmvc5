using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/customers
        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);

            return Ok(customerDtos);
        }

        //GET /api/customers/1 
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        // POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            // Mapeando um customerDto para um Customer do Model. É preciso para salvar no banco.
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto);
            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDto.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDto);
        }

        // PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            /*
             *  Neste mapeamento para Update é diferente. 
             *  Contém 2 argumentos na passagem de parâmetro (customerDto, customerInDb), pq já temos um objeto que foi buscado no BD.
             *  Desta forma, não é necessário atribuir os valores do formulário para os atributos do objeto que sofrerá o update, pois
             *  os atributos já estão sendo mapeados com o automapper entre o DTO e o Model.
             */
            Mapper.Map(customerDto, customerInDb);


            // Isto não é mais necessário para o Update, pois está sendo realizado com o AutoMapper.
            /*
                customerInDb.Name = customerDto.Name;
                customerInDb.Birthdate = customerDto.Birthdate;
                customerInDb.IsSubscribedToNewsletter = customerDto.IsSubscribedToNewsletter;
                customerInDb.MembershipTypeId = customerDto.MembershipTypeId;
             */
             
            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                return NotFound();

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
