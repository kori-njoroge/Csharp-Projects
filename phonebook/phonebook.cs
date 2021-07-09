using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace phonebook{


    class phonebook{

        private List<contact> _contacts { get; set;} = new List<contact>();

        public void DisplayContactDetails(contact contact){
            Console.WriteLine($"contact: {contact.Name},{contact.Number}");
        }

        private  void DisplayContactDetails(List<contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void Addcontact( contact contact){
            _contacts.Add (contact);
        }


public void Displaycontact(string number){

    var contact= _contacts.FirstOrDefault( contact =>contact.Number == number);
     if(contact == null){
         Console.WriteLine("Contact not found");
     }
     else
     {
         DisplayContactDetails(contact);
        
     }
}

public void DisplayAllcontacts()
{
    DisplayContactDetails(_contacts);
}
public void DisplayMatchingContacts(string searchphrase){
    var matchingContacts = _contacts.Where(c=>c.Name.Contains(searchphrase)).ToList();
   
   DisplayContactDetails(matchingContacts);
}
    }
}