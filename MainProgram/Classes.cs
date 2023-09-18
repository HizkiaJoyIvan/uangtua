using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram
{
    public class User
    {
        public User(
        int userid,
        string username,
        string email,
        string contacs,
        string password)
        {
           UserID = userid;
           Username = username;
           Email = email;
           Contacs = contacs;
           Password = password;
           
        }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Contacs { get; set; }
        public string Password { get; set; }

    }
    public class Income
    {
        public Income() { }
    }

    public class Expense
    {
        public int ExpenseId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }

        public Expense(
            int expenseId,
            string title,
            string category,
            int amount,
            string type,
            DateTime date,
            string description,
            DateTime createdAt,
            int userId)
        {
            ExpenseId = expenseId;
            Title = title;
            Category = category;
            Amount = amount;
            Type = type;
            Date = date;
            Description = description;
            CreatedAt = createdAt;
            UserId = userId;
        }
    }

    public class ExpenseCategory
    {
        public ExpenseCategory() { }
    }

    public class IncomeCategory
    {
        public IncomeCategory()
        {
        }
    }
}
