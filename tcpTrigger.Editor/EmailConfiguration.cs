﻿using System.Security;

namespace tcpTrigger.Editor
{
    internal class EmailConfiguration
    {
        public string Server { get; set; }
        public string Port { get; set; }
        public bool IsAuthRequired { get; set; }
        public string Username { get; set; }
        public SecureString Password { get; set; }
        public string From { get; set; }
        public string FromFriendly { get; set; }
        public string Recipient { get; set; }
    }
}
