using System;

namespace Model
{
    public enum State
    {
        None,
        Remove
    }
    public enum QuestionState
    {
        None,
        Finish
    }
    [Serializable]
    public class SingleInfo
    {
        public int id;
        public string question;
        public string ans;
        public string ans1;
        public string ans2;
        public string ans3;
        public string ans4;
        public State state;
        public QuestionState questionState;
    }
}