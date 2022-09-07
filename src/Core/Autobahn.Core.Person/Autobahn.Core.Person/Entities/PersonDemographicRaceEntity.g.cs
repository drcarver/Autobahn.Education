//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDemographicRaceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDemographicRace file
/// </summary>
[Table("PersonDemographicRace", Schema = "Person")]
public partial class PersonDemographicRaceEntity : EntityBase, IPersonDemographicRace
{
    #region "IPersonDemographicRace Properties"
    /// <summary>
    /// Federal Race and Ethnicity Declined
    /// <para>
    /// A parent, guardian, or student declined to report sufficient information for identifying a student's federal race and/or ethnicity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20932">Federal Race and Ethnicity Declined</a>
    /// </para>
    /// </summary>
    [Comment("A parent, guardian, or student declined to report sufficient information for identifying a student's federal race and/or ethnicity.")]
    public Boolean? FederalRaceAndEthnicityDeclined { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Person")]
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRace"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefRace")]
    public Guid RefRaceId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefRace"/> implementation
    /// <remarks>
    /// This entity is in the Person domain
    /// </remarks>
    /// </summary>
    public virtual RefRaceEntity RefRaceEntity { get; set; }

    #endregion
}
