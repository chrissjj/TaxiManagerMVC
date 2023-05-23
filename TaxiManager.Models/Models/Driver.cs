﻿using System.ComponentModel;
using TaxiManager.Models.Enums;

namespace TaxiManager.Models.Models
{
    public class Driver
    {
        public int Id { get; set; }
        [DisplayName("First Name")]
        public string FirstName { get; set; } = null!;
        [DisplayName("Last Name")]
        public string LastName { get; set; } = null!;
        [DisplayName("Taxi License")]
        public string TaxiLicense { get; set; } = null!;
        [DisplayName("License Expiration Date")]
        public DateTime LicenseExpDate { get; set; }
        public Shift? Shift { get; set; }
        public int CarId { get; set; }
        public Car? Car { get; set; }

        public Driver(){}
        public Driver(string firstName, string lastName, string taxiLicense, DateTime expDate)
        {
            FirstName = firstName;
            LastName = lastName;
            TaxiLicense = taxiLicense;
            LicenseExpDate = expDate;
        }

        public LicenseStatus GetExpireStatus()
        {
            var today = DateTime.Today;
            if(LicenseExpDate < today)
                return LicenseStatus.Expired;
            if (LicenseExpDate < today.AddMonths(3))
                return LicenseStatus.Warning;
            return LicenseStatus.Valid;
        }
    }
}
