using BasicRestApi.Models.Domain;
using BasicRestAPI.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

//Get all products
[Route("api/ProductController")]
[ApiController]
public class ValuesController : ControllerBase
{
    
   
        private readonly ProductRepository _repository = new ProductRepository();
    // GET api/controller
    [HttpGet]
    public ActionResult<IEnumerable<string>> GetAllProduct()
    {
        var ProductItems = _repository.GetAll();
        if (ProductItems != null)
        {
            return Ok(ProductItems);
        }
        return NotFound();
    }

    // GET api/value/ by id
    [HttpGet("{id}", Name="GetProductById")]
    public ActionResult<string> GetProduct(int id)
    {
        var ProductItem = _repository.Get(id);
        if (ProductItem != null) { 
        return Ok(ProductItem);
        }
        return NotFound();
    }

    // POST api/values
    [HttpPost]
    public ActionResult<ProductReadDto>CreateProduct(ProductCreateDto productCreateDto)
    {
        var productModel = _mapper.Map<Product>(productCreateDto);
        _repository.CreateProduct(productModel);
        return CreatedAtRoute(nameof(GetProductById), new { Id = ProductReadDto.Id }, ProductReadDto);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public ActionResult PutProduct(int id, ProductUpdateDto productUpdateDto)
    {
        var productModelFromRepo = _repository.GetProductById(id);
        if(productModelFromRepo == null)
        {
            return NotFound();
        }
        _mapper.Map(productUpdateDto, productModelFromRepo);
        _repository.UpdateProduct(productModelFromRepo);
        _repository.SaveChanges();
        return NoContent();
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public ActionResult DeleteProduct(int id)
    {
        var productModelFromRepo = _repository.GetProductById(id);
        if (productModelFromRepo == null)
        {
            return NotFound();
        }
        _repository.DeleteProduct(productModelFromRepo);
        _repository.SaveChanges();
        return NoContent();
    }
}