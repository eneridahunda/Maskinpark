using Maskinpark.Data;

namespace Maskinpark.Pages
{
    internal class Device
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}