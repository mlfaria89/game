﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class readstring : MonoBehaviour
{
    //public static string[] dictiog = System.IO.File.ReadAllLines("Assets/Dictionary/dictioger1.txt");
    //public static string[] dictioe = System.IO.File.ReadAllLines("Assets/Dictionary/dictioen1.txt");
    public static string[] dictiog = new string[] { "sein",
"haben",
"können",
"müssen",
"sagen",
"machen",
"Jahr",
"geben",
"kommen",
"sollen",
"wollen",
"immer",
"gehen",
"groß",
"wieder",
"gut",
"wissen",
"neu",
"sehen",
"lassen",
"stehen",
"Beispiel",
"Zeit",
"lang",
"oben",
"wenig",
"Frau",
"Kind",
"etwas",
"Tag",
"finden",
"nichts",
"bleiben",
"klein",
"zwischen",
"alt",
"gegen",
"ohne",
"nein",
"heute",
"natürlich",
"hoch",
"beide",
"Mann",
"einfach",
"vielleicht",
"dort",
"einmal",
"nehmen",
"seit",
"denken",
"halten",
"nennen",
"letzte",
"zeigen",
"möglich",
"sprechen",
"während",
"Haus",
"Leute",
"schön",
"bereits",
"Arbeit",
"leben",
"fahren",
"später",
"fragen",
"wichtig",
"Hand",
"genau",
"jung",
"Teil",
"Problem",
"Welt",
"bisschen",
"spielen",
"arbeiten",
"brauchen",
"folgen",
"lernen",
"Ende",
"kurz",
"stark",
"Schule",
"Woche",
"richtig",
"Vater",
"verschieden",
"fast",
"Mutter",
"besser",
"schnell",
"Auge",
"sicher",
"beginnen",
"erzählen",
"Wort",
"schreiben",
"nächste",
"Geld"
};
    public static string[] dictioe = new string[] { "to be",
"to have",
"can",
"must",
"to say",
"to make",
"year",
"to give",
"to come",
"should",
"to want",
"always",
"to go",
"big",
"again",
"good",
"to know",
"new",
"to see",
"to let",
"to stand",
"Example",
"time",
"long",
"above",
"few",
"woman",
"child",
"some",
"day",
"to find",
"nothing",
"to stay",
"small",
"between",
"old",
"against",
"without",
"no",
"today",
"naturally",
"high",
"both",
"man",
"simple",
"perhaps",
"there",
"once",
"to take",
"since",
"to think",
"to stop",
"to name",
"last",
"to show",
"possible",
"to speak",
"during",
"house",
"people",
"beautiful",
"already",
"work",
"to live",
"to drive",
"later",
"to ask",
"important",
"hand",
"exact",
"young",
"part",
"problem",
"world",
"a little",
"to play",
"to work",
"to need",
"to follow",
"to learn",
"end",
"short",
"strong",
"school",
"week",
"correct",
"father",
"different",
"almost",
"mother",
"better",
"fast",
"eye",
"safe",
"to begin",
"to tell",
"word",
"to write",
"next",
"money" };




    // Start is called before the first frame update
    void Start()
    {
        

    }

     //Update is called once per frame
    void Update()
    {
        if (selectlevel.level == 1)
        {
            dictiog = new string[] {"sein",
"haben",
"können",
"müssen",
"sagen",
"machen",
"Jahr",
"geben",
"kommen",
"sollen",
"wollen",
"immer",
"gehen",
"groß",
"wieder",
"gut",
"wissen",
"neu",
"sehen",
"lassen",
"stehen",
"Beispiel",
"Zeit",
"lang",
"oben",
"wenig",
"Frau",
"Kind",
"etwas",
"Tag",
"finden",
"nichts",
"bleiben",
"klein",
"zwischen",
"alt",
"gegen",
"ohne",
"nein",
"heute",
"natürlich",
"hoch",
"beide",
"Mann",
"einfach",
"vielleicht",
"dort",
"einmal",
"nehmen",
"seit",
"denken",
"halten",
"nennen",
"letzte",
"zeigen",
"möglich",
"sprechen",
"während",
"Haus",
"Leute",
"schön",
"bereits",
"Arbeit",
"leben",
"fahren",
"später",
"fragen",
"wichtig",
"Hand",
"genau",
"jung",
"Teil",
"Problem",
"Welt",
"bisschen",
"spielen",
"arbeiten",
"brauchen",
"folgen",
"lernen",
"Ende",
"kurz",
"stark",
"Schule",
"Woche",
"richtig",
"Vater",
"verschieden",
"fast",
"Mutter",
"besser",
"schnell",
"Auge",
"sicher",
"beginnen",
"erzählen",
"Wort",
"schreiben",
"nächste",
"Geld"
};
            dictioe = new string[] {"to be",
"to have",
"can",
"must",
"to say",
"to make",
"year",
"to give",
"to come",
"should",
"to want",
"always",
"to go",
"big",
"again",
"good",
"to know",
"new",
"to see",
"to let",
"to stand",
"Example",
"time",
"long",
"above",
"few",
"woman",
"child",
"some",
"day",
"to find",
"nothing",
"to stay",
"small",
"between",
"old",
"against",
"without",
"no",
"today",
"naturally",
"high",
"both",
"man",
"simple",
"perhaps",
"there",
"once",
"to take",
"since",
"to think",
"to stop",
"to name",
"last",
"to show",
"possible",
"to speak",
"during",
"house",
"people",
"beautiful",
"already",
"work",
"to live",
"to drive",
"later",
"to ask",
"important",
"hand",
"exact",
"young",
"part",
"problem",
"world",
"a little",
"to play",
"to work",
"to need",
"to follow",
"to learn",
"end",
"short",
"strong",
"school",
"week",
"correct",
"father",
"different",
"almost",
"mother",
"better",
"fast",
"eye",
"safe",
"to begin",
"to tell",
"word",
"to write",
"next",
"money" };
        }

        if (selectlevel.level == 2)
        {
            dictiog = new string[] {"erklären",
"Sache",
"klar",
"allein",
"Weg",
"Stunde",
"Geschichte",
"Gesellschaft",
"Kopf",
"treffen",
"suchen",
"Buch",
"Wasser",
"Form",
"handeln",
"Entwicklung",
"Monat",
"erreichen",
"Abend",
"Aufgabe",
"frei",
"Sinn",
"früh",
"lesen",
"Ziel",
"Freund",
"Thema",
"schlecht",
"verlieren",
"Ding",
"Zahl",
"Eltern",
"erkennen",
"Straße",
"voll",
"mehrere",
"Gruppe",
"Gesicht",
"Sprache",
"erwarten",
"rot",
"Ort",
"warten",
"manchmal",
"jemand",
"Bedeutung",
"Tür",
"Text",
"Ergebnis",
"helfen",
"Krieg",
"niemand",
"gewinnen",
"halb",
"schließen",
"Regierung",
"Stück",
"Wohnung",
"fühlen",
"Gespräch",
"bieten",
"wesentlich",
"erinnern",
"ähnlich",
"häufig",
"Lehrer",
"Preis",
"verbinden",
"Jahrhundert",
"Sohn",
"bedeuten",
"schwarz",
"vergleichen",
"sofort",
"Stimme",
"plötzlich",
"Richtung",
"nutzen",
"Angst",
"Kunst",
"Musik",
"bald",
"genug",
"wachsen",
"Regel",
"Schritt",
"Gott",
"Auto",
"Beziehung",
"Erfahrung",
"endlich",
"Tisch",
"Licht",
"tief",
"zusätzlich",
"Kirche",
"gestern",
"interessant",
"zunehmen",
"bestimmen" };

            dictioe = new string[] {"to explain",
"thing",
"clear",
"alone",
"way",
"hour",
"history",
"society",
"head",
"to meet",
"to search",
"book",
"water",
"shape",
"to deal",
"development",
"month",
"to achieve",
"evening",
"task",
"free",
"sense",
"early",
"to read",
"goal",
"friend",
"subject",
"bad",
"to lose",
"thing",
"number",
"parents",
"to recognize",
"street",
"full",
"several",
"group",
"face",
"language",
"to expect",
"red",
"place",
"to wait",
"sometimes",
"someone",
"meaning",
"door",
"text",
"result",
"to help",
"war",
"nobody",
"to win",
"half",
"to close",
"government",
"piece",
"apartment",
"to feel",
"conversation",
"to offer",
"essential",
"to remind",
"similar",
"frequent",
"teacher",
"price",
"to connect",
"century",
"son",
"to mean",
"black",
"to compare",
"immediately",
"voice",
"suddenly",
"direction",
"to use",
"fear",
"art",
"music",
"soon",
"enough",
"to grow",
"rule",
"step",
"god",
"car",
"relation",
"experience",
"finally",
"table",
"light",
"deep",
"additional",
"church",
"yesterday",
"interesting",
"to increase",
"to decide" };
        }

        if (selectlevel.level == 3)
        {
            dictiog = new string[] {"Mädchen",
"schlagen",
"treten",
"Gesetz",
"wählen",
"Erfolg",
"Angebot",
"entscheidend",
"eng",
"insgesamt",
"Leistung",
"stattfinden",
"feststellen",
"notwendig",
"rein",
"berichten",
"rechnen",
"beobachten",
"Meinung",
"Kunde",
"sterben",
"Wirtschaft",
"werfen",
"fest",
"Sicherheit",
"teilen",
"besuchen",
"Sommer",
"sorgen",
"Verbindung",
"ankommen",
"Anwendung",
"fertig",
"spüren",
"Ausbildung",
"breit",
"Vertrag",
"erfüllen",
"Maßnahme",
"Ordnung",
"Stoff",
"Reihe",
"merken",
"Ebene",
"Einheit",
"Vorteil",
"Bedingung",
"Risiko",
"dunkel",
"Untersuchung",
"bestätigen",
"Einfluss",
"erfolgreich",
"drohen",
"ehemalig",
"Kampf",
"drehen",
"überraschen",
"fliegen",
"heben",
"Erinnerung",
"Küche",
"liefern",
"toll",
"Grundlage",
"verhindern",
"täglich",
"Gemeinde",
"leer",
"ungefhär",
"begründen",
"Haut",
"schützen",
"stören",
"Schaden",
"Umgebung",
"Zweck",
"Angriff",
"Grad",
"zufrieden",
"Unterricht",
"ablehnen",
"entfernen",
"schneiden",
"Berg",
"Freiheit",
"Ereignis",
"Opfer",
"Urlaub",
"Wahrheit",
"beruflich",
"empfehlen",
"Gebäude",
"Schiff",
"Hoffnung",
"schreien",
"Traum",
"laut",
"Ehe",
"Insel" };
            dictioe = new string[] {"girl",
"to hit",
"to step",
"law",
"to choose",
"success",
"offer",
"decisive",
"narrow",
"altogether",
"performance",
"to occur",
"to stablish",
"necessary",
"pure",
"to report",
"to calculate",
"to observe",
"opinion",
"customer",
"to die",
"economy",
"to throw",
"firm",
"security",
"to share",
"to visit",
"summer",
"to worry",
"connection",
"to arrive",
"application",
"finished",
"to sense",
"training",
"wide",
"contract",
"to fulfil",
"measure",
"order",
"substance",
"row",
"to notice",
"plane",
"unity",
"advantage",
"condition",
"risk",
"dark",
"examination",
"to confirm",
"influence",
"successful",
"to threaten",
"former",
"fight",
"to turn",
"to surprise",
"to fly",
"to lift",
"memory",
"kitchen",
"to deliver",
"great",
"basis",
"to prevent",
"daily",
"community",
"empty",
"approximately",
"to justify",
"skin",
"to protect",
"to disturb",
"damage",
"surroundings",
"purpose",
"attack",
"degree",
"satisfied",
"instruction",
"to refuse",
"to remove",
"to cut",
"mountain",
"freedom",
"event",
"victim",
"vacation",
"truth",
"professional",
"to recommend",
"building",
"ship",
"hope",
"to scream",
"dream",
"loud",
"marriage",
"island" };
        }
    }
}