using System;
using System.Collections.Generic;
using System.Text;

namespace Lib.Standard.Model
{
    public class CharStream : ICharStream
    {
        private string _context;
        private int? _pos;

        public int Inx => _pos.GetValueOrDefault();
        public string Context => _context;
        public bool HasNext() => Inx < _context?.Length - 1;

        public CharStream(string context)
        {
            _context = context;
        }

        public char Next()
        {
            if (_pos >= _context.Length) throw new IndexOutOfRangeException();
            if (_pos == null) _pos = 0; else _pos++;
            return _context[Inx];
        }

        /// Local functions
        public bool IsValid()
        {
            while (HasNext())
                if (!findCouple(Next())) return false;
            return true;

            bool findCouple(char input) {
                while (HasNext()) {
                    var next = Next();
                    if (isOpeningBracket(input) && isClosingBracket(input, next)) return true;
                    findCouple(next); }
                return false; }
            bool isOpeningBracket(char i) => i == 40 || i == 60 || i == 91 || i == 123;
            bool isClosingBracket(char i, char nxt) => (i == 40 && nxt == 41) || (i == nxt - 2);
        }

        // Delegates
        public bool IsValid1()
        {
            while (HasNext())
                if (!findCouple(Next(), 
                                (i) => i == 40 || i == 60 || i == 91 || i == 123, 
                                (i, nxt) => (i == 40 && nxt == 41) || (i == nxt - 2)))
                    return false;
            return true;

            bool findCouple(char input, Func<char, bool> isOpen, Func<char, char, bool> isClose)
            {
                while (HasNext()) {
                    var next = Next();
                    if (isOpen(input) && isClose(input, next)) return true;
                    findCouple(next, isOpen, isClose); }
                return false;
            }
        }
    }
}
