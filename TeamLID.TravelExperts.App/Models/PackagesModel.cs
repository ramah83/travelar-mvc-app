using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TeamLID.TravelExperts.App.Models
{
    public class PackagesModel
    {
        public int PackageId { get; set; }

        [Required(ErrorMessage = "Package name is required.")]
        [DisplayName("Title")]
        public string PkgName { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [DataType(DataType.Date), DisplayName("Start Date")]
        public DateTime? PkgStartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [DataType(DataType.Date), DisplayName("End Date")]
        public DateTime? PkgEndDate { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [DisplayName("Description")]
        public string PkgDesc { get; set; }

        [Required(ErrorMessage = "Base price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        [DisplayName("Price (EGP)")]
        public decimal PkgBasePrice { get; set; }

        [Required(ErrorMessage = "Agency commission is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Commission must be a positive value.")]
        [DisplayName("Agency Commission")]
        public decimal? PkgAgencyCommission { get; set; }
    }
}