﻿using Knewin.Core.Entities;

namespace Knewin.Domain.Entities
{
    public class Account : Entity
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }
    }
}
