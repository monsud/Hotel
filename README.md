# Hotel
Hotel project written in C# from an exercise and using MVC pattern.

A hotel intends to create a software for managing room reservations.
Customers are identified by: tax code, surname, name, city, province, e-mail, telephone and mobile phone.
Each room is identified by a number, a description and the type (single, double).
The reservation made by a customer refers to a single room.
For each reservation, the date of the reservation must be memorized, a progressive number in the year, the year, the period of stay (from, to), the deposit and the rate applied.
The rate applied depends on the type of room (single, double), the treatment (half board, full board, bed and breakfast) and the period of the year (from, to).

Additional services may be requested during the stay (Breakfast in the room, drinks and food in the mini bar, internet, extra bed, cot) to be charged on the reservation.
The date, quantity and price are stored for each service. On the services the price is specified (inclusive of unit euro or euro / day), a description.

The software must:

1) Allow you to upload a new booking

2) Search for a reservation by number and year

3) Search reservations for
3a) Surname and / or Customer name
3b) Booking date

4) For each reservation, print a summary sheet with all relevant data

5) For each booking, print a summary of the costs, the total, the deposit and the final balance to be paid
