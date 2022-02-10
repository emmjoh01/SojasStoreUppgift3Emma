using DataService.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public DataService.DepartmentService departmentService = new DataService.DepartmentService();

        //För G - Lista namnet på alla avdelningar samt en lista med den som är ansvarig för
        //just den avdelningens E-postadresser

        [HttpGet] //KLAR OCH FUNGERAR
        public List<DepartmentDTO> GetDepartmentAndEmail()
        {
            return departmentService.GetDepartmentsWithResponsibleEmails();
        }
    }
}
