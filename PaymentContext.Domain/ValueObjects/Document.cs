using Paymentcontext.Shared.ValueObjects;
using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects;

public class Document : ValueObject
{
    public Document(string number, EDocumentType type)
    {
        Number = number;
        Type = type;
    }

    public string Number { get; set; }
    public EDocumentType Type { get; private set; }
}