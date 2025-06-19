
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TeamLID.TravelExperts.Repository.Domain;

namespace TeamLID.TravelExperts.App.Models.DataManager
{
    public class CustomerProfileManager
    {


        public static Customers Find(int id)
        {
            var context = new TravelExpertsContext();

            var customer = context.Customers.
                Include(agt => agt.Agent).
                SingleOrDefault(ast => ast.CustomerId == id);

            return customer;

        }

        /// <param name="newCust">Customers object need to be added.</param>
        public static async Task<bool> Add(Customers newCust)
        {
            bool isSucceed = false;
            var context = new TravelExpertsContext();
            context.Customers.Add(newCust);
            try
            {
                int i = await context.SaveChangesAsync();
                if (i > 0)
                    isSucceed = true;
            }
            catch (Exception e)
            {
                throw e;
            }

            return isSucceed;
        }

       
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        public static async Task<Customers> CompareLogin(string username, string password)
        {

            var context = new TravelExpertsContext();
            var cust = context.Customers.SingleOrDefault(c => c.Username == username);
            if (cust == null)
                return null;
            if (cust.Password == password)
                return cust;
            else
                return null;
        }

    }
}
