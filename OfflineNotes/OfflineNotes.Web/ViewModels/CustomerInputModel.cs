using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OfflineNotes.Web.ViewModels
{
    public class CustomerInputModel
    {
        public string Name { get; set; }
        public string Note { get; set; }
        public int Id { get; set; }
        public string Key { get; set; }
    }
}