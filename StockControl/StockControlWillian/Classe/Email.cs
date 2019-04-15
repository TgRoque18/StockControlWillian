using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControlWillian.Classe
{
    public class Email
    {
        private string to;

        private DateTime date;

        private string from;

        private string body;

        private string subject;

        public string To
        {
            get => to;
            set => to = value;
        }

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public string From
        {
            get => from;
            set => from = value;
        }

        public string Body
        {
            get => body;
            set => body = value;
        }

        public string Subject
        {
            get => subject;
            set => subject = value;
        }
    }
}
