//***************************************************************************
//* DomainName: Person Models
//* FileName:   PersonDemographicRaceEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDemographicRace file
/// </summary>
public partial class PersonDemographicRaceModel : AutobahnBaseModel, IPersonDemographicRace
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
    public Boolean? FederalRaceAndEthnicityDeclined { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    public Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRace"/> model
    /// </summary>
    public Guid RefRaceId { get; set; }

    #endregion
}
