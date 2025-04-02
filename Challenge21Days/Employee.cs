namespace Challenge21Days
{
    class Employee
    {
        List<int> Scores = new List<int>();

        private int score = 0;
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return this.Scores.Sum();
            }
        }
        public Employee(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }

        public void AddGrade(int score)
        {
            this.Scores.Add(score);
        }
    }
}
