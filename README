# ParkingReservationApi

A lightweight and easy-to-use ASP.NET Core Web API for reserving parking spots in small parking lots such as residential buildings or private areas.

---

## Features

- Reserve a parking spot for a specific date.
- Retrieve a list of available parking spots.
- Cancel existing reservations.
- In-memory data storage (no database needed).
- Integrated Swagger UI for interactive API documentation and testing.

---

## Technologies Used

- .NET 8
- C#
- ASP.NET Core Web API
- Swashbuckle (Swagger UI)

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) installed on your machine.

### Running the API

1. Clone or download the repository.
2. Open your terminal or command prompt in the project directory.
3. Run the following command to start the API:

```bash
dotnet run
Once running, open your browser and navigate to:

bash
Copy
Edit
http://localhost:****/swagger
This opens the Swagger UI where you can test the API endpoints easily.

API Endpoints
HTTP Method	Endpoint	Description
POST	/api/parking/reserve	Reserve a parking spot
GET	/api/parking/available	Get available parking spots (by date)
DELETE	/api/parking/{id}	Cancel a reservation by ID

Data Model: ParkingReservation
Property	Type	Description
Id	int	Unique identifier for reservation
SpotNumber	int	Parking spot number
UserName	string	Name of the user reserving the spot
ReservationDate	DateTime	Date of the reservation
IsReserved	bool	Indicates if the spot is reserved

Example: Reserve a Spot
Request
json
Copy
Edit
POST /api/parking/reserve
Content-Type: application/json

{
  "spotNumber": 5,
  "userName": "mostafa",
  "reservationDate": "2025-05-28T00:00:00",
  "isReserved": true
}
Response
200 OK — Reservation successful.

400 Bad Request — Spot already reserved for the selected date.

Notes
The API uses in-memory data storage, so all reservations are lost when the application stops.

The default parking lot size is 10 spots, numbered 1 through 10.

Validation is performed to prevent double booking on the same date and spot.

Contact
For questions or feedback, please reach out to mostafa.

sql
Copy
Edit

Just copy and paste that whole content into your `README.md` in your repo root, commit, and push.  
If you want, I can help you with the exact git commands too.
