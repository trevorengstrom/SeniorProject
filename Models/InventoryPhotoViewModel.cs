using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace TaMotors.Models
{
    public class InventoryPhotoViewModel
    {
        public Inventory Inventory { get; set; }
        public ICollection<Photo> Photo { get; set; }
    }
}