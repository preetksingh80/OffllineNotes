using System;
using System.Collections.Generic;
using System.Linq;
using OfflineNotes.Core.Entities;

namespace OfflineNotes.Core
{
    public class InMemoryNotesService : INotesService
    {
        private readonly IList<Customer> _customers;
        public InMemoryNotesService()
        {
            _customers = new List<Customer>();
        }

        public void Save(int id, string name, string note)
        {
            var existingCustomer = _customers.FirstOrDefault(customer => customer.Id == id);
            if (existingCustomer != null)
            {
                existingCustomer.Name = name;
                existingCustomer.Notes.Add(note);
            }
            else
            {
                AddNewCustomerWithNote(id, name, note);
            }
        }

        private void AddNewCustomerWithNote(int id, string name, string note)
        {
            var customer = new Customer {Id = id, Name = name};
            customer.Notes.Add(note);
            _customers.Add(customer);
        }
    }
}