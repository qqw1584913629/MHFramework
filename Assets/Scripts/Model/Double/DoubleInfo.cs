using System;
using System.Collections.Generic;

namespace Model
{
    [Serializable]
    public class DoubleInfo
    {
        public DoubleInfo()
        {
            ans = new List<string>();
        }
        public int id;
        public string question;
        public List<string> ans;
        public string ans1;
        public string ans2;
        public string ans3;
        public string ans4;
        public State state;
    }
}