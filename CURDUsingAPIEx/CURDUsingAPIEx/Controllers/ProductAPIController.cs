using CURDUsingAPIEx.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CURDUsingAPIEx.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {
        CompanyContext cc;
        public ProductAPIController(CompanyContext cc)
        {
            this.cc = cc;
        }
        /// <summary>
        /// Action used to Retrive All Products from Database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.cc.Products.ToList());
        }

        /// <summary>
        /// Action used to Retrive Product using Prdouct ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult GetProductById(Int64 id)
        {
            if (id == 0)
                return BadRequest();
            var v = this.cc.Products.Find(id);
            if (v != null)
                return Ok(v);
            else
                return NotFound();
        }
        /// <summary>
        /// Action to Create New Product
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>

        [HttpPost]
        public IActionResult CreateProduct(Product rec)
        {
            if (rec == null)
                return BadRequest();

            if (ModelState.IsValid)
            {
                this.cc.Products.Add(rec);
                this.cc.SaveChanges();
                return Ok("Product Saved!");
            }

            return BadRequest(ModelState);
        }

        /// <summary>
        /// Action to Modify/Update Product
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UpdateProduct(Product rec)
        {
            if (rec == null)
                return BadRequest();

            if (ModelState.IsValid)
            {
                this.cc.Entry(rec).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                this.cc.SaveChanges();
                return Ok("Product Updated!");
            }

            return BadRequest(ModelState);
        }



        /// <summary>
        /// Action to Patch Project using Json Patch
        /// </summary>
        /// <param name="id"></param>
        /// <param name="patch"></param>
        /// <returns></returns>

        [HttpPatch("{id}")]
        public IActionResult UpdateProduct(Int64 id,JsonPatchDocument<Product> patch)
        {
            if (patch == null)
                return BadRequest();

            var oldrec = this.cc.Products.Find(id);
            patch.ApplyTo(oldrec);
                this.cc.SaveChanges();
                return Ok("Product Patched!");
        }

        /// <summary>
        /// Used to Delete Product using ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete("{id}")]
        public IActionResult Delete(Int64 id)
        {
            if (id <= 0)
                return BadRequest();
            var rec = this.cc.Products.Find(id);
            if (rec == null)
                return NotFound();
            this.cc.Products.Remove(rec);
            this.cc.SaveChanges();
            return Ok("Record Deleted!");
        }
    }
}
