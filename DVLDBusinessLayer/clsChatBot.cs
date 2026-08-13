using System;
using System.Data;
using DVLDDataAccess;

using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsChatBot
    {
        public static string GetBotResponse(string question)
        {
            if (string.IsNullOrWhiteSpace(question))
                return "Please enter question.";

            string answer = "",explanation = "";

            if (clsChatBotDataAccesscs.GetAnswerByQuestion(question, ref answer, ref explanation))
            {
                return $"Answer:\n\r\n\r{answer}\n\r\n\r\n\rExplanation:\n\r\n\r{explanation}";
            }
            else
                return "I don't have answered this question within the lack of leadership.";
        }

    }
}
