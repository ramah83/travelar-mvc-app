namespace TeamLID.TravelExperts.App.Models
{
    public class DashboardViewModel
    {
        public int TotalCustomers { get; set; }
        public int TotalBookings { get; set; }
        public int TotalAgents { get; set; }
        public int TotalPackages { get; set; }

        public Dictionary<string, int> BookingsByDestination { get; set; } = new();
        public List<string> Months { get; set; } = new();
        public List<int> NewCustomersPerMonth { get; set; } = new();
    }

}
