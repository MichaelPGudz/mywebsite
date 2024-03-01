namespace MainPage.Domain.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public string? JobTitle { get; set; }
        public string? CompanyName { get; set; }
        public string? Location { get; set; }
        public string? LocationType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IEnumerable<WorkDetail> Description { get; set; }
    }
}
