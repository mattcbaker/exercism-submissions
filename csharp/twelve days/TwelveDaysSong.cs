using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwelveDaysProject
{
    class TwelveDaysSong
    {
        List<Verse> _Verses;

        public TwelveDaysSong()
        {
            _Verses = BuildVerses();
        }

        public string Verse(int verseNumber)
        {
            List<Verse> verses = _Verses.Take(verseNumber).ToList();

            return string.Format("On the {0} day of Christmas my true love gave to me, {1}\n", verses.Last().Day, FormatGaveToMes(verses));
        }

        private static string FormatGaveToMes(List<Verse> verses)
        {
            var gaveToMes = verses
                .Select(v => v.GaveToMe)
                .Aggregate(
                    (running, current) =>
                    {
                        return current + running;
                    }
                );
            return gaveToMes;
        }

        public string Sing()
        {
            return Verses(1, 12);
        }

        public string Verses(int startVerse, int additionalVersesToInclude)
        {
            var formattedVerses = new List<string>();

            for (var i = startVerse; i < startVerse + additionalVersesToInclude; i++) 
            {
                formattedVerses.Add(Verse(i));
            }

            return string.Join("\n", formattedVerses) + "\n";
        }

        private List<Verse> BuildVerses()
        {
            return new List<Verse>() { 
                new Verse("first", "a Partridge in a Pear Tree."),
                new Verse("second", "two Turtle Doves, and "),
                new Verse("third", "three French Hens, "),
                new Verse("fourth", "four Calling Birds, "),
                new Verse("fifth", "five Gold Rings, "),
                new Verse("sixth", "six Geese-a-Laying, "),
                new Verse("seventh", "seven Swans-a-Swimming, "),
                new Verse("eighth", "eight Maids-a-Milking, "),
                new Verse("ninth", "nine Ladies Dancing, "),
                new Verse("tenth", "ten Lords-a-Leaping, "),
                new Verse("eleventh", "eleven Pipers Piping, "),
                new Verse("twelfth", "twelve Drummers Drumming, ")
            };
        }
    }

    class Verse
    {
        public string Day { get; set; }
        public string GaveToMe { get; set; }

        public Verse(string day, string gaveToMe)
        {
            Day = day;
            GaveToMe = gaveToMe;
        }
    }
}