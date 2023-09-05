using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Banker.Validators
{
    public class PinValidator
    {
        public bool ValidatePin(string inputPin, string dbPin)
        {
            // Should be done at the input level, so wrong input types can't be send to the validator
            Regex regexp = new Regex(@"^\d{4}$");

            try
            {
                if (regexp.Match(inputPin).Success)
                {
                    if (inputPin.Equals(dbPin))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    throw new ArgumentException("Input invalid, must be numbers from 0 to 9 and exactly 4 in length.");
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                Debug.WriteLine(e.Message);
                return false;

            }
            catch (ArgumentNullException e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            catch (ArgumentException e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }
    }
}
