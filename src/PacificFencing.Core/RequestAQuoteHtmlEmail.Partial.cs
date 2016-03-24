using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacificFencing.Core
{
    public partial class RequestAQuoteHtmlEmail
    {
        public RequestAQuoteModel RequestAQuote { get; set; }

        public RequestAQuoteHtmlEmail(RequestAQuoteModel model)
        {
            RequestAQuote = model;
        }

    }
}
