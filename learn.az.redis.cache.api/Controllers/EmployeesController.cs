using learn.az.redis.cache.lib.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace learn.az.redis.cache.api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly ILogger<EmployeesController> _logger;

        private readonly ITextCacheManager _textCacheManager;

        private readonly DatabaseRepository _databaseRepository;

        public EmployeesController(ILogger<EmployeesController> logger,
            DatabaseRepository databaseRepository,
            ITextCacheManager textCacheManager)
        {
            _logger = logger;
            _databaseRepository = databaseRepository;
            _textCacheManager = textCacheManager;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            IEnumerable<Employee> employees;

            var result = await _textCacheManager.GetAsync("all");

            if (result == null)
            {
                employees = _databaseRepository.GetAllEmployees();

                await _textCacheManager.Set("all", JsonSerializer.Serialize(employees));
            }
            else
            {
                employees = JsonSerializer.Deserialize<IEnumerable<Employee>>(result);
            }

            return await Task.FromResult(employees);
        }
    }
}
