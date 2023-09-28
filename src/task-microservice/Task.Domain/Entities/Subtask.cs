﻿namespace Domain.Entities
{
    public class Subtask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public Task Task { get; set; }
    }
}
