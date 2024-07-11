namespace testchallenge.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
        public string? Cnpj { get; set; }
        public decimal Balance { get; set; }
    }
}
