using System.ComponentModel.DataAnnotations;
namespace PlayerWeb.Models
{
    public class Bot 
    {
            private string name;
            private string email;
            private string level;
            private string power;
            [Key]
            public Guid Id { get; set; }
            public Bot() { }
            public Bot(string name, string email, string level,string power)
            {
                    this.name = name;
                    this.email = email;
                    this.level = level;
                    this.power= power;
            }
            public string Name { get => name; set { this.name = value; } }
            public string Email { get => email; set { this.email = value; } }
            public string Level { get => level; set { this.level = value; } }
            public string Power { get => power; set { this.power= value; } }
    }

}