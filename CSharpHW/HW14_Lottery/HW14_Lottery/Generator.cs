using System;


namespace HW14_Lottery
{
    class Generator
    {

        private string _ticket;

        public void Generate()
        {
            var random = new Random();
            _ticket = random.Next(100000, 1000000).ToString();
        }

        
        public string ticket
        {
            get { return _ticket; }
        }

    }
}
