//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   DataCollectionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IDataCollection file
/// </summary>
[Table("DataCollection", Schema = "Invalid")]
public partial class DataCollectionEntity : EntityBase, IDataCollection
{
    #region "IDataCollection Properties"
    /// <summary>
    /// Data Collection Academic School Year
    /// <para>
    /// The year for a reported school session for which the data is applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20920">Data Collection Academic School Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year for a reported school session for which the data is applicable.")]
    public System.String DataCollectionAcademicSchoolYear { get; set; }

    /// <summary>
    /// Data Collection Close Date
    /// <para>
    /// The date the data collection closes or ends.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20921">Data Collection Close Date</a>
    /// </para>
    /// </summary>
    [Comment("The date the data collection closes or ends.")]
    public DateTime? DataCollectionCloseDate { get; set; }

    /// <summary>
    /// Data Collection Description
    /// <para>
    /// The description of what is included in the data within the context of the data collection based on the source system and collection period as defined by the Data Collection Open Date and Data Collection Close Date.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20922">Data Collection Description</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Comment("The description of what is included in the data within the context of the data collection based on the source system and collection period as defined by the Data Collection Open Date and Data Collection Close Date.")]
    public System.String DataCollectionDescription { get; set; }

    /// <summary>
    /// Data Collection Name
    /// <para>
    /// A human readable name used to identify the data within the collection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20923">Data Collection Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A human readable name used to identify the data within the collection.")]
    public System.String DataCollectionName { get; set; }

    /// <summary>
    /// Data Collection Open Date
    /// <para>
    /// The date the data collection opens or commences.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20924">Data Collection Open Date</a>
    /// </para>
    /// </summary>
    [Comment("The date the data collection opens or commences.")]
    public DateTime? DataCollectionOpenDate { get; set; }

    /// <summary>
    /// Data Collection School Year
    /// <para>
    /// The year for a reported school session in which the data collection occurs.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20925">Data Collection School Year</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(4,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The year for a reported school session in which the data collection occurs.")]
    public System.String DataCollectionSchoolYear { get; set; }

    /// <summary>
    /// Data Collection Status
    /// <para>
    /// A process indicator of the level of stability, quality, and/or preparedness of the collection of data.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20926">Data Collection Status</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefDataCollectionStatus")]
    [Comment("A process indicator of the level of stability, quality, and/or preparedness of the collection of data.")]
    public Guid? RefDataCollectionStatusId { get; set; }

    /// <summary>
    /// Source System Data Collection Identifier
    /// <para>
    /// The identifier specified by the source system that uniquely identifies the data collection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20960">Source System Data Collection Identifier</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(36,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The identifier specified by the source system that uniquely identifies the data collection.")]
    public System.String SourceSystemDataCollectionIdentifier { get; set; }

    /// <summary>
    /// Source System Name
    /// <para>
    /// The name of the source system that provided the data within the collection.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20961">Source System Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name of the source system that provided the data within the collection.")]
    public System.String SourceSystemName { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// A process indicator of the level of stability, quality, and/or preparedness of the collection of data.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20926">Data Collection Status</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Invalid domain
    /// </remarks>
    /// </summary>
    public virtual RefDataCollectionStatusEntity? RefDataCollectionStatusEntity { get; set; }

    #endregion
}
