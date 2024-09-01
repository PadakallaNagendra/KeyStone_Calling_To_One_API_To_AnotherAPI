using KeyStoneEmployeeManageMent_businessObject.Entities;
using KeyStoneEmployeeManageMent_businessObject.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyStoneEmployeeManageMent_ServiceLayer
{
    public class EmployeeService : IEmployeeService
    {
        public IEmployeeRepositary _EmployeeRepositary;
        public EmployeeService(IEmployeeRepositary employeeRepositary)
        {
                _EmployeeRepositary = employeeRepositary;
        }
        public async Task<string> DeleteCMSEmployeesData(int id)
        {
          var a=await _EmployeeRepositary.DeleteCMSEmployeesData(id);
            return a;
        }

        public async Task<string> InsertCMSEmployeesData(Employee employee)
        {
             return await _EmployeeRepositary.InsertCMSEmployeesData(employee);
        }

        public async Task<string> InvokeCMSEmployeesById(int id)
        {
            return await this._EmployeeRepositary.InvokeCMSEmployeesById(id);
        }

        public async Task<string> InvokeCMSEmployeesList()
        {
            return await this._EmployeeRepositary.InvokeCMSEmployeesList();
        }

        public async Task<string> UpdateCMSEmployeesData(Employee employee, int id)
        {
            return await this._EmployeeRepositary.UpdateCMSEmployeesData(employee, id);
        }
    }
}
