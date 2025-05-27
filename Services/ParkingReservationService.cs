using ParkingReservationApi.Models;

namespace ParkingReservationApi.Services
{
    public class ParkingReservationService
    {
        private readonly List<ParkingReservation> _reservations = new();
        private int _nextId = 1;

        // تحقق من إذا المكان محجوز في نفس اليوم ولا لأ
        public bool IsSpotAvailable(int spotNumber, DateTime date)
        {
            return !_reservations.Any(r =>
                r.SpotNumber == spotNumber &&
                r.ReservationDate.Date == date.Date &&
                r.IsReserved);
        }

        // حجز المكان إذا متاح
        public bool ReserveSpot(ParkingReservation reservation)
        {
            if (!IsSpotAvailable(reservation.SpotNumber, reservation.ReservationDate))
                return false;

            reservation.Id = _nextId++;
            reservation.IsReserved = true;
            _reservations.Add(reservation);
            return true;
        }

        // جلب الأماكن المتاحة لنفس اليوم
        public IEnumerable<int> GetAvailableSpots(DateTime date, int totalSpots = 10)
        {
            var reservedSpots = _reservations
                .Where(r => r.ReservationDate.Date == date.Date && r.IsReserved)
                .Select(r => r.SpotNumber)
                .ToHashSet();

            // نفترض الجراج فيه 10 أماكن مرقمة 1 لـ 10
            return Enumerable.Range(1, totalSpots).Where(spot => !reservedSpots.Contains(spot));
        }
        public bool CancelReservation(int id)
        {
            var reservation = _reservations.FirstOrDefault(r => r.Id == id && r.IsReserved);
            if (reservation == null)
                return false;

            reservation.IsReserved = false;
            return true;
        }
    }
}
