﻿using eCommerce.API.Models;
using eCommerce.API.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private iUsuarioRepository _repository;

        public UsuariosController()
        {
            _repository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get() 
        {
            return Ok(_repository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)

        {
            var usuario = _repository.Get(id);

            if (usuario == null)
            {
                return NotFound(); //Erro HTTP 404 - Not Found
            }
            return Ok(_repository.Get(id));
        }

        [HttpPost]
        public IActionResult insert(Usuario usuario)
        {
            _repository.Insert(usuario);
            return Ok(usuario);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Usuario usuario)
        {
            _repository.Update(usuario);
            return Ok(usuario);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id) 
        {
            _repository.Delete(id);
            return Ok();
        
        }

    }
}
