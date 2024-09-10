using Discord.models;
using System;
using System.Collections.Generic;

namespace Discord.seed
{
    public class seed
    {
        public static List<User> SeedUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "Alice" },
                new User { Id = 2, Name = "Bob" },
                new User { Id = 3, Name = "Charlie" },
                new User { Id = 4, Name = "David" },
                new User { Id = 5, Name = "Eve" }
            };
        }

        public static List<Message> SeedMessages(List<User> users)
        {
            return new List<Message>
            {
                new Message { Id = 1, Sender = users[0], Content = "Hello, everyone!", Timestamp = DateTime.Now.AddMinutes(-10) },
                new Message { Id = 2, Sender = users[1], Content = "Hi Alice!", Timestamp = DateTime.Now.AddMinutes(-9) },
                new Message { Id = 3, Sender = users[2], Content = "Good morning!", Timestamp = DateTime.Now.AddMinutes(-8) },
                new Message { Id = 4, Sender = users[3], Content = "How's everyone doing?", Timestamp = DateTime.Now.AddMinutes(-7) },
                new Message { Id = 5, Sender = users[4], Content = "I'm great, thanks!", Timestamp = DateTime.Now.AddMinutes(-6) }
            };
        }
    }
}
