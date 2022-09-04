//***************************************************************************
//* DomainName: Person Models
//* FileName:   IPersonDigitalAccessSpeed.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDigitalAccessSpeed file
/// </summary>
public partial interface IPersonDigitalAccessSpeed
{
    #region "IPersonDigitalAccessSpeed Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Internet Download Speed
    /// <para>
    /// The speed that data or information can be downloaded from a server on the internet to one's device in megabits per second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20938">Internet Download Speed</a>
    /// </para>
    /// </summary>
    Decimal? InternetDownloadSpeed { get; set; }

    /// <summary>
    /// Internet Speed Test Date Time
    /// <para>
    /// The date and, optionally, time that the information was gathered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20940">Internet Speed Test Date Time</a>
    /// </para>
    /// </summary>
    DateTime? InternetSpeedTestDateTime { get; set; }

    /// <summary>
    /// Internet Upload Speed
    /// <para>
    /// The speed that data or information can be sent from one's device to another device or server on the internet in megabits per second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20941">Internet Upload Speed</a>
    /// </para>
    /// </summary>
    Decimal? InternetUploadSpeed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDigitalAccess"/> model
    /// </summary>
    Guid? PersonDigitalAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonLearningDevice"/> model
    /// </summary>
    Guid? PersonLearningDeviceId { get; set; }

    #endregion
}
