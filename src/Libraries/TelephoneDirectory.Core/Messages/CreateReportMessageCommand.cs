using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Libraries.Core
{
    public class CreateReportMessageCommand
    {
        public string Location { get; set; }
        public string ReportId { get; set; }
    }
}
