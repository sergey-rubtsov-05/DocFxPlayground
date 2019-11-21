using System;

namespace MyService.API
{
    /// <summary>
    /// Contains supported timeframe values from Minute 1 to Monthly.
    /// </summary>
    /// <example>
    /// <code>
    /// if(TimeFrame  &lt; TimeFrame.Daily)
    ///     Print("Intraday Trading");     
    /// </code>
    /// </example>
    public class TimeFrame
    {
        private readonly PredefinedTimeFrame _timeFrame;

        private TimeFrame(PredefinedTimeFrame timeFrame)
        {
            _timeFrame = timeFrame;
        }
        
        /// <summary>
        /// 1 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute = new TimeFrame(PredefinedTimeFrame.Minute);
        /// <summary>
        /// 2 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute2 = new TimeFrame(PredefinedTimeFrame.Minute2);
        /// <summary>
        /// 3 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute3 = new TimeFrame(PredefinedTimeFrame.Minute3);
        /// <summary>
        /// 4 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute4 = new TimeFrame(PredefinedTimeFrame.Minute4);
        /// <summary>
        /// 5 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute5 = new TimeFrame(PredefinedTimeFrame.Minute5);
        /// <summary>
        /// 6 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute6 = new TimeFrame(PredefinedTimeFrame.Minute6);
        /// <summary>
        /// 7 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute7 = new TimeFrame(PredefinedTimeFrame.Minute7);
        /// <summary>
        /// 8 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute8 = new TimeFrame(PredefinedTimeFrame.Minute8);
        /// <summary>
        /// 9 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute9 = new TimeFrame(PredefinedTimeFrame.Minute9);
        /// <summary>
        /// 10 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute10 = new TimeFrame(PredefinedTimeFrame.Minute10);
        /// <summary>
        /// 15 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute15 = new TimeFrame(PredefinedTimeFrame.Minute15);
        /// <summary>
        /// 20 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute20 = new TimeFrame(PredefinedTimeFrame.Minute20);
        /// <summary>
        /// 30 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute30 = new TimeFrame(PredefinedTimeFrame.Minute30);
        /// <summary>
        /// 45 Minute Timeframe
        /// </summary>
        public static readonly TimeFrame Minute45 = new TimeFrame(PredefinedTimeFrame.Minute45);
        /// <summary>
        /// 1 hour Timeframe
        /// </summary>
        public static readonly TimeFrame Hour = new TimeFrame(PredefinedTimeFrame.Hour);
        /// <summary>
        /// 2 hour Timeframe
        /// </summary>
        public static readonly TimeFrame Hour2 = new TimeFrame(PredefinedTimeFrame.Hour2);
        /// <summary>
        /// 3 hour Timeframe
        /// </summary>
        public static readonly TimeFrame Hour3 = new TimeFrame(PredefinedTimeFrame.Hour3);
        /// <summary>
        /// 4 hour Timeframe
        /// </summary>
        public static readonly TimeFrame Hour4 = new TimeFrame(PredefinedTimeFrame.Hour4);
        /// <summary>
        /// 6 hour Timeframe
        /// </summary>
        public static readonly TimeFrame Hour6 = new TimeFrame(PredefinedTimeFrame.Hour6);
        /// <summary>
        /// 8 hour Timeframe
        /// </summary>
        public static readonly TimeFrame Hour8 = new TimeFrame(PredefinedTimeFrame.Hour8);
        /// <summary>
        /// 12 hour Timeframe
        /// </summary>
        public static readonly TimeFrame Hour12 = new TimeFrame(PredefinedTimeFrame.Hour12);
        /// <summary>
        /// Daily Timeframe
        /// </summary>
        public static readonly TimeFrame Daily = new TimeFrame(PredefinedTimeFrame.Daily);
        /// <summary>
        /// 2 day Timeframe
        /// </summary>
        public static readonly TimeFrame Day2 = new TimeFrame(PredefinedTimeFrame.Day2);
        /// <summary>
        /// 3 day Timeframe
        /// </summary>
        public static readonly TimeFrame Day3 = new TimeFrame(PredefinedTimeFrame.Day3);
        /// <summary>
        /// Weekly Timeframe
        /// </summary>
        public static readonly TimeFrame Weekly = new TimeFrame(PredefinedTimeFrame.Weekly);
        /// <summary>
        /// Monthly Timeframe
        /// </summary>
        public static readonly TimeFrame Monthly = new TimeFrame(PredefinedTimeFrame.Monthly);
        /// <summary>
        /// 1 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick = new TimeFrame(PredefinedTimeFrame.Tick);
        /// <summary>
        /// 2 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick2 = new TimeFrame(PredefinedTimeFrame.Tick2);
        /// <summary>
        /// 3 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick3 = new TimeFrame(PredefinedTimeFrame.Tick3);
        /// <summary>
        /// 4 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick4 = new TimeFrame(PredefinedTimeFrame.Tick4);
        /// <summary>
        /// 5 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick5 = new TimeFrame(PredefinedTimeFrame.Tick5);
        /// <summary>
        /// 6 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick6 = new TimeFrame(PredefinedTimeFrame.Tick6);
        /// <summary>
        /// 7 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick7 = new TimeFrame(PredefinedTimeFrame.Tick7);
        /// <summary>
        /// 8 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick8 = new TimeFrame(PredefinedTimeFrame.Tick8);
        /// <summary>
        /// 9 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick9 = new TimeFrame(PredefinedTimeFrame.Tick9);
        /// <summary>
        /// 10 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick10 = new TimeFrame(PredefinedTimeFrame.Tick10);
        /// <summary>
        /// 13 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick13 = new TimeFrame(PredefinedTimeFrame.Tick13);
        /// <summary>
        /// 21 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick21 = new TimeFrame(PredefinedTimeFrame.Tick21);
        /// <summary>
        /// 34 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick34 = new TimeFrame(PredefinedTimeFrame.Tick34);
        /// <summary>
        /// 55 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick55 = new TimeFrame(PredefinedTimeFrame.Tick55);
        /// <summary>
        /// 144 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick144 = new TimeFrame(PredefinedTimeFrame.Tick144);
        /// <summary>
        /// 233 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick233 = new TimeFrame(PredefinedTimeFrame.Tick233);
        /// <summary>
        /// 377 tick TimeFrame
        /// </summary>
        internal static readonly TimeFrame Tick377 = new TimeFrame(PredefinedTimeFrame.Tick377);


