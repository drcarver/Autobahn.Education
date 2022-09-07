//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElservicePartnerEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElservicePartner file
/// </summary>
[Table("ElservicePartner", Schema = "EarlyLearning")]
public partial class ElservicePartnerEntity : EntityBase, IElservicePartner
{
    #region "IElservicePartner Properties"
    public DateTime? MemorandumOfUnderstandingEndDate { get; set; }

    public DateTime? MemorandumOfUnderstandingStartDate { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Organization")]
    public Guid OrganizationId { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(300,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ServicePartnerDescription { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String ServicePartnerName { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
