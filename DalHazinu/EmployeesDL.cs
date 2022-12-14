using DalHazinu.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

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
            catch (Exception ex)
            {
                return null;
            }

        }
        public string GetEmployeeName(string email, string pass)
        {
            Employees e = GetEmployeeByEmailPassword(email,pass);
            return "שלום לך "+e.IdUserNavigation.FirstName+e.IdUserNavigation.LastName;
        }
        public List<Employees> GetAllEmployees()
        {
            try
            {
                return _context.Employees.Include(x=>x.IdUserNavigation).Include(x=>x.Job).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteEmployee(string email)
        {
            try
            {
                Employees e = _context.Employees.Include(x => x.IdUserNavigation).Include(x => x.Job).SingleOrDefault(x => x.Email == email);
                _context.Employees.Remove(e);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                return false;
            }


        }

        public static void CreateTestMessage3()
        {
            MailAddress to = new MailAddress("adinamilg879@gmail.com");
            MailAddress from = new MailAddress("adinamilg879@gmail.com");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "Using the new SMTP client.";
            message.Body = @"Using this new feature, you can send an e-mail message from an application very easily.";
            // Use the application or machine configuration to get the  
            // host, port, and credentials.
            SmtpClient client = new SmtpClient();
            Console.WriteLine("Sending an e-mail message to {0} at {1} by using the SMTP host={2}.",
                to.User, to.Host, client.Host);
            try
            {
                client.Send(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage3(): {0}", ex.ToString());
            }
        }



        public void SendEmailTochoose(Employees employees,string s)
        {
            string _password = "AI@345345";//לשנות לכתובת ששולחת
            string _sender = "adi@bemuna.co.il";//לשנות לכתובת ששולחת
            SmtpClient client = new SmtpClient("smtp-mail.outlook.com");
            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = true;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(_sender, _password);
            client.Host = "smtp-mail.outlook.com";
            client.EnableSsl = true;
            client.Credentials = credentials;
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage(_sender, "adi@bemuna.co.il");
            message.Subject = "קוד אימות ממרכז האזינו";
            message.Body = s;
            client.Send(message);
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
                CreateTestMessage3();
                SendEmailTochoose(employees, s);

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
