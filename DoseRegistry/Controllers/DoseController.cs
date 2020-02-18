using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoseRegistry.Core;
using DoseRegistry.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DoseRegistry.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoseController : ControllerBase
    {
        private readonly IDoseData _database;
        private readonly ILogger<DoseController> _logger;

        public DoseController(IDoseData database, ILogger<DoseController> logger)
        {
            _database = database;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Dose> Get()
        {
            return _database.GetAll();
        }
    }
}
