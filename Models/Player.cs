using System.ComponentModel.DataAnnotations;
namespace PlayerWeb.Models
{
    public class Player 
    {
            private string name;
            private string email;
            private string level;
            [Key]
            public Guid Id { get; set; }
            public Player() { }
            public Player(string name, string email, string level)
            {
                    this.name = name;
                    this.email = email;
                    this.level = level;
            }
            public string Name { get => name; set { this.name = value; } }
            public string Email { get => email; set { this.email = value; } }
            public string Level { get => level; set { this.level = value; } }
    }

}