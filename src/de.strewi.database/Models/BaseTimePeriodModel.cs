using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace de.strewi.database.Models
{
    /// <summary>
    /// Abstract base class for models containg a time period
    /// </summary>
    public abstract class BaseTimePeriodModel : BaseModel
    {
        private string timePeroid;
        private const string operatorGroup = "Operator";
        private const string startYearGroup = "StartYear";
        private const string endYearGroup = "EndYear";
        private const string expressionString = @"^(?<" + operatorGroup + @">[~+-])?(?<" + startYearGroup + @">\d{4})((?<Seperator>[-])(?<" + endYearGroup + @">\d{4}))?$";
        private static readonly Regex expression = new Regex(expressionString, RegexOptions.Compiled);

        /// <summary>
        /// Logical property interpreting the string given into a custom timespan with a start and and end year
        /// </summary>
        [Display(Name = nameof(TimePeriod), ResourceType = typeof (Resources.PropertyNames))]
        [RegularExpression(expressionString, ErrorMessageResourceName = nameof(TimePeriod), ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string TimePeriod
        {
            get { return timePeroid; }
            set
            {
                var result = expression.Match(value);
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

                    ValidFrom = startYear;
                    ValidTo = endYear;

                } else if (result.Groups[endYearGroup] != null)
                {
                    ValidFrom = startYear;
                    ValidTo = int.Parse(result.Groups[endYearGroup].Value);
                } else
                {
                    ValidTo = ValidFrom = startYear;
                }
                
                timePeroid = value;
            }
        }

        public int ValidFrom { get; protected set; }
        public int ValidTo { get; protected set; }
    }
}
