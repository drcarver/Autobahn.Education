//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildServicesApplicationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildServicesApplication file
/// </summary>
public partial class ElchildServicesApplicationModel : AutobahnBaseModel, IElchildServicesApplication
{
    #region "IElchildServicesApplication Properties"
    public DateTime? ApplicationDate { get; set; }

    public System.String ElapplicationIdentifier { get; set; }

    public Boolean? ElapplicationRequiredDocument { get; set; }

    public System.String ElenrollmentApplicationDocumentIdentifier { get; set; }

    public System.String ElenrollmentApplicationDocumentName { get; set; }

    public System.String ElenrollmentApplicationDocumentType { get; set; }

    public DateTime? ElenrollmentApplicationVerificationDate { get; set; }

    public System.String ElenrollmentApplicationVerificationReasonType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    public System.String SitePreferenceRank { get; set; }

    #endregion
}
