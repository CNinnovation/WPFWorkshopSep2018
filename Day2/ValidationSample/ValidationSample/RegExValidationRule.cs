using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ValidationSample
{
    public class RegExValidationRule : ValidationRule
    {
        public string Expression { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Match m = Regex.Match(value.ToString(), Expression);
            if (m.Success) return ValidationResult.ValidResult;
            else return new ValidationResult(false, "reg ex not valid");
        }
    }
}
