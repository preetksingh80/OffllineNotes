using System.Collections.Generic;

namespace OfflineNotes.Core.Entities
{
    public class Customer
    {
        public Customer()
        {
            Notes = new List<string>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Notes { get; private set; }
    }
}