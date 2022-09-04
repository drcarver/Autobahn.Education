//***************************************************************************
//* DomainName: Organization Models
//* FileName:   IOrganizationTelephone.g.cs
//***************************************************************************

/// <summary>
/// The IOrganizationTelephone file
/// </summary>
public partial interface IOrganizationTelephone
{
    #region "IOrganizationTelephone Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Do Not Publish Indicator
    /// <para>
    /// An indication that the record should not be published.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20905">Do Not Publish Indicator</a>
    /// </para>
    /// </summary>
    Boolean? DoNotPublishIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Primary Telephone Number Indicator
    /// <para>
    /// An indication that the telephone number should be used as the principal number for a person or organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19219">Primary Telephone Number Indicator</a>
    /// </para>
    /// </summary>
    System.Boolean PrimaryTelephoneNumberIndicator { get; set; }

    /// <summary>
    /// Institution Telephone Number Type
    /// <para>
    /// The type of communication number listed for an organization.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19167">Institution Telephone Number Type</a>
    /// </para>
    /// </summary>
    Guid? RefInstitutionTelephoneTypeId { get; set; }

    /// <summary>
    /// Telephone Number Listed Status
    /// <para>
    /// An indication of whether a telephone number is listed under a directory assistance service.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20911">Telephone Number Listed Status</a>
    /// </para>
    /// </summary>
    Guid? RefTelephoneNumberListedStatusId { get; set; }

    /// <summary>
    /// Telephone Number
    /// <para>
    /// The telephone number including the area code, and extension, if applicable.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19279">Telephone Number</a>
    /// </para>
    /// </summary>
    System.String TelephoneNumber { get; set; }

    #endregion
}
