using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discord.models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Message
    {
        public int Id { get; set; }
        public User Sender { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
