//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessSpeedEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDigitalAccessSpeed file
/// </summary>
[Table("PersonDigitalAccessSpeed", Schema = "Common")]
public partial class PersonDigitalAccessSpeedEntity : EntityBase, IPersonDigitalAccessSpeed
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
    [Comment("The speed that data or information can be downloaded from a server on the internet to one's device in megabits per second.")]
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
    [Comment("The date and, optionally, time that the information was gathered.")]
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
    [Comment("The speed that data or information can be sent from one's device to another device or server on the internet in megabits per second.")]
    public Decimal? InternetUploadSpeed { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDigitalAccess"/> model
    /// </summary>
    [ForeignKey("PersonDigitalAccess")]
    public Guid? PersonDigitalAccessId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonLearningDevice"/> model
    /// </summary>
    [ForeignKey("PersonLearningDevice")]
    public Guid? PersonLearningDeviceId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonDigitalAccess"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual PersonDigitalAccessEntity PersonDigitalAccessEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonLearningDevice"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual PersonLearningDeviceEntity PersonLearningDeviceEntity { get; set; }

    #endregion
}
