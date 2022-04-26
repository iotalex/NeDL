using System;


namespace Stepmania // Note: actual namespace depends on the project name.
{
     class ExtremeDDRSong : DDRSong
    {
    public string extremeSeries
        {get; set;}
    public ExtremeDDRSong() : base()//default constructor
    {
        extremeSeries = " ";
    }

    public ExtremeDDRSong(string newName, int newFooter, string newSeriesType, string newExtremeSeries) : base(newName, newFooter, newSeriesType)
    {
        extremeSeries = newExtremeSeries;
    }

    }//end class song

}//end name space