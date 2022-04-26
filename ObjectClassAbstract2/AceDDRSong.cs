using System;


namespace Stepmania // Note: actual namespace depends on the project name.
{
     class AceDDRSong : DDRSong
    {
        public string aceSeries
            {get; set;}
        
        public AceDDRSong() : base()//default constructor
        {
            aceSeries = " ";
        }

        public AceDDRSong(string newName, int newFooter, string newSeriesType, string newAceSeries) : base(newName, newFooter, newSeriesType)
        {
            aceSeries = newAceSeries;
        }
        
        public override string ToString()
        {
            return (base.ToString() + " | " + "Difficulty: " + aceSeries);
        }

    }//end class song

}//end name space