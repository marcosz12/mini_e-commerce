﻿namespace ecommerce.Service.Exceptions
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string? message) : base(message) { }
    }
}
