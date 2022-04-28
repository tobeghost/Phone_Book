using System.Collections.Generic;
using PhoneBook.Web.Models.Contact;
using PhoneBook.Web.Models.Report;
using PhoneBook.Web.Models.User;

namespace PhoneBook.Web.Models
{
    public class HomeViewModel
    {
        public List<ContactViewModel> contactList{ get; set; }=new List<ContactViewModel>();
        public List<ReportViewModel> reportList { get; set; } = new List<ReportViewModel>();    
        public List<UserViewModel> userList{ get; set; } = new List<UserViewModel>();   
    }
}
