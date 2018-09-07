using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace ValidationSample
{
    public class RegExValidationRule : ValidationRule
    {
        public string Expression { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            bool m = Regex.IsMatch(value.ToString(), Expression, RegexOptions.IgnoreCase);
            if (m) return ValidationResult.ValidResult;
            else return new ValidationResult(false, "reg ex not valid");
        }
    }
}
