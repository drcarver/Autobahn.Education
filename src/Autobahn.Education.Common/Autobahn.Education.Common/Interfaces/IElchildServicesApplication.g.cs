//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElchildServicesApplication.g.cs
//***************************************************************************

/// <summary>
/// The IElchildServicesApplication file
/// </summary>
public partial interface IElchildServicesApplication
{
    #region "IElchildServicesApplication Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    DateTime? ApplicationDate { get; set; }

    System.String ElapplicationIdentifier { get; set; }

    Boolean? ElapplicationRequiredDocument { get; set; }

    System.String ElenrollmentApplicationDocumentIdentifier { get; set; }

    System.String ElenrollmentApplicationDocumentName { get; set; }

    System.String ElenrollmentApplicationDocumentType { get; set; }

    DateTime? ElenrollmentApplicationVerificationDate { get; set; }

    System.String ElenrollmentApplicationVerificationReasonType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    System.String SitePreferenceRank { get; set; }

    #endregion
}
