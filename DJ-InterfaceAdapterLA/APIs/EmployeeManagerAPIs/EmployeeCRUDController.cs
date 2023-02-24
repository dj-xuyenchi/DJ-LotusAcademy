using DJ_UseCaseLayer.Business.EmployeeManager;
using DJ_WebDesignCore.Business.EmployeeManager;
using DJ_WebDesignCore.DTOs.EmployeeManagerDTOs.EmployeeCRUDDTOs;
using DJ_WebDesignCore.Entites.Employee;
using Microsoft.AspNetCore.Mvc;

namespace DJ_InterfaceAdapterLA.APIs.EmployeeManagerAPIs
{
    public class EmployeeCRUDController : BaseAPI
    {

        private readonly IEmployeeCRUD _employeeCRUD;
        public EmployeeCRUDController()
        {
            _employeeCRUD = new EmployeeCRUD();
        }
        [HttpPost("EmployeeCRUD")]
        public ActionResult<EmployeeCreateDTO> createEmployee(EmployeeLA employeeLA)
        {
            return Ok(_employeeCRUD.createEmployee(employeeLA));
        }
        [HttpDelete("EmployeeCRUD/{employeeID}")]
        public ActionResult<EmployeeDeleteDTO> deleteEmployee(int? employeeID)
        {
            return Ok(_employeeCRUD.deleteEmployee(employeeID));
        }
        [HttpPut("EmployeeCRUD")]
        public ActionResult<EmployeeUpdateDTO> updateEmployee(EmployeeLA employeeLA)
        {
            return Ok(_employeeCRUD.updateEmployee(employeeLA));
        }

    }
}
