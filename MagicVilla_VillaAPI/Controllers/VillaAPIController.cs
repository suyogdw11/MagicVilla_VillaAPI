﻿using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        public IEnumerable<Villa> GetVillas()
        {
            return new List<Villa>
           {
               new Villa{ Id =1 , Name="Pool View"},
               new Villa{ Id =2, Name="Beach View"}
           };
        }
    }
}
