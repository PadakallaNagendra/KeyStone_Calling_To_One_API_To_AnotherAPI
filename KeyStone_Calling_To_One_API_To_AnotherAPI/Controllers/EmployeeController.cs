using KeyStoneEmployeeManageMent_businessObject.Entities;
using KeyStoneEmployeeManageMent_businessObject.InterFace;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KeyStone_Calling_To_One_API_To_AnotherAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService= employeeService;
        }
        [HttpGet]
        [Route("InvokeCMSEmployeesList")]
        public async Task<string> InvokeCMSEmployeesList()
        {
            return await _employeeService.InvokeCMSEmployeesList();
        }

        [HttpGet]
        [Route("InvokeCMSEmployeesById/{id}")]
        public async Task<string> InvokeCMSEmployeesById(int id)
        {
            return await _employeeService.InvokeCMSEmployeesById(id);
        }
        [HttpPost]
        [Route("InsertCMSEmployeesData")]
        public async Task<string> InsertAceDetails([FromBody] Employee employee)
        {
            return await _employeeService.InsertCMSEmployeesData(employee);
        }
        [HttpPost]
        [Route("UpdateCMSEmployeesData/{id}")]
        public async Task<string> UpdateCMSEmployeesData([FromBody] Employee employee , [FromRoute] int id)
        {
            return await _employeeService.UpdateCMSEmployeesData(employee, id);
        }
        [HttpDelete]
        [Route("DeleteCMSEmployeesData/{id}")]
        public async Task<string> DeleteCMSEmployeesData(int id)
        {
            return await _employeeService.DeleteCMSEmployeesData(id);
        }

    }
}
