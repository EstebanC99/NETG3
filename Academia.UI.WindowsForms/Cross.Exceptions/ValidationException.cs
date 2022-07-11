using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cross.Exceptions
{
    public class ValidationException : Exception
    {
        private const string SIMBOLO_ITEM_VALIDACIONES = "- ";

        #region Constructores

        public ValidationException() : base() { }

        public ValidationException(string mensaje) : base(mensaje) { }

        protected List<ValidationResult> ValidationResults { get; private set; } = new List<ValidationResult>();

        #endregion

        public void AddValidationResult(String message)
        {
            this.ValidationResults.Add(new ValidationResult(message));
        }

        public void Throw()
        {
            if (this.ValidationResults.Any())
            {
                throw new ValidationException(this.GenerateExceptionMessage());
            }
        }

        private string GenerateExceptionMessage()
        {
            string exceptionMessage = String.Empty;

            if (this.ValidationResults.Any())
            {
                var sb = new StringBuilder();

                foreach (var vr in this.ValidationResults)
                {
                    sb.Append(SIMBOLO_ITEM_VALIDACIONES);
                    sb.Append(vr.Message);
                    sb.Append(Environment.NewLine);
                }

                exceptionMessage = sb.ToString();
            }

            return exceptionMessage;
        }
    }
}
