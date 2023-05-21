namespace Lorem_PayRoll_System.DTO
{
    public class FullTimeEmployeeDto
    {
        public int Id { get; set; }        
        public string FirstName { get; set; } = null!;      
        public string LastName { get; set; } = null!;     
        public DateTime DateOfBirth { get; set; }      
        public string Gender { get; set; } = null!;      
        public string EmployeeType { get; set; } = null!;    
        public int PinNumber { get; set; }      
        public int EmployeeNumber { get; set; }       
        public double MonthsWorked { get; set; }      
        public decimal Salary { get; set; }
        public decimal PayPerMonth { get; set; }
    }
}
