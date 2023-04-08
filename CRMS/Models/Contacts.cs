﻿using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = Microsoft.Build.Framework.RequiredAttribute;

namespace CRMS.Models
{
    public class Contacts
    {
        //PROPERTIES
        public Guid Contact_Id { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "The first name is too short")]
        public string FirstName { get; set; } = "--";


        [System.ComponentModel.DataAnnotations.Required]
        [MinLength(2, ErrorMessage = "The last name is too short")]
        public string LastName { get; set; } = "--";

        [System.ComponentModel.DataAnnotations.Required]
        [EmailAddress]
        public string Email { get; set; } = "--";


        [System.ComponentModel.DataAnnotations.Required]
        [RegularExpression(@"^(09|\+639)\d{9}$", ErrorMessage = "Incorrect format. Use +639XXXXXXXXX or 09XXXXXXXXX")]
        public string PhoneNumber { get; set; } = "--";


        [System.ComponentModel.DataAnnotations.Required]
        public GenderType? Gender { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DOB { get; set; }


        
        public Guid? ContactOwnerID { get; set; } //Foreign Key: UserID from Application User


        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DateAssigned { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        public Guid? ContactCreatorID { get; set; } //Foreign Key: UserID from Application User


        [System.ComponentModel.DataAnnotations.Required]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreateDate { get; set; }

        //Computed property
        [IgnoreMember]
        public string FullName
        {
            get { return string.Format("{0} {1}", FirstName, LastName); }
        }

        //FOREIGN ENTITY
        public ApplicationUser? Creator { get; set; }
        public ApplicationUser? Owner { get; set; }
        public RollingTransactions? Transactions { get; set; }


        //CONSTRUCTORS
        public Contacts() { }

        public Contacts(string firstName, string lastName, string email, string phoneNumber, GenderType? gender, DateTime? dOB, Guid? contactOwnerID, DateTime? dateAssigned, Guid? contactCreatorID, DateTime? createDate)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Gender = gender;
            DOB = dOB;
            ContactOwnerID = contactOwnerID;
            DateAssigned = dateAssigned;
            ContactCreatorID = contactCreatorID;
            CreateDate = createDate;
        }
    }

    //GENDER SELECTION
    public enum GenderType
    {
        Male,
        Female,
        NonBinary
    }

}
