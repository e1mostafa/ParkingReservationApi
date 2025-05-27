ParkingReservationApi
A simple API for managing parking spot reservations in small parking lots (e.g., residential buildings or private lots).

Features
Reserve a parking spot for a specific date.

View available parking spots on a given date.

Cancel a reservation.

All data is stored in memory (no database).

Swagger UI enabled for easy API testing.

Requirements
.NET 8 SDK

How to Run
Clone or download the project.

Open a terminal or PowerShell in the project folder.

Run the following command to start the API:

bash
Copy
Edit
dotnet run
Open your browser and navigate to:

bash
Copy
Edit
http://localhost:5185/swagger
to explore and test the API via Swagger UI.

API Endpoints
Method	Endpoint	Description
POST	/api/parking	Reserve a parking spot
GET	/api/parking/available?date=YYYY-MM-DD	Get available spots for a specific date
DELETE	/api/parking/{id}	Cancel a reservation by its ID

ParkingReservation Model
Property	Type	Description
Id	int	Unique reservation identifier
SpotNumber	int	Parking spot number
UserName	string	Name of the user
ReservationDate	DateTime	Date of the reservation
IsReserved	bool	Reservation status

Example Reservation Request (POST)
json
Copy
Edit
{
  "spotNumber": 3,
  "userName": "mostafa",
  "reservationDate": "2025-05-28T00:00:00",
  "isReserved": true
}
