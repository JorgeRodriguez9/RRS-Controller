﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RRS_Controller.Models
{
    public class USER
    {

        [Key]
        public int ID { get; set; }

        [StringLength(30)]
        public string Name_User { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        public int Id_Role { get; set; }
        [ForeignKey("Id_Role")]
        public virtual ROLE ROLE { get; set; }


        /////////////
        public virtual SECRETARY_INTS SECRETARY_INTS { get; set; }
        public virtual NUTRITIONITS_PAE NUTRITIONITS_PAE { get; set; }
        public virtual ADMIN_PAE ADMIN_PAE { get; set; }
        public virtual MANAGER_PAE MANAGER_PAE { get; set; }
        public virtual NUTRITIONITS_INTS NUTRITIONITS_INTS { get; set; }

    }
}
