using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ExpenseName { get; set; }

        [DisplayName("Expenses Amount($)")][Required][Range(1, 100_000_000, ErrorMessage = "Amount should be greater than 0")]
        public int ExpenseAmount { get; set; }
    }
}
