namespace DataService.DTOS
{
    public class DepartmentDTO
    {
        public string DepartmentName { get; set; }
        public List<string> ResponsibleEmployeesEmail { get; set; } = new List<string>();
    }
}
