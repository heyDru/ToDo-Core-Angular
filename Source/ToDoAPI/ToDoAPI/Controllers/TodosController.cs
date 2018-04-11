using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ToDoAPI.Controllers
{
    public class TodosController : Controller
    {

        public TodosController()
        {
            
        }

        public async Task<string> Get()
        {
            return "dfdf";
        }
    }
}