using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Newtonsoft.Json;

namespace ToDoAPI.DomainModels
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description{ get; set; }
        public bool Complete { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}
