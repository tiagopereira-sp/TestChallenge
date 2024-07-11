﻿namespace testchallenge.Domain.Entities
{
    public class Transfer
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
