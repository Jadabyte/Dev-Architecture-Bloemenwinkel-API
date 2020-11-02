using BasicRestApi.Models.Domain;
using BasicRestAPI.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;

//Get all products
public class ProductsController : ControllerBase
{
    static readonly ProductRepository repository = new ProductRepository();
    public IEnumerable<Product> GetAllProducts()
    {
        return repository.GetAll();
    }

    //Get products By id
    public Product GetProduct(int id)
    {
        Product item = repository.Get(id);
        if (item == null)
        {
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }
        return item;
    }
//Get products By Category
    public IEnumerable<Product> GetProductsByCategory(string category)
    {
        return repository.GetAll().Where(
            p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase));
    }
// creates new products


    public HttpResponseMessage PostProduct(Product item)
    {
        item = repository.Add(item);
        var response = Request.CreateResponse<Product>(HttpStatusCode.Created, item);

        string uri = Url.Link("DefaultApi", new { id = item.Id });
        response.Headers.Location = new Uri(uri);
        return response;
    }
//update product
    public void PutProduct(int id, Product product)
    {
        product.Id = id;
        if (!repository.Update(product))
        {
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }

    }

//delete products
    public void DeleteProduct(int id)
    {
        Product item = repository.Get(id);
        if (item == null)
        {
            throw new HttpResponseException(HttpStatusCode.NotFound);
        }

        repository.Remove(id);
    }
    
}