        internal static readonly TimeFrame Tick15 = new TimeFrame(PredefinedTimeFrame.Tick15);
        internal static readonly TimeFrame Tick20 = new TimeFrame(PredefinedTimeFrame.Tick20);
        internal static readonly TimeFrame Tick25 = new TimeFrame(PredefinedTimeFrame.Tick25);
        internal static readonly TimeFrame Tick30 = new TimeFrame(PredefinedTimeFrame.Tick30);
        internal static readonly TimeFrame Tick40 = new TimeFrame(PredefinedTimeFrame.Tick40);
        internal static readonly TimeFrame Tick50 = new TimeFrame(PredefinedTimeFrame.Tick50);
        internal static readonly TimeFrame Tick60 = new TimeFrame(PredefinedTimeFrame.Tick60);
        internal static readonly TimeFrame Tick80 = new TimeFrame(PredefinedTimeFrame.Tick80);
        internal static readonly TimeFrame Tick90 = new TimeFrame(PredefinedTimeFrame.Tick90);
        internal static readonly TimeFrame Tick100 = new TimeFrame(PredefinedTimeFrame.Tick100);
        internal static readonly TimeFrame Tick150 = new TimeFrame(PredefinedTimeFrame.Tick150);
        internal static readonly TimeFrame Tick200 = new TimeFrame(PredefinedTimeFrame.Tick200);
        internal static readonly TimeFrame Tick250 = new TimeFrame(PredefinedTimeFrame.Tick250);
        internal static readonly TimeFrame Tick300 = new TimeFrame(PredefinedTimeFrame.Tick300);
        internal static readonly TimeFrame Tick500 = new TimeFrame(PredefinedTimeFrame.Tick500);
        internal static readonly TimeFrame Tick750 = new TimeFrame(PredefinedTimeFrame.Tick750);
        internal static readonly TimeFrame Tick1000 = new TimeFrame(PredefinedTimeFrame.Tick1000);

