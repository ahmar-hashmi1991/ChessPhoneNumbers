using Xunit;
using System.Collections.Generic;

namespace ChessPhoneNumbers.Tests
{
    public class PhoneNumberGeneratorTests
    {
        private readonly Keypad _keypad;
        private readonly PhoneNumberGenerator _generator;

        public PhoneNumberGeneratorTests()
        {
            _keypad = new Keypad();
            _generator = new PhoneNumberGenerator(_keypad);
        }

        [Fact]
        public void CountValidPhoneNumbers_King_ReturnsCorrectCount()
        {
            var king = new King();
            int count = _generator.CountValidPhoneNumbersForPiece(king);
            Assert.True(count == 4952); // Replace with the actual expected count after manual calculation or comparison
        }

        [Fact]
        public void CountValidPhoneNumbers_Queen_ReturnsCorrectCount()
        {
            var queen = new Queen();
            int count = _generator.CountValidPhoneNumbersForPiece(queen);
            Assert.True(count == 65695); // Replace with the actual expected count after manual calculation or comparison
        }

        [Fact]
        public void CountValidPhoneNumbers_Rook_ReturnsCorrectCount()
        {
            var rook = new Rook();
            int count = _generator.CountValidPhoneNumbersForPiece(rook);
            Assert.True(count == 3530); // Replace with the actual expected count after manual calculation or comparison
        }

        [Fact]
        public void CountValidPhoneNumbers_Bishop_ReturnsCorrectCount()
        {
            var bishop = new Bishop();
            int count = _generator.CountValidPhoneNumbersForPiece(bishop);
            Assert.True(count == 0); // Replace with the actual expected count after manual calculation or comparison
        }

        [Fact]
        public void CountValidPhoneNumbers_Knight_ReturnsCorrectCount()
        {
            var knight = new Knight();
            int count = _generator.CountValidPhoneNumbersForPiece(knight);
            Assert.True(count == 27); // Replace with the actual expected count after manual calculation or comparison
        }

        [Fact]
        public void CountValidPhoneNumbers_Pawn_ReturnsCorrectCount()
        {
            var pawn = new Pawn();
            int count = _generator.CountValidPhoneNumbersForPiece(pawn);
            Assert.True(count == 0); // Replace with the actual expected count after manual calculation or comparison
        }
    }
}
