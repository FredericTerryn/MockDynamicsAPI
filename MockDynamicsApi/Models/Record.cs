namespace MockDynamicsApi.Models
{
    public class Record
    {
        public int ID { get; set; }
        public Guid RecordGuid { get; set; }
        public int EntityID { get; set; }
        public Entity Entity { get; set; }
    }
}