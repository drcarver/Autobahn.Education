//***************************************************************************
//* DomainName: Facilities
//* FileName:   IFacilityMandate.g.cs
//***************************************************************************

/// <summary>
/// The IFacilityMandate file
/// </summary>
public partial interface IFacilityMandate
{
    #region "IFacilityMandate Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IFacility"/> model
    /// </summary>
    Guid FacilityId { get; set; }

    /// <summary>
    /// Facility State or Local Mandate Name
    /// <para>
    /// The specific law, rule, regulation, or standard of a state or local government that pertains to public school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20787">Facility State or Local Mandate Name</a>
    /// </para>
    /// </summary>
    System.String FacilityStateOrLocalMandateName { get; set; }

    /// <summary>
    /// Facilities Mandate Authority Type
    /// <para>
    /// The authority that mandates through law, regulation, or standard that pertains to a specific mandate.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20866">Facilities Mandate Authority Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilitiesMandateAuthorityTypeId { get; set; }

    /// <summary>
    /// Facility Applicable Federal Mandate Type
    /// <para>
    /// The particular federal law, regulation, or standard that pertains to a school facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20777">Facility Applicable Federal Mandate Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityApplicableFederalMandateTypeId { get; set; }

    /// <summary>
    /// Facility Federal Mandate Interest Type
    /// <para>
    /// The area of interest controlled by a federal law, regulation, or standard that pertains to a school facility.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20778">Facility Federal Mandate Interest Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityFederalMandateInterestTypeId { get; set; }

    /// <summary>
    /// Facility State or Local Mandate Interest Type
    /// <para>
    /// The area of interest controlled by a law, rule, regulation, or standard of state and local governments that pertains to public school facilities.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20786">Facility State or Local Mandate Interest Type</a>
    /// </para>
    /// </summary>
    Guid? RefFacilityStateOrLocalMandateInterestTypeId { get; set; }

    #endregion
}
