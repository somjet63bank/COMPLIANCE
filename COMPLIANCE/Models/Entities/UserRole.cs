namespace COMPLIANCE.Models.Entities
{
    public class UserRole
    {
        public string username { get; set; }
        public Int64 role_id { get; set; }
        public DateTime? created_date { get; set; }
        public string? created_by { get; set; }
        public DateTime? updated_date { get; set; }
        public string? updated_by { get; set; }
        public string? record_status { get; set; }
    }
}
