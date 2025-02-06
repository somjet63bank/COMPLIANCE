namespace COMPLIANCE.Models.Entities
{
    public class Role
    {
        public Int32 id { get; set; }
        public string role_name { get; set; }
        public string role_desc { get; set; }
        public string? record_status { get; set; }
        public DateTime? created_date { get; set; }
        public string? created_by { get; set; }
        public DateTime? updated_date { get; set; }
        public string? updated_by { get; set; }
    }
}
