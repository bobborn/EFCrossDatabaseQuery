using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCrossDatabaseQuery
{
    public class Program
    {

        static void Main(string[] args)
        {
            using (var ctx = new EFOrderContext())
            {

                var orders = ctx.Orders.Select(t => new
                {
                    t.OrderNo,
                    t.Member.UserName,
                    t.TotalMoney
                });
            }

        }
    }
}
