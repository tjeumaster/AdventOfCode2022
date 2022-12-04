using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_CampCleanup
{
    internal class Assignment
    {
        private int _startPosition;
        private int _endPosition;

        public Assignment(string assignment)
        {
            var positions = assignment.Split('-');
            _startPosition = int.Parse(positions[0]);
            _endPosition = int.Parse(positions[1]);
        }

        public bool Contains(Assignment otherPairAssignment)
        {
            return _startPosition <= otherPairAssignment._startPosition && _endPosition >= otherPairAssignment._endPosition;
        }

        public bool Overlaps(Assignment otherPairAssignment)
        {
            return _endPosition >= otherPairAssignment._startPosition && otherPairAssignment._endPosition >= _startPosition;
        }
    }
}
