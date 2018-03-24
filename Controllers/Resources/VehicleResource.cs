using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using EntityPractice.Models;

namespace EntityPractice.Controllers.Resources
{
    public class VehicleResource
    {
        public VehicleResource(int id, int modelId, bool isRegistered, ContactResource contact) 
        {
            this.Id = id;
                this.ModelId = modelId;
                this.IsRegistered = isRegistered;
                this.Contact = contact;
               
        }
        public int Id { get; set; }
        public int ModelId { get; set; }
        public bool IsRegistered { get; set; }
        [Required]
        public ContactResource Contact { get; set; }
        public ICollection<int> Features { get; set; }

        public VehicleResource() 
        {
            Features = new Collection<int>();
        }

    }
}