using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
klasser har ALLTID denna ordning:
-backing field
-propertys (+ eventuella metoder)
-constructor
-ToString (ligger ALLTID nederst)
*/

//Skapa propertys som valideras
//skapa 3 konstruktorer
//skapa toString
//skapa 3 instanser och skriv ut dem
namespace Forelasning7_Properties
{
    class Va
    {
        //skapa stor bokstav på först ordet, kontrollera om '?' avslutar
        string questionMark;
        //mellan 3.0 och 17.0
        double inflection;

        public string QuestionMark
        {
            get
            {
                return questionMark;
            }
            set
            {
                var checkIfCapitalCase = value[0].ToString().ToUpper() == value[0].ToString();
                var endsWithQuestionMark = value[value.Length - 1] == '?';
                var validValue = value != null && checkIfCapitalCase && endsWithQuestionMark;
                if (validValue)
                    questionMark = value;
                else
                    throw new Exception("QuestionMark got an invalid value!");
            }
        }
        public double Inflection
        {
            get
            {
                return inflection;
            }
            set
            {
                var validValue = value > 3.0 && value <= 17.0;
                if (validValue)
                    inflection = value;
                else
                    throw new Exception("Värdet måste vara mellan 3-17");
            }
        }

        public Va()
        {
            QuestionMark = "?";
            Inflection = 4.5;
        }
        public Va(string questionMark)
        {
            QuestionMark = questionMark;
            Inflection = 5.5;
        }
        public Va(string questionMark, double inflection)
        {
            QuestionMark = questionMark;
            Inflection = inflection;
        }
        public override string ToString()
        {
            return $"Questionmark: {QuestionMark}, Inflection: {Inflection}";
        }
    }
}
