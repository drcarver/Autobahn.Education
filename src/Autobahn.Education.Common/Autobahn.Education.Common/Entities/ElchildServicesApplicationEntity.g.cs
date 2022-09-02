//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElchildServicesApplicationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElchildServicesApplication file
/// </summary>
[Table("ElchildServicesApplication", Schema = "Common")]
public partial class ElchildServicesApplicationEntity : EntityBase, IElchildServicesApplication
{
    #region "IElchildServicesApplication Properties"
    public DateTime? ApplicationDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElapplicationIdentifier { get; set; }

    public Boolean? ElapplicationRequiredDocument { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(40,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationDocumentIdentifier { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(60,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationDocumentName { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationDocumentType { get; set; }

    public DateTime? ElenrollmentApplicationVerificationDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ElenrollmentApplicationVerificationReasonType { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String SitePreferenceRank { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
