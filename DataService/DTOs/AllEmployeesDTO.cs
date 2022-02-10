namespace DataService.DTOS
{
    public class AllEmployeesDTO
    {
        public int EmployeeCount { get; set; }
        public List<EmployeeInfoDTO> EmployeeList { get; set; } = new List<EmployeeInfoDTO>();
    }
}
