﻿using Microsoft.AspNetCore.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    Route["api/[controller]"]
    public class ApiController : Controller
    {
        private readonly ApplicationDbcontext? dbcontext;

        [HttpGet]
        public class GetData()
        {
            
        }
        
    }
}
