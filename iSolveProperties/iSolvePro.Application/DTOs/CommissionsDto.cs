using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSolveProperties.Application.DTOs
{
    public class CommissionsDto
    {
        public double Payable { get; set; }   // Total debit (what's payable)
        public double Paid { get; set; }      // Total credit (what's paid)
        public double NetValue { get; set; }  // Difference between debit and credit
    }
}
