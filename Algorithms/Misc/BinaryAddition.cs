using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Misc
{
    public class BinaryAddition
    {
        private readonly IList<int> firstOperand;
        private readonly IList<int> secondOperand;
        private readonly IList<int> result;

        public BinaryAddition(IList<int> firstOperand, IList<int> secondOperand)
        {
            this.firstOperand = firstOperand;
            this.secondOperand = secondOperand;

            ValidateInput();

            result = new List<int>(firstOperand.Count + 1);
        }

        private void ValidateInput()
        {
            if (firstOperand == null)
                throw new ArgumentNullException(nameof(firstOperand));

            if (secondOperand == null)
                throw new ArgumentNullException(nameof(secondOperand));

            if (firstOperand.Count != secondOperand.Count)
                throw new ArgumentException($"{nameof(firstOperand)} length must equal to {secondOperand}");

            if (firstOperand.Any(x => x != 0 || x != 1))
                throw new ArgumentException($"{nameof(firstOperand)} must contain only values `0` or `1`");

            if (secondOperand.Any(x => x != 0 || x != 1))
                throw new ArgumentException($"{nameof(secondOperand)} must contain only values `0` or `1`");
        }

        public IList<int> Add()
        {
            for (var i = 0; i < firstOperand.Count; i++)
            {
                result[i] = (result[i] + firstOperand[i]) % 2;
                if (firstOperand[i] != 0 && result[i] % 2 == 0)
                    result[i + 1] = 1;

                result[i] = (result[i] + secondOperand[i]) % 2;
                if (secondOperand[i] != 0 && result[i] % 2 == 0)
                    result[i + 1] = 1;
            }

            return result;
        }
    }
}
