using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.Graph;
using System.Net.Http.Headers;
using Outlook = Microsoft.Office.Interop.Outlook;

// First, install the Microsoft Graph .NET Client Library using NuGet:
// Install-Package Microsoft.Graph

namespace DalHazinu
{
   public class EmployeesDL
    {

        HazinuProjectContext _context = new HazinuProjectContext();
        //RETURN NALL EMPLOYEES
       
        public Employees GetEmployeeByEmailPassword(string email,string pass)
        {
            try
            {
                Employees e = _context.Employees.Include(x=>x.IdUserNavigation).Include(x=>x.Job).FirstOrDefault(x => x.Email==email&&x.Password == pass);
                if (e != null)
                    return e;
                else {
                    Employees em = _context.Employees.FirstOrDefault(x => x.Email == email);
                    //יצירת פעיל חדש עם אימייל בלבד בלי יתר הנתונים
                    //כדי שבאנגולר נוכל לאתר אותו ולהחזיר למשתמש שכחתי סיסמה
                    if (em != null)
                    {
                        Employees employees = new Employees();
                        employees.Email = email;
                        return employees;
                    }
                    else
                        return em;
                }
            }
            catch (System.Exception ex)
            {
                return null;
            }

        }
       public Employees GetEmployeeByEmail(string email)
        {
            try
            {
                Employees e = _context.Employees.Include(x => x.IdUserNavigation).Include(x => x.Job).FirstOrDefault(x => x.Email == email);
                return e;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public string GetEmployeeName(string email, string pass)
        {
            //Employees e = GetEmployeeByEmailPassword(email,pass);
            return "שלום לך ";
        }
        public List<Employees> GetAllEmployees()
        {
            try
            {
                return _context.Employees.Include(x=>x.IdUserNavigation).Include(x=>x.Job).ToList();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteEmployee(string email)
        {
            try
            {
                Employees e = new Employees();
                    //_context.Employees.Include(x => x.IdUserNavigation).Include(x => x.Job).SingleOrDefault(x => x.Email == email);
                _context.Employees.Remove(e);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        public bool AddEmployee(Employees e)
        {

            try
            {
                
                _context.Employees.Add(e);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateEmployee(string email, Employees e)
        {
            try
            {
                Employees currentEmployee = _context.Employees.Include(x => x.IdUserNavigation).Include(x => x.Job).SingleOrDefault(x => x.Email == email);
                _context.Entry(currentEmployee).CurrentValues.SetValues(e);
                _context.SaveChanges();
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }


        }

        public Employees GetEmployeeById(int id) {
            return _context.Employees.Include(x => x.IdUserNavigation).Include(x => x.Job).FirstOrDefault(e => e.Id == id);      
        }


        public void  SendEmailTochoose(Employees employees, string s)
        {
            Outlook.Application app = new Outlook.Application();
            Outlook.MailItem mail = (Outlook.MailItem)app.CreateItem(Outlook.OlItemType.olMailItem);
            mail.To = "Project@0772260000.co.il";
            mail.Subject = "Hello, World!";
            mail.Body = "This is a test email sent from the Outlook API in C#.";
            mail.Importance = Outlook.OlImportance.olImportanceHigh;
            mail.Send();


            //// Create an Outlook application.
            //Microsoft.Office.Interop.Outlook.Application oApp = new Microsoft.Office.Interop.Outlook.Application();

            //// Create a new mail item.
            //Microsoft.Office.Interop.Outlook.MailItem oMsg = (Microsoft.Office.Interop.Outlook.MailItem)oApp.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            //    // Set the subject.
            //    oMsg.Subject = "Your subject here";

            //    // Set the body.
            //    oMsg.Body = "Your message body here";

            //// Add a recipient.
            //Microsoft.Office.Interop.Outlook.Recipient oRecip = (Microsoft.Office.Interop.Outlook.Recipient)oMsg.Recipients.Add("Project@0772260000.co.il");

            //    // Set the recipient as a CC.
            //    oRecip.Type = (int)Microsoft.Office.Interop.Outlook.OlMailRecipientType.olCC;

            //    // Set the recipient as high importance.
            //    oMsg.Importance = Microsoft.Office.Interop.Outlook.OlImportance.olImportanceHigh;

            //    // Save the message.
            //    oMsg.Save();

            //    // Send the message.
            //    oMsg.Send();





            //        // Set up the email message.
            //        Message message = new Message
            //        {
            //            Body = new ItemBody
            //            {
            //                Content = "This is the body of the email.",
            //                ContentType = BodyType.Text
            //            },
            //            Subject = "Test Email",
            //            ToRecipients = new List<Recipient>
            //{
            //    new Recipient
            //    {
            //        EmailAddress = new EmailAddress
            //        {
            //            Address = "Project@0772260000.co.il"
            //        }
            //    }
            //}
            //        };

            //        // Set up the client.
            //        GraphServiceClient client = new GraphServiceClient(
            //            new DelegateAuthenticationProvider(
            //                async (requestMessage) =>
            //                {
            //        // Set the access token in the Authorization header of the request.
            //        requestMessage.Headers.Authorization =
            //                        new AuthenticationHeaderValue("Bearer", "YOUR_ACCESS_TOKEN");
            //                }));

            //        // Send the email.
            //        await client.Me.SendMail(message, true).Request().PostAsync();

            /////////////////////////////////////////////////
            //string _password = "M4501";//סיסמת מייל השולח
            //string _sender = "Project@0772260000.co.il";//לשנות לכתובת ששולחת
            //SmtpClient client = new SmtpClient();
            //client.Host = "smtp.office365.com";
            //client.Port = 25;
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;
            //client.UseDefaultCredentials = false;
            //System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(_sender, _password);
            //client.EnableSsl = true;
            //client.Credentials = credentials;
            ////MailMessage message;
            //var message = new MailMessage();// = new MailMessage(_sender, "Project@0772260000.co.il");
            //message.From = new MailAddress("Project@0772260000.co.il");
            //message.CC.Add(new MailAddress("Project@0772260000.co.il"));
            //message.Subject = "קוד אימות ממרכז האזינו";
            //message.Body = s;
            //client.Send(message);
        }
        public void put(Employees employees)
        {
            string code = "";
            Random random = new Random();
            for(int i =0; i < 4; i++)
            {
               code+= random.Next(10).ToString();
            }
            string s = "";
            if (s != "")
                s = s + "\n\n";
            s = s +
               "קוד האימות לכתובת הדואר האלקטרוני: " + "\n" + "\n" + code;


            try
            {
                Employees currentEmployee = _context.Employees.Where(x => x.IdUser == employees.IdUser).FirstOrDefault();
                employees.VerificationCode = code;
                _context.Entry(currentEmployee).CurrentValues.SetValues(employees);
                //CreateTestMessage3();
                SendEmailTochoose(employees,s);

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                //_logger.LogInformation($"\n{s}\n");
                Console.WriteLine("error");
            }
            
        }
    }

}
