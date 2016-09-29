using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class PhoneNumber
{
    public string Number { get; set; }
    public string AreaCode { get; set; }

    public PhoneNumber(string phoneNumber)
    {
        this.Number = phoneNumber;
        Sanitize();
        AccountForUSCountryCode();
        AccountForInvalidNumber();
        ExtractAreaCode();
    }

    private void Sanitize()
    {
        this.Number = new string(
            this.Number.Where<char>(c => char.IsDigit(c)).ToArray()
            );
    }

    private void ExtractAreaCode()
    {
        this.AreaCode = this.Number.Substring(0, 3);
    }

    private void AccountForInvalidNumber()
    {
        if (this.Number.Length > 10 || this.Number.Length < 10)
        {
            this.Number = "0000000000";
        }
    }

    private void AccountForUSCountryCode()
    {
        if (this.Number.Length == 11 && this.Number.StartsWith("1"))
        {
            this.Number = this.Number.Substring(1);
        }
    }

    public override string ToString()
    {
        return string.Format("({0}) {1}-{2}", 
            this.Number.Substring(0,3),
            this.Number.Substring(3,3),
            this.Number.Substring(6,4));
    }
}
