using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace de.strewi.database
{
    public static class TimeEstimateParser
    {
        private const string operatorGroup = "Operator";
        private const string startYearGroup = "StartYear";
        private const string endYearGroup = "EndYear";
        private const string expressionString = @"^(?<" + operatorGroup + @">[~+-])?(?<" + startYearGroup + @">\d{4})((?<Seperator>[-])(?<" + endYearGroup + @">\d{4}))?$";
        private static readonly Regex expression = new Regex(expressionString, RegexOptions.Compiled);

        public static void ParseTimeEstimate(string input, out int? validFrom, out int? validTo)
        {
            if (input == null)
            {
                validFrom = validTo = null;
                return;
            }

            var result = expression.Match(input);
            var startYear = int.Parse(result.Groups[startYearGroup].Value);

            if (result.Groups[operatorGroup] != null && result.Groups[endYearGroup] == null)
            {
                var endYear = startYear;
                switch (result.Groups[operatorGroup].Value)
                {
                    case "~":
                        startYear -= 5;
                        endYear += 5;
                        break;
                    case "+":
                        endYear += 10;
                        break;
                    case "-":
                        startYear -= 10;
                        break;
                }

                validFrom = startYear;
                validTo = endYear;

            }
            else if (result.Groups[endYearGroup] != null)
            {
                validFrom = startYear;
                validTo = int.Parse(result.Groups[endYearGroup].Value);
            }
            else
            {
                validTo = validFrom = startYear;
            }
        }
    }
}
