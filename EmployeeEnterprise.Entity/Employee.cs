using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEnterprise.Entity
{
    public class Employee
    {
        public int EmpId { get; set; }
        [Required]
        public string EmpNo { get; set; }
        [Required,MaxLength(25)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string ImgUrl { get; set; }
        public string Gender { get; set; }
         public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string InsuranceNo { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public StudentLoan StudentLoan { get; set; }
        public UnionMember UnionMember { get; set; }
        [Required, MaxLength(150)]
        public string Address { get; set; }
        public string City { get; set; }
        [Required, MaxLength(15)]
        public int Pincode { get; set; }
        public IEnumerable<PaymentRecord> PaymentRecord { get; set; }

    }
}
