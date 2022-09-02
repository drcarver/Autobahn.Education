//***************************************************************************
//* DomainName: Common Models
//* FileName:   PersonDigitalAccessEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDigitalAccess file
/// </summary>
[Table("PersonDigitalAccess", Schema = "Common")]
public partial class PersonDigitalAccessEntity : EntityBase, IPersonDigitalAccess
{
    #region "IPersonDigitalAccess Properties"
    /// <summary>
    /// Internet Access In Residence
    /// <para>
    /// An indication of whether the student is able to access the internet in their primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20936">Internet Access In Residence</a>
    /// </para>
    /// </summary>
    [Comment("An indication of whether the student is able to access the internet in their primary place of residence.")]
    public Boolean? InternetAccessInResidence { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> model
    /// </summary>
    [ForeignKey("PersonAddress")]
    public Guid? PersonAddressId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Barrier to Internet Access In Residence
    /// <para>
    /// An indication of the barrier to having internet access in the student's primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20916">Barrier to Internet Access In Residence</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefBarrierToInternetAccessInResidence")]
    [Comment("An indication of the barrier to having internet access in the student's primary place of residence.")]
    public Guid? RefBarrierToInternetAccessInResidenceId { get; set; }

    /// <summary>
    /// Internet Access Type In Residence
    /// <para>
    /// The primary type of internet service used in the student's primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20937">Internet Access Type In Residence</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefInternetAccessTypeInResidence")]
    [Comment("The primary type of internet service used in the student's primary place of residence.")]
    public Guid? RefInternetAccessTypeInResidenceId { get; set; }

    /// <summary>
    /// Internet Performance In Residence
    /// <para>
    /// An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20939">Internet Performance In Residence</a>
    /// </para>
    /// </summary>
    [ForeignKey("RefInternetPerformanceInResidence")]
    [Comment("An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.")]
    public Guid? RefInternetPerformanceInResidenceId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonAddress"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual PersonAddressEntity PersonAddressEntity { get; set; }

    /// <summary>
    /// An indication of the barrier to having internet access in the student's primary place of residence.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20916">Barrier to Internet Access In Residence</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefBarrierToInternetAccessInResidenceEntity RefBarrierToInternetAccessInResidenceEntity { get; set; }

    /// <summary>
    /// The primary type of internet service used in the student's primary place of residence.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20937">Internet Access Type In Residence</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefInternetAccessTypeInResidenceEntity RefInternetAccessTypeInResidenceEntity { get; set; }

    /// <summary>
    /// An indication of whether the student can complete the full range of learning activities, including video streaming and assignment upload, without interruptions caused by poor internet performance in their primary place of residence.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20939">Internet Performance In Residence</a>
    /// </para>
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefInternetPerformanceInResidenceEntity RefInternetPerformanceInResidenceEntity { get; set; }

    #endregion
}
