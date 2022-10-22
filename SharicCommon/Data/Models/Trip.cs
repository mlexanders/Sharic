namespace SharicCommon.Data.Models
{
    public class Trip
    {
        public int Trip_Id { get; set; }
        public DateTime Date { get; set; }
        public char Trip_Type { get; set; }
        public char Terminal { get; set; }
        public string AK_Code { get; set; }
        public string Aer_Code { get; set; }
        public string Airport { get; set; }
        public string BC_Type { get; set; }
        public string Stop_Number { get; set; }
        public string Gate_Number { get; set; }
        public int Passenger_Count { get; set; }


    }
}
