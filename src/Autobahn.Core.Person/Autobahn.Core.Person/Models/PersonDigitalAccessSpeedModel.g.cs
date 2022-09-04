//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDigitalAccessSpeedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDigitalAccessSpeed file
/// </summary>
public partial class PersonDigitalAccessSpeedModel : AutobahnBaseModel, IPersonDigitalAccessSpeed
{
    #region "IPersonDigitalAccessSpeed Properties"
    /// <summary>
    /// Internet Download Speed
    /// <para>
    /// The speed that data or information can be downloaded from a server on the internet to one's device in megabits per second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20938">Internet Download Speed</a>
    /// </para>
    /// </summary>
    public Decimal? InternetDownloadSpeed { get; set; }

    /// <summary>
    /// Internet Speed Test Date Time
    /// <para>
    /// The date and, optionally, time that the information was gathered.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20940">Internet Speed Test Date Time</a>
    /// </para>
    /// </summary>
    public DateTime? InternetSpeedTestDateTime { get; set; }

    /// <summary>
    /// Internet Upload Speed
    /// <para>
    /// The speed that data or information can be sent from one's device to another device or server on the internet in megabits per second.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20941">Internet Upload Speed</a>
    /// </para>
    /// </summary>
    public Decimal? InternetUploadSpeed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDigitalAccess"/> model
    /// </summary>
    public Guid? PersonDigitalAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonLearningDevice"/> model
    /// </summary>
    public Guid? PersonLearningDeviceId { get; set; }

    #endregion
}
