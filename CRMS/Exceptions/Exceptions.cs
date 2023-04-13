using System;

    namespace CRMS.Exceptions
{
    // Custom exception for when a record cannot be found
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string message) : base(message)
        {
        }

        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    // Custom exception for when a record already exists
    public class EntityAlreadyExistsException : Exception
    {
        public EntityAlreadyExistsException(string message) : base(message)
        {
        }
    }

    // Custom exception for when an operation is not authorized
    public class NotAuthorizedException : Exception
    {
        public NotAuthorizedException(string message) : base(message)
        {
        }
    }


    public class ContactException : Exception
    {
        public ContactException(string message) : base(message)
        {
        }

        public ContactException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class EngagementException : Exception
    {
        public EngagementException(string message) : base(message)
        {
        }

        public EngagementException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class EngagementNotFoundException : Exception
    {
        public EngagementNotFoundException(string id)
            : base($"Engagement with id {id} not found.")
        {
        }
    }

    public class RecordNotFoundException : Exception
    {
        public RecordNotFoundException(string message) : base(message)
        {
        }
    }

    public class RepositoryNullException : Exception
    {
        public RepositoryNullException(string message) : base(message)
        {
        }
    }

    

    // Add more custom exception classes as needed


}
