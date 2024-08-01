using BasicCrudApiWithOData.EntityFrameworkCore;
using BasicCrudApiWithOData.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;

namespace BasicCrudApiWithOData.Controllers;

public class CustomersController(BasicCrudDbContext db) : ODataController
{
    [EnableQuery(PageSize = 2)]
    public ActionResult<IQueryable<Customer>> Get()
    {
        return Ok(db.Customers);
    }
    
    public ActionResult<Customer> Get([FromRoute] int key)
    {
        Customer? customer = db.Customers.SingleOrDefault(d => d.Id == key);

        if (customer == null)
        {
            return NotFound();
        }

        return Ok(customer);
    }
    
    public ActionResult<Customer> Post([FromBody] Customer customer)
    {
        db.Customers.Add(customer);
        db.SaveChanges();

        return Created(customer);
    }
    
    public ActionResult<Customer> Put([FromRoute] int key, [FromBody] Customer customer)
    {
        if (key != customer.Id)
        {
            return BadRequest();
        }

        db.Entry(customer).State = EntityState.Modified;
        db.SaveChanges();

        return Updated(customer);
    }
    
    public ActionResult Delete([FromRoute] int key)
    {
        Customer? customer = db.Customers.SingleOrDefault(d => d.Id == key);

        if (customer == null)
        {
            return NotFound();
        }

        db.Customers.Remove(customer);
        db.SaveChanges();

        return NoContent();
    }
}

