//***************************************************************************
//* DomainName: Person Models
//* FileName:   IPersonDemographicRace.g.cs
//***************************************************************************

/// <summary>
/// The IPersonDemographicRace file
/// </summary>
public partial interface IPersonDemographicRace
{
    #region "IPersonDemographicRace Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Federal Race and Ethnicity Declined
    /// <para>
    /// A parent, guardian, or student declined to report sufficient information for identifying a student's federal race and/or ethnicity.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20932">Federal Race and Ethnicity Declined</a>
    /// </para>
    /// </summary>
    Boolean? FederalRaceAndEthnicityDeclined { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IPerson"/> model
    /// </summary>
    Guid PersonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefRace"/> model
    /// </summary>
    Guid RefRaceId { get; set; }

    #endregion
}
