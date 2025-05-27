namespace ParkingReservationApi.Models
{
	public class ParkingReservation
	{
		public int Id { get; set; }
		public int SpotNumber { get; set; }
		public string UserName { get; set; } = string.Empty;
		public DateTime ReservationDate { get; set; }
		public bool IsReserved { get; set; }
	}
}
