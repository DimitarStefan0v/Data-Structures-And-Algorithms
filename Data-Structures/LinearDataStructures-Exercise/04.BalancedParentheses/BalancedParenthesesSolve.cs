namespace Problem04.BalancedParentheses
{
    using System;
    using System.Collections.Generic;

    public class BalancedParenthesesSolve : ISolvable
    {
        public bool AreBalanced(string parentheses)
        {
            if (string.IsNullOrWhiteSpace(parentheses) || parentheses.Length % 2 == 1)
            {
                return false;
            }

            var stack = new Stack<char>(parentheses.Length / 2);

            foreach (var currentParenthese in parentheses)
            {
                char expected = default;

                switch (currentParenthese)
                {
                    case ')':
                        expected = '(';
                        break;
                    case ']':
                        expected = '[';
                        break;
                    case '}':
                        expected = '{';
                        break;
                    default:
                        stack.Push(currentParenthese);
                        break;
                }

                if (expected == default)
                {
                    continue;
                }

                if (stack.Pop() != expected)
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
