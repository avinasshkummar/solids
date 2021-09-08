using System;

namespace solids
{
    //Come and go customer  enquiry ask discount


    //paltiumm customer     enquiry ask discount+5

    //gold customer         enquiry ask discount+10

    class Program
    {
        static void Main(string[] args)
        {
            PlatiumCustomer pc = new PlatiumCustomer();
            
        }
    }

    abstract class Customer
    {
        public void Enquiry()
        {
            //enquiry about menu.
        }
        abstract public int GetDiscount();
    }

    class PlatiumCustomer: Customer
    {
        public override int GetDiscount()
        {
            try
            {
                //calc
                return 7;
            }
            catch (Exception ex)
            {

                //log inside a mail
                //if (database) log in db 
                if(true)
                {
                    HandleMailException handleMailException = new HandleMailException();
                    handleMailException.MailTheException(ex.Message);
                }
                else
                {
                    HandleDBException handleDBException = new HandleDBException();
                    handleDBException.DBLogTheException(ex.Message);
                }
                throw ex;
            }
            
           
        }
        int Calc()
        {
            return 500;
        }
    }
    class GoldCustomer : Customer
    {
        public override int GetDiscount()
        {
            try
            {
                //calc
                return 10;
            }
            catch (Exception ex)
            {
                if (true)
                {
                    HandleMailException handleMailException = new HandleMailException();
                    handleMailException.MailTheException(ex.Message);
                }
                else
                {
                    HandleDBException handleDBException = new HandleDBException();
                    handleDBException.DBLogTheException(ex.Message);
                }
                throw ex;
            }
        }
    }

    class HandleMailException
    {
        public void MailTheException(string ex)
        {
            //log.
        }
    }

    class HandleDBException
    {
        public void DBLogTheException(string ex)
        {
            //log.
        }
    }
}
