namespace PersonApi.Models  // ✅ Ensure this matches the reference in other files
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;
    }
}
