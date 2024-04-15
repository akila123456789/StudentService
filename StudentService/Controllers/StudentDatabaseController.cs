using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Entites;
using Dapper;
using System.Data.SqlClient;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentDatabaseController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public StudentDatabaseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private SqlConnection SqlConnection() => new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sql = "SELECT * FROM Student";
            using (var connection = SqlConnection())
            {
                var students = await connection.QueryAsync<Student>(sql);
                return Ok(students);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sql = "SELECT * FROM Student WHERE id = @Id";
            using (var connection = SqlConnection())
            {
                var students = await connection.QueryAsync<Student>(sql, new { Id = id });
                if (students == null)
                {
                    return NotFound();
                }

                return Ok(students);
            }

        }
        [HttpPut]
        public async Task<IActionResult> UpdateById(int id)
        {
            var sql = "SELECT * FROM Student";
            using (var connection = SqlConnection())
            {
                var students = await connection.QueryAsync<Student>(sql);
                return Ok(students);
            }

        }
        [HttpDelete]
        public async Task<IActionResult> DeleteById(int id)
        {
            var sql = "SELECT * FROM Student";
            using (var connection = SqlConnection())
            {
                var students = await connection.QueryAsync<Student>(sql);
                return Ok(students);
            }

        }



    }
}