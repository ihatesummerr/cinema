using System;

namespace Cinema.Win
{

    public interface UserModel
    {

        public string Username { get; set; }
        public Privilegies Privilege { get; set; }

    }

}