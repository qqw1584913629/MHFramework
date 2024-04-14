using System;

namespace Model
{
    public enum Role
    {
        Normal = 0,
        Manager,
    }
    [Serializable]
    public class AccountInfo
    {
        public string account;
        public string password;
        public Role role;
    }
}