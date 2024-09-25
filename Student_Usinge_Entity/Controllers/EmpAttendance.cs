namespace Student_Usinge_Entity.Controllers
{
    public class EmpAttendance
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int EmployeeID { get; set; }
        public string EmpName { get; set; } = "";
        public string CurrentLocation { get; set; } = "";
        public DateTime? CheekIN { get; set; }
        public DateTime? CheekOUT { get; set; }
        public string TimeZone { get; set; } = "";
    }
}
