using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotSlack.Models
{
    public class SlashCommand
    {
        public string Token { get; set; }
        public string TeamId { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string Command { get; set; }
        public string Text { get; set; }
        public string ResponseUrl { get; set; }
    }
}
