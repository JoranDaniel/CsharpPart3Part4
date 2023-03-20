using System;

namespace exercise_96

public class Room
{
    private string code;
    private int seats;

    public Room(string classCode, int numberOfSeats)
    {
        code = classCode;
        seats = numberOfSeats;
    }
}