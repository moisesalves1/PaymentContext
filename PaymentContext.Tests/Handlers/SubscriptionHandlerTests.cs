using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests;

[TestClass]
public class SubscriptionHandlerTests
{
    // Red, Green, Refactor

    [TestMethod]
    public void ShouldReturnErrorWhenDocumentExists()
    {
        var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
        var command = new CreateBoletoSubscriptionCommand();
        command.FirstName = "Bruce";
        command.LastName = "Wayne";
        command.Document = "99999999999";
        command.Email = "hello@balta.io2";
        command.BarCode = "123456789";
        command.BoletoNumer = "12345678987";
        command.PaymentNumber = "123121";
        command.PaidDate = DateTime.Now;
        command.ExpireDate = DateTime.Now.AddMonths(1);
        command.Total = 60;
        command.TotalPaid = 60;
        command.Payer = "Wayne Corp";
        command.PayerDocument = "12345678911";
        command.PayerEmail = "batman@dc.com";
        command.PayerDocumentType = EDocumentType.CPF;
        command.Street = "asdasd";
        command.Number = "asdas";
        command.Neighborhood = "asdada";
        command.City = "asd";
        command.State = "asd";
        command.Country = "as";
        command.ZipCode = "12345678";

        handler.Handle(command);
        Assert.AreEqual(false, handler.Valid);

    }

}
