﻿using System;
using _04_to_12.Library.Objects;

namespace _04_to_12.Models.Users
{
    public class User
    {
        public User(UserName name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            Id = new UserId(Guid.NewGuid().ToString());
            Name = name;
        }

        public User(UserId id, UserName name)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            if (name == null) throw new ArgumentNullException(nameof(name));

            Id = id;
            Name = name;
        }

        public UserId Id { get; }
        public UserName Name { get; private set; }

        public void ChangeName(UserName name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            Name = name;
        }

        public override string ToString()
        {
            var sb = new ObjectValueStringBuilder(nameof(Id), Id)
                .Append(nameof(Name), Name);

            return sb.ToString();
        }
    }
}
