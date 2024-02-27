using MiniUber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Uber
{
   public class DbProxy
    {
        private static DataBase db;
        private static DbProxy proxy;

        private DbProxy() { }

        public static DbProxy GetDB()
        {
            if (db == null)
            {
                db = new ConcreteDB();
            }

            if (proxy == null)
            {
                proxy = new DbProxy();
            }
            return proxy;
            
        }


        public  User GetUser(string UserName)
        {
             return db.GetUser(UserName);

        }
        public  List<Driver> GetDrivers() {
            return db.GetDrivers();
        
        }
        public void InsertUser(User user) {
            db.InsertUser(user);
        
        }
        public  void InsertRide(string ride) { 
        
        }

        public Dictionary<string, int> GetCities() {
            return db.GetCities();
        }

        public  void InsertTicket(Ticket t) {

            db.InsertTicket(t);
        }
        public  void GetDestinations(int[,] Distances) {
            db.GetDestinations(Distances);

        }
        public  void InsertCredit(User user)
        {
            db.InsertCredit(user);
        }

        public Vehicle GetVehicle(Driver driver)
        {
            return db.GetCarsDetails(driver);
        }



        public int GetTicketID()
        {
            return db.GetTicketID();
        }


    }
}