        internal static readonly TimeFrame Renko1 = new TimeFrame(PredefinedTimeFrame.Renko1);
        internal static readonly TimeFrame Renko2 = new TimeFrame(PredefinedTimeFrame.Renko2);
        internal static readonly TimeFrame Renko3 = new TimeFrame(PredefinedTimeFrame.Renko3);
        internal static readonly TimeFrame Renko4 = new TimeFrame(PredefinedTimeFrame.Renko4);
        internal static readonly TimeFrame Renko5 = new TimeFrame(PredefinedTimeFrame.Renko5);
        internal static readonly TimeFrame Renko6 = new TimeFrame(PredefinedTimeFrame.Renko6);
        internal static readonly TimeFrame Renko7 = new TimeFrame(PredefinedTimeFrame.Renko7);
        internal static readonly TimeFrame Renko8 = new TimeFrame(PredefinedTimeFrame.Renko8);
        internal static readonly TimeFrame Renko9 = new TimeFrame(PredefinedTimeFrame.Renko9);
        internal static readonly TimeFrame Renko10 = new TimeFrame(PredefinedTimeFrame.Renko10);
        internal static readonly TimeFrame Renko15 = new TimeFrame(PredefinedTimeFrame.Renko15);
        internal static readonly TimeFrame Renko20 = new TimeFrame(PredefinedTimeFrame.Renko20);
        internal static readonly TimeFrame Renko25 = new TimeFrame(PredefinedTimeFrame.Renko25);
        internal static readonly TimeFrame Renko30 = new TimeFrame(PredefinedTimeFrame.Renko30);
        internal static readonly TimeFrame Renko35 = new TimeFrame(PredefinedTimeFrame.Renko35);
        internal static readonly TimeFrame Renko40 = new TimeFrame(PredefinedTimeFrame.Renko40);
        internal static readonly TimeFrame Renko45 = new TimeFrame(PredefinedTimeFrame.Renko45);
        internal static readonly TimeFrame Renko50 = new TimeFrame(PredefinedTimeFrame.Renko50);
        internal static readonly TimeFrame Renko100 = new TimeFrame(PredefinedTimeFrame.Renko100);

        internal static readonly TimeFrame Range1 = new TimeFrame(PredefinedTimeFrame.Range1);
        internal static readonly TimeFrame Range2 = new TimeFrame(PredefinedTimeFrame.Range2);
        internal static readonly TimeFrame Range3 = new TimeFrame(PredefinedTimeFrame.Range3);
        internal static readonly TimeFrame Range4 = new TimeFrame(PredefinedTimeFrame.Range4);
        internal static readonly TimeFrame Range5 = new TimeFrame(PredefinedTimeFrame.Range5);
        internal static readonly TimeFrame Range8 = new TimeFrame(PredefinedTimeFrame.Range8);
        internal static readonly TimeFrame Range10 = new TimeFrame(PredefinedTimeFrame.Range10);
        internal static readonly TimeFrame Range20 = new TimeFrame(PredefinedTimeFrame.Range20);
        internal static readonly TimeFrame Range30 = new TimeFrame(PredefinedTimeFrame.Range30);
        internal static readonly TimeFrame Range50 = new TimeFrame(PredefinedTimeFrame.Range50);
        internal static readonly TimeFrame Range80 = new TimeFrame(PredefinedTimeFrame.Range80);
        internal static readonly TimeFrame Range100 = new TimeFrame(PredefinedTimeFrame.Range100);
        internal static readonly TimeFrame Range150 = new TimeFrame(PredefinedTimeFrame.Range150);
        internal static readonly TimeFrame Range200 = new TimeFrame(PredefinedTimeFrame.Range200);
        internal static readonly TimeFrame Range300 = new TimeFrame(PredefinedTimeFrame.Range300);
        internal static readonly TimeFrame Range500 = new TimeFrame(PredefinedTimeFrame.Range500);
        internal static readonly TimeFrame Range800 = new TimeFrame(PredefinedTimeFrame.Range800);
        internal static readonly TimeFrame Range1000 = new TimeFrame(PredefinedTimeFrame.Range1000);
        internal static readonly TimeFrame Range2000 = new TimeFrame(PredefinedTimeFrame.Range2000);
        internal static readonly TimeFrame Range5000 = new TimeFrame(PredefinedTimeFrame.Range5000);
        internal static readonly TimeFrame Range7500 = new TimeFrame(PredefinedTimeFrame.Range7500);
        internal static readonly TimeFrame Range10000 = new TimeFrame(PredefinedTimeFrame.Range1000);

