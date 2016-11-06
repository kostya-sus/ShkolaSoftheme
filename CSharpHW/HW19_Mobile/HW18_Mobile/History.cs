
using System.Collections.Generic;
using System.Linq;


namespace HW18_Mobile
{
    public class History
    {
        private List<Calls> _callHistory;
        private List<Messages> _messageHistory;

        public History()
        {
            _callHistory = new List<Calls>();
            _messageHistory = new List<Messages>();
        }
              
        public void RegisterCall(Calls call)
        {
            _callHistory.Add(call);
        }

        public void RegisterMessage(Messages sms)
        {
            _messageHistory.Add(sms);
        }

        public List<Calls> CallHistory
        {
            get { return _callHistory; }
        }

        public List<Messages> MessageHistory
        {
            get { return _messageHistory; }
        }

        public List<MobileAccount> TopCalledNumbers(int top)
        {
            var groupCalled = _callHistory.GroupBy(call => call.ForWhom);
            var topCallers = (from number in groupCalled orderby number.Count() descending  select number.Key).Take(top);

            return topCallers.ToList();
        }

               

        public List<MobileAccount> FrequentlyActiveSubscribers(int top)
        {
            var groupsCall = _callHistory.GroupBy(call => call.From);
            var groupsMessage = _messageHistory.GroupBy(sms => sms.From);
                                    
            var partMessage = (from message in groupsMessage join call in groupsCall on message.Key equals call.Key into Message
                        from newMessage in Message.DefaultIfEmpty()
                        select new {account = message.Key, activity = (double)message.Count() / 2 }).ToList();

            var partCall = (from call in groupsCall join sms in groupsMessage on call.Key equals sms.Key into Call
                        from newCall in Call.DefaultIfEmpty()
                        select new { account = call.Key, activity = (double)call.Count() }).ToList();

            var full = partMessage.Concat(partCall);
            var activeSubscribers = (from account in full orderby account.activity descending select account.account).Take(top);
           
            return activeSubscribers.ToList();
        }
    }
}
