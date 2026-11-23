
//Cinema Seat Reservation

// 1. The constructor receives the total number of seats. It must throw `ArgumentOutOfRangeException` if the number is zero or negative.
// 2. Seat numbers start at `1`, not `0`.
// 3. `ReserveSeat` returns `true` when a seat is successfully reserved.
// 4. If a seat is already reserved, `ReserveSeat` returns `false` without changing the reservation.
// 5. An invalid seat number must throw `ArgumentOutOfRangeException`.


public class SeatReservation
{
    private readonly bool[] _reservedSeats;

    public SeatReservation(int seatCount)
    {
        if (seatCount <= 0)
        {
            throw new ArgumentOutOfRangeException("number of seats must be 1 or above");
        }
        _reservedSeats = new bool[seatCount];
    }

    public bool ReserveSeat(int seatNumber)
    {
        if(seatNumber > _reservedSeats.Length || seatNumber < 1)
        {
            throw new ArgumentOutOfRangeException("Seatnumber cant exceed number of available seeats");
        }
        
        for (int i = 1; i <= _reservedSeats.Length -1; i++)
        {
            if(_reservedSeats[seatNumber])
            {
                return false;
            }
        }
        _reservedSeats[seatNumber] = true;
        return true;

        
    }

    public int GetAvailableSeatCount()
    {
        return _reservedSeats.Count(reserved => !reserved);
    }
}