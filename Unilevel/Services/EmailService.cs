﻿using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

public class EmailService
{
    private readonly ISendGridClient _sendGridClient;
    private readonly string _fromEmail = "nguyenphucdinh88@gmail.com";

    public EmailService(ISendGridClient sendGridClient)
    {
        _sendGridClient = sendGridClient;
    }


    //gui mail
    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var from = new EmailAddress(_fromEmail, "Unilevel");
        var to = new EmailAddress(toEmail);
        var msg = MailHelper.CreateSingleEmail(from, to, subject, body, body);

        var response = await _sendGridClient.SendEmailAsync(msg);


        if (response.StatusCode != System.Net.HttpStatusCode.OK)
        {
            var responseBody = await response.Body.ReadAsStringAsync();
            throw new Exception($"Email sending failed. Status Code: {response.StatusCode}, Response Body: {responseBody}");
        }
    }

}
