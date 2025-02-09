﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Conversion.Model
{
    public class UnitFamily
    {
        public static UnitFamily Mph { get; private set; } = new UnitFamily(
            new Unit("mile per hour", "miles per hour"),
            "mph");

        public static UnitFamily Kmph { get; private set; } = new UnitFamily(
            new Unit("kilometre per hour", "kilometres per hour"),
            new Unit("kilometer per hour", "kilometers per hour"),
            "km/h",
            "km / h",
            "kph",
            "kmph"
            );

        public static UnitFamily Mps { get; private set; } = new UnitFamily(
            new Unit("metre per second", "metres per second"),
            new Unit("meter per second", "meters per second"),
            new Unit("m/s")
        );
        
        public static UnitFamily Knots { get; private set; } = new UnitFamily(
            new Unit("knot", "knots")
            );

        public static UnitFamily Meters { get; private set; } = new UnitFamily(
            new Unit("metre", "metres"),
            new Unit("meter", "meters"),
            "m",

            new Unit("lightyear", "lightyears", 9.4605284 * 1_000_000_000_000_000),
            new Unit("light year", "light years", 9.4605284 * 1_000_000_000_000_000),

            new Unit("kilometre", "kilometres", 1000),
            new Unit("kilometer", "kilometers", 1000),
            new Unit("km", 1000),

            new Unit("centimetre", "centimetres", 0.01),
            new Unit("centimeter", "centimeters", 0.01),
            new Unit("cm", 0.01),

            new Unit("millimetre", "millimetres", 0.001),
            new Unit("millimeter", "millimeters", 0.001),
            new Unit("mm", 0.001)
        );

        public static UnitFamily ImperialDistances { get; private set; } = new UnitFamily(
            new Unit("foot", "feet"),
            "ft",

            new Unit("mile", "miles", 5280),
            new Unit("mi", 5280),

            new Unit("inch", "inches", 1.0 / 12),
            new Unit("in", 1.0 / 12),

            new Unit("thousandth of an inch", "thousandths of an inch", 1.0 / 12000),
            new Unit("thou", "thous", 1.0 / 12000)
        );

        public static UnitFamily Yards { get; private set; } = new UnitFamily(
            new Unit("yard", "yards"),
            "yd"
        );

        public static UnitFamily MetricArea { get; private set; } = new UnitFamily(
            new Unit("square metre", "square metres"),
            new Unit("square meter", "square meters"),
            new Unit("metre squared", "metres squared"),
            new Unit("meter squared", "meters squared"),
            "m2",
            "m^2",

            new Unit("square kilometre", "square kilometres", 1_000_000),
            new Unit("square kilometer", "square kilometers", 1_000_000),
            new Unit("kilometre squared", "kilometres squared", 1_000_000),
            new Unit("kilometer squared", "kilometers squared", 1_000_000),
            new Unit("km2", 1_000_000),
            new Unit("km^2", 1_000_000)
        );

        public static UnitFamily ImperialArea { get; private set; } = new UnitFamily(
            new Unit("square foot", "square feet"),
            new Unit("square ft"),
            new Unit("foot squared", "feet squared"),
            new Unit("ft squared"),
            "ft2",
            "ft^2",

            new Unit("square mile", "square miles", 27_878_400),
            new Unit("square mi", 27_878_400),
            new Unit("mile squared", "miles squared", 27_878_400),
            new Unit("mi squared", 27_878_400),
            new Unit("mi2", 27_878_400),
            new Unit("mi^2", 27_878_400)
        );

        public static UnitFamily Kilograms { get; private set; } = new UnitFamily(
            new Unit("kilogram", "kilograms"),
            "kg",
            new Unit("kilo", "kilos"),

            new Unit("gram", "grams", 0.001),
            new Unit("g", 0.001),
            new Unit("milligram", "milligrams", 0.000001),
            new Unit("mg", 0.000001),
            new Unit("microgram", "micrograms", 0.000000001),
            new Unit("µg", 0.000000001),

            new Unit("metric ton", "metric tons", 1000),
            new Unit("tonne", "tonnes", 1000)
        );

        public static UnitFamily Pounds { get; private set; } = new UnitFamily(
            new Unit("pound", "pounds"),
            new Unit("lb", "lbs"),

            new Unit("ounce", "ounces", 1.0 / 16),
            new Unit("oz", 1.0 / 16),

            new Unit("short ton", "short tons", 2000),
            new Unit("long ton", "long tons", 2240)
        );

        public static UnitFamily Stones { get; private set; } = new UnitFamily(
            new Unit("stone", "stone")
            //TODO: add "st" when it can be done without catching "1st"
        );

        //TODO: add troy pounds and ounces

        public static UnitFamily ImperialVolumes { get; private set; } = new UnitFamily(
            new Unit("imperial gallon", "imperial gallons"),
            "imperial gal",

            new Unit("imperial quart", "imperial quarts", 0.25),
            new Unit("imperial qt", 0.25),
            new Unit("imperial pint", "imperial pints", 0.125),
            new Unit("imperial pt", 0.125),
            new Unit("imperial fluid ounce", "imperial fluid ounces", 0.00625),
            new Unit("imperial fl oz", "imperial fl oz", 0.00625)
        );

        public static UnitFamily USVolumes { get; private set; } = new UnitFamily(
            new Unit("us gallon", "us gallons"),
            new Unit("gallon", "gallons"),
            "gal",

            new Unit("us quart", "us quarts", 0.25),
            new Unit("quart", "quarts", 0.25),
            new Unit("qt", 0.25),
            new Unit("us pint", "us pints", 0.125),
            new Unit("pint", "pints", 0.125),
            new Unit("pt", 0.125), //TODO: dont catch "pt. 1" and similar
            new Unit("us fluid ounce", "us fluid ounces", 0.0078125),
            new Unit("fluid ounce", "fluid ounces", 0.0078125),
            new Unit("fl oz", 0.0078125)
        );

        public static UnitFamily Liters { get; private set; } = new UnitFamily(
            new Unit("liter", "liters"),
            new Unit("litre", "litres"),
            "l",

            new Unit("deciliter", "deciliters", 0.1),
            new Unit("decilitre", "decilitres", 0.1),
            new Unit("dl", 0.1), //TODO: these abbreviations often give false positives. Add range limits

            new Unit("centiliter", "centiliters", 0.01),
            new Unit("centilitre", "centilitres", 0.01),
            new Unit("cl", 0.01),

            new Unit("milliliter", "milliliters", 0.001),
            new Unit("millilitre", "millilitres", 0.001),
            new Unit("ml", 0.001)
        );

        public static UnitFamily Celcius { get; private set; } = new UnitFamily(
            "° Celsius",
            "celsius",
            new Unit("degree celsius", "degrees celsius"),
            "* celsius",
            "° C",
            "°C", 
            "C", //TODO: dont catch this, too many false positives?
            new Unit("degree C", "degrees C"),
            "* C",
            "*C"
        );

        public static UnitFamily Fahrenheit { get; private set; } = new UnitFamily(
            "° Fahrenheit",
            "fahrenheit",
            new Unit("degree fahrenheit", "degrees fahrenheit"),
            "* fahrenheit",
            "° F",
            "°F",
            "F", //TODO: dont catch this, too many false positives?
            new Unit("degree F", "degrees F"),
            "* F",
            "*F"
        );

        public static UnitFamily Kelvin { get; private set; } = new UnitFamily(
            "Kelvin",
            "° kelvin",
            new Unit("degree kelvin", "degrees kelvin"),
            "* kelvin",
            "° K",
            "°K",
            //"K", //removed to not catch people writing it meaning 1000
            new Unit("degree K", "degrees K"),
            "* K",
            "*K"
        );

        //TODO: it's hacky that we need to state these here
        public static List<UnitFamily> AllFamilies => new List<UnitFamily>
        {
            Mph,
            Kmph,
            Mps,
            Meters,
            ImperialDistances,
            Kilograms,
            Pounds,
            ImperialVolumes, //We need this to be first because USVolumes will also catch it
            USVolumes,
            Liters,
            Stones,
            Celcius,
            Fahrenheit,
            Kelvin,
            MetricArea,
            ImperialArea,
            Knots,
            Yards
        };

        public static IEnumerable<Unit> AllUnits => AllFamilies.SelectMany(u => u.Units);

        public Unit GetUnit(string unit)
        {
            var u = Units.FirstOrDefault(e => e.Singular == unit || e.Plural == unit);

            if (u != null)
                return u;

            throw new Exception($"Could not find unit '{unit}' in the '{this.Units.First().Singular}' family.");
        }

        public Unit PrimaryUnit => Units.First(u => u.Ratio == 1.0);

        static UnitFamily()
        {
            //TODO: This is hacky
            //make all units aware of their family
            foreach (var unit in AllFamilies)
            {
                foreach (var u in unit.Units)
                {
                    u.UnitFamily = unit;
                }
            }
        }
        
        public IEnumerable<Unit> Units { get; private set; }

        public UnitFamily(params Unit[] units)
        {
            Units = new List<Unit>(units);
        }
    }
    
    public class Unit
    {
        public string Singular { get; private set; }
        public string Plural { get; private set; }
        public double Ratio { get; private set; } = 1;
        public UnitFamily UnitFamily { get; set; }

        public Unit(string singular, string plural, double ratio = 1.0)
        {
            Singular = singular;
            Plural = plural;
            Ratio = ratio;
        }

        public Unit(string singular, double ratio = 1.0) : this(singular, singular, ratio)
        { }

        public static implicit operator Unit(string singular)
        {
            return new Unit(singular, singular);
        }

        public static bool operator ==(Unit u1, Unit u2)
        {
            return EqualityComparer<Unit>.Default.Equals(u1, u2);
        }

        public static bool operator !=(Unit u1, Unit u2)
        {
            return !(u1 == u2);
        }

        public override bool Equals(object obj)
        {
            var u = obj as Unit;
            return u != null &&
                   Singular == u.Singular &&
                   Plural == u.Plural &&
                   Ratio == u.Ratio &&
                   EqualityComparer<UnitFamily>.Default.Equals(UnitFamily, u.UnitFamily);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Singular, Plural, Ratio, UnitFamily);
        }
    }

    public class Measurement
    {
        public Unit Unit { get; private set; }
        public double Amount { get; private set; }

        public Measurement(Unit unit, double amount)
        {
            Unit = unit;
            Amount = amount;
        }

        public void Invert()
        {
            Amount = -Amount;
        }

        public double BaseAmount => Amount * Unit.Ratio;

        public override string ToString()
        {
            return Amount.ToString("#.##########", CultureInfo.InvariantCulture);
        }

        public override bool Equals(object obj)
        {
            var measurement = obj as Measurement;
            return measurement != null &&
                   EqualityComparer<Unit>.Default.Equals(Unit, measurement.Unit) &&
                   Amount == measurement.Amount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Unit, Amount);
        }

        public static bool operator ==(Measurement measurement1, Measurement measurement2)
        {
            return EqualityComparer<Measurement>.Default.Equals(measurement1, measurement2);
        }

        public static bool operator !=(Measurement measurement1, Measurement measurement2)
        {
            return !(measurement1 == measurement2);
        }
    }

    public class DetectedMeasurement:Measurement
    {
        public string DetectedString;
        public int SignificantDigits;

        public DetectedMeasurement(Unit unit, double amount, int significantDigits, string detectedString):base(unit, amount)
        {
            DetectedString = detectedString;
            SignificantDigits = significantDigits;
        }

        public DetectedMeasurement(Unit unit, double amount) : base(unit, amount)
        {
        }
    }

    public class NonDetectedMeasurement : DetectedMeasurement
    {
        public NonDetectedMeasurement(string detectedString) : base(null, Double.NaN, 0, detectedString)
        {
        }
    }
}
