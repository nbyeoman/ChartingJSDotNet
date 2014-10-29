namespace Charting.bll
{

    /// <summary>
    /// Specifies which concrete implementation of the DataPointLabel and DataPointValue will be instantiated. 
    /// </summary>
    public enum DataPointType
    {
        Float = 1, 
        Integer = 2, 
        Text = 3
    } // DataPointType

    public enum DateReturnStyle
    {
        DateOnly = 1, 
        Time12HourOnly = 2, 
        Time24HourOnly = 3, 
        DateAndTime = 4
    }

}