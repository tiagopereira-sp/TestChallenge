namespace testchallenge.Domain.Dtos
{
    public class TransferDto
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amount { get; set; }
    }
}