        /// <summary>
        /// Convert the TimeFrame property to a string
        /// </summary>
        /// <returns>the string representation of the timeframe</returns>
        /// <example>
        /// <code>
        /// Print("TimeFrame is {0}", TimeFrame.Daily.ToString());
        /// </code>
        /// </example>
        public override string ToString()
        {
            switch (_timeFrame)
            {
                case PredefinedTimeFrame.Tick:
                    return "Tick";
                case PredefinedTimeFrame.Tick2:
                    return "Tick2";
                case PredefinedTimeFrame.Tick3:
                    return "Tick3";
                case PredefinedTimeFrame.Tick4:
                    return "Tick4";
                case PredefinedTimeFrame.Tick5:
                    return "Tick5";
                case PredefinedTimeFrame.Tick6:
                    return "Tick6";
                case PredefinedTimeFrame.Tick7:
                    return "Tick7";
                case PredefinedTimeFrame.Tick8:
                    return "Tick8";
                case PredefinedTimeFrame.Tick9:
                    return "Tick9";
                case PredefinedTimeFrame.Tick10:
                    return "Tick10";
                case PredefinedTimeFrame.Tick13:
                    return "Tick13";
                case PredefinedTimeFrame.Tick21:
                    return "Tick21";
                case PredefinedTimeFrame.Tick34:
                    return "Tick34";
                case PredefinedTimeFrame.Tick55:
                    return "Tick55";
                case PredefinedTimeFrame.Tick144:
                    return "Tick144";
                case PredefinedTimeFrame.Tick233:
                    return "Tick233";
                case PredefinedTimeFrame.Tick377:
                    return "Tick377";
                case PredefinedTimeFrame.Tick15:
                    return "Tick15";
                case PredefinedTimeFrame.Tick20:
                    return "Tick20";
                case PredefinedTimeFrame.Tick25:
                    return "Tick25";
                case PredefinedTimeFrame.Tick30:
                    return "Tick30";
                case PredefinedTimeFrame.Tick40:
                    return "Tick40";
                case PredefinedTimeFrame.Tick50:
                    return "Tick50";
                case PredefinedTimeFrame.Tick60:
                    return "Tick60";
                case PredefinedTimeFrame.Tick80:
                    return "Tick80";
                case PredefinedTimeFrame.Tick90:
                    return "Tick90";
                case PredefinedTimeFrame.Tick100:
                    return "Tick100";
                case PredefinedTimeFrame.Tick150:
                    return "Tick150";
                case PredefinedTimeFrame.Tick200:
                    return "Tick200";
                case PredefinedTimeFrame.Tick250:
                    return "Tick250";
                case PredefinedTimeFrame.Tick300:
                    return "Tick300";
                case PredefinedTimeFrame.Tick500:
                    return "Tick500";
                case PredefinedTimeFrame.Tick750:
                    return "Tick750";
                case PredefinedTimeFrame.Tick1000:
                    return "Tick1000";
                case PredefinedTimeFrame.Minute:
                    return "Minute";
                case PredefinedTimeFrame.Minute2:
                    return "Minute2";
                case PredefinedTimeFrame.Minute3:
                    return "Minute3";
                case PredefinedTimeFrame.Minute4:
                    return "Minute4";
                case PredefinedTimeFrame.Minute5:
                    return "Minute5";
                case PredefinedTimeFrame.Minute6:
                    return "Minute6";
                case PredefinedTimeFrame.Minute7:
                    return "Minute7";
                case PredefinedTimeFrame.Minute8:
                    return "Minute8";
                case PredefinedTimeFrame.Minute9:
                    return "Minute9";
                case PredefinedTimeFrame.Minute10:
                    return "Minute10";
                case PredefinedTimeFrame.Minute15:
                    return "Minute15";
                case PredefinedTimeFrame.Minute20:
                    return "Minute20";
                case PredefinedTimeFrame.Minute30:
                    return "Minute30";
                case PredefinedTimeFrame.Minute45:
                    return "Minute45";
                case PredefinedTimeFrame.Hour:
                    return "Hour";
                case PredefinedTimeFrame.Hour2:
                    return "Hour2";
                case PredefinedTimeFrame.Hour3:
                    return "Hour3";
                case PredefinedTimeFrame.Hour4:
                    return "Hour4";
                case PredefinedTimeFrame.Hour6:
                    return "Hour6";
                case PredefinedTimeFrame.Hour8:
                    return "Hour8";
                case PredefinedTimeFrame.Hour12:
                    return "Hour12";
                case PredefinedTimeFrame.Daily:
                    return "Daily";
                case PredefinedTimeFrame.Day2:
                    return "Day2";
                case PredefinedTimeFrame.Day3:
                    return "Day3";
                case PredefinedTimeFrame.Weekly:
                    return "Weekly";
                case PredefinedTimeFrame.Monthly:
                    return "Monthly";

                case PredefinedTimeFrame.Renko1:
                    return "Renko1";
                case PredefinedTimeFrame.Renko2:
                    return "Renko2";
                case PredefinedTimeFrame.Renko3:
                    return "Renko3";
                case PredefinedTimeFrame.Renko4:
                    return "Renko4";
                case PredefinedTimeFrame.Renko5:
                    return "Renko5";
                case PredefinedTimeFrame.Renko6:
                    return "Renko6";
                case PredefinedTimeFrame.Renko7:
                    return "Renko7";
                case PredefinedTimeFrame.Renko8:
                    return "Renko8";
                case PredefinedTimeFrame.Renko9:
                    return "Renko9";
                case PredefinedTimeFrame.Renko10:
                    return "Renko10";
                case PredefinedTimeFrame.Renko15:
                    return "Renko15";
                case PredefinedTimeFrame.Renko20:
                    return "Renko20";
                case PredefinedTimeFrame.Renko25:
                    return "Renko25";
                case PredefinedTimeFrame.Renko30:
                    return "Renko30";
                case PredefinedTimeFrame.Renko35:
                    return "Renko35";
                case PredefinedTimeFrame.Renko40:
                    return "Renko40";
                case PredefinedTimeFrame.Renko45:
                    return "Renko45";
                case PredefinedTimeFrame.Renko50:
                    return "Renko50";
                case PredefinedTimeFrame.Renko100:
                    return "Renko100";

                case PredefinedTimeFrame.Range1:
                    return "Range1";
                case PredefinedTimeFrame.Range2:
                    return "Range2";
                case PredefinedTimeFrame.Range3:
                    return "Range3";
                case PredefinedTimeFrame.Range4:
                    return "Range4";
                case PredefinedTimeFrame.Range5:
                    return "Range5";
                case PredefinedTimeFrame.Range8:
                    return "Range8";
                case PredefinedTimeFrame.Range10:
                    return "Range10";
                case PredefinedTimeFrame.Range20:
                    return "Range20";
                case PredefinedTimeFrame.Range30:
                    return "Range30";
                case PredefinedTimeFrame.Range50:
                    return "Range50";
                case PredefinedTimeFrame.Range80:
                    return "Range80";
                case PredefinedTimeFrame.Range100:
                    return "Range100";
                case PredefinedTimeFrame.Range150:
                    return "Range150";
                case PredefinedTimeFrame.Range200:
                    return "Range200";
                case PredefinedTimeFrame.Range300:
                    return "Range300";
                case PredefinedTimeFrame.Range500:
                    return "Range500";
                case PredefinedTimeFrame.Range800:
                    return "Range800";
                case PredefinedTimeFrame.Range1000:
                    return "Range1000";
                case PredefinedTimeFrame.Range2000:
                    return "Range2000";
                case PredefinedTimeFrame.Range5000:
                    return "Range5000";
                case PredefinedTimeFrame.Range7500:
                    return "Range7500";
                case PredefinedTimeFrame.Range10000:
                    return "Range10000";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

#pragma warning disable 1591
        public static bool operator >(TimeFrame x, TimeFrame y)
        {
            return x._timeFrame > y._timeFrame;
        }

        public static bool operator <(TimeFrame x, TimeFrame y)
        {
            return x._timeFrame < y._timeFrame;
        }

        public static bool operator >=(TimeFrame x, TimeFrame y)
        {
            return x._timeFrame >= y._timeFrame;
        }

        public static bool operator <=(TimeFrame x, TimeFrame y)
        {
            return x._timeFrame <= y._timeFrame;
        }
#pragma warning restore 1591
    }
}