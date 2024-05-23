﻿using System.Text;

namespace MextFSBeginner.Domain.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsShown { get; set; }
        public bool IsFavourite { get; set; }
        public DateTime CreatedOn { get; set; }

        public string Encrypt()
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(Password);

            Password = Convert.ToBase64String(plainTextBytes);

            return Password;
        }

        public string Decrypt()
        {
            var base64EncodedBytes = Convert.FromBase64String(Password);

            Password = Encoding.UTF8.GetString(base64EncodedBytes);

            return Password;
        }
    }
}
