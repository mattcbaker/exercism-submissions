using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Bob
{
    private Dictionary<COMMUNICATION_TYPE, string> _responses;

    private enum COMMUNICATION_TYPE { 
        DEFAULT,
        QUESTION,
        YELLING,
        NO_COMMUNICATION
    }

    public Bob()
    {
        PopulateResponses();
    }

    private void PopulateResponses()
    {
        this._responses = new Dictionary<COMMUNICATION_TYPE, string>();

        this._responses.Add(COMMUNICATION_TYPE.DEFAULT, "Whatever.");
        this._responses.Add(COMMUNICATION_TYPE.YELLING, "Whoa, chill out!");
        this._responses.Add(COMMUNICATION_TYPE.QUESTION, "Sure.");
        this._responses.Add(COMMUNICATION_TYPE.NO_COMMUNICATION, "Fine. Be that way!");
    }

    internal string Hey(string p)
    {
        return this._responses[GetCommunicationType(p)];
    }

    private COMMUNICATION_TYPE GetCommunicationType(string communication)
    {
        COMMUNICATION_TYPE type = COMMUNICATION_TYPE.DEFAULT;
        communication = communication.Trim();

        if (IsYelling(communication))
        {
            type = COMMUNICATION_TYPE.YELLING;
        }
        else if (IsQuestion(communication))
        {
            type = COMMUNICATION_TYPE.QUESTION;
        }
        else if (IsNoCommunication(communication)) {
            type = COMMUNICATION_TYPE.NO_COMMUNICATION;
        }

        return type;
    }

    private bool IsYelling(string communication)
    {
        return IsAllUpper(communication);
    }

    private bool IsQuestion(string communication)
    {
        return communication.EndsWith("?");
    }

    private bool IsNoCommunication(string communication) {
        return (communication == string.Empty || communication == null);
    }

    private bool IsAllUpper(string value) {
        bool isAllUpper = true;

        if (ParseAlphaCharacters(value).Length > 0)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (Char.IsLetter(value[i]) && !Char.IsUpper(value[i]))
                    isAllUpper = false;
            }
        }
        else 
        {
            isAllUpper = false;
        }

        return isAllUpper;
    }

    private string ParseAlphaCharacters(string input) {
        return Regex.Replace(input, @"\W|\d", string.Empty);
    }
}
