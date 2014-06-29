using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfflineNotes.Web.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            Id = "0";
            Key = "";

        }
        public string Id { get; set; }
        public string Key { get; set; }
    }
}