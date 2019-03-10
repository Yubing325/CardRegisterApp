using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardRegisterApp.API.DAL
{
    public class PaymentDetailContext : DbContext
    {
        private readonly DbContextOptions options;

        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options):base(options)
        {
            this.options = options;
        }
    }
}
