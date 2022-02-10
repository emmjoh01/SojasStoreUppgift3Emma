using DataService.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        DataService.EmployeeService employeeService = new DataService.EmployeeService();

        //För VG - Skriv ut antal anställda i butiken samt en lista som för varje anställd som innehåller
        //information om dess namn och om den är ansvarig för någon avdelning

        [HttpGet] //KLAR OCH FUNGERAR
        public AllEmployeesDTO GetAllEmployees()
        {
            return employeeService.GetEmployeeISResponsibleList();
        }
    }
}
