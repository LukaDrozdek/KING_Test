namespace KING_Test.Models
{
    public class FlyingData
    {
        public string numberOfBookableSeats { get; set; }

        public _price price { get; set; }
        public _itineraries[] itineraries { get; set; }

        public _travelerPricings[] travelerPricings { get; set; }
    }


    public class _price
    {
        public string currency { get; set; }
        public float total { get; set; }
    }




    public class _itineraries
    {
        public string duration { get; set; }
        public _segments[] segments { get; set; }

        public class _segments
        {
            public string numberOfStops { get; set; }
            public _departure departure { get; set; }
            public _arrival arrival { get; set; }


            public class _departure
            {
                public string iataCode { get; set; }
                public DateTime at { get; set; }
            }


            public class _arrival
            {
                public string iataCode { get; set; }
                public DateTime at { get; set; }
            }

        }
    }



    public class _travelerPricings
    {
        public _fareDetailsBySegment[] fareDetailsBySegment { get; set; }

        public class _fareDetailsBySegment
        {
            public int segmentId { get; set; }
        }
    }






}
