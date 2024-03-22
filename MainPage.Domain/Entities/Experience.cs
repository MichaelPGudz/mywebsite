namespace MainPage.Domain.Entities
{
    public class Experience
    {
        public int Id { get; set; }
        public required string JobTitle { get; set; }
        public required string CompanyName { get; set; }
        public required string Location { get; set; }
        public bool IsRemote { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IEnumerable<WorkDetail>? Description { get; set; }
    }
}
