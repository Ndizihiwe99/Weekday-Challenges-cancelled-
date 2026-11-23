class Program
{
    static void Main(string[] args)
    {
        SeatReservation seatReservation = new SeatReservation(4);

        Console.WriteLine(seatReservation.ReserveSeat(5));
        Console.WriteLine(seatReservation.GetAvailableSeatCount());
    }
}