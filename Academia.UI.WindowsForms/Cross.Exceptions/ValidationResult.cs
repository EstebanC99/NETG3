using System;

namespace Cross.Exceptions
{
    public class ValidationResult
    {
        public Guid ID { get; set; }

        public String Message { get; set; }

        public ValidationResult()
        {
        }

        public ValidationResult(String message) : this()
        {
            ID = Guid.NewGuid();
            Message = message;
        }
    }
}
