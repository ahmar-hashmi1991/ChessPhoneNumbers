using System;
using System.Collections.Generic;

// Main program
class Program
{
    static void Main()
    {
        Keypad keypad = new Keypad();
        PhoneNumberGenerator generator = new PhoneNumberGenerator(keypad);

        Console.WriteLine("Total valid 7-digit phone numbers for each chess piece:");
        Console.WriteLine($"King: {generator.CountValidPhoneNumbersForPiece(new King())}");
        Console.WriteLine($"Queen: {generator.CountValidPhoneNumbersForPiece(new Queen())}");
        Console.WriteLine($"Rook: {generator.CountValidPhoneNumbersForPiece(new Rook())}");
        Console.WriteLine($"Bishop: {generator.CountValidPhoneNumbersForPiece(new Bishop())}");
        Console.WriteLine($"Knight: {generator.CountValidPhoneNumbersForPiece(new Knight())}");
        Console.WriteLine($"Pawn: {generator.CountValidPhoneNumbersForPiece(new Pawn())}");
    }
}
