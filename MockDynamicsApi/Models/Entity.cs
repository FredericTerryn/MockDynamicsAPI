namespace MockDynamicsApi.Models
{
    public class Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<Record> Records { get; set; }
    }
}