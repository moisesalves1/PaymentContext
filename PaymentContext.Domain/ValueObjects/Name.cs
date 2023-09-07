using Paymentcontext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects;

public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        if(string.IsNullOrEmpty(FirstName))
            AddNotification("Name.FirstName", "Nome Inválido");
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
}