//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialAwardCreditEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialAwardCredit file
/// </summary>
[Table("CredentialAwardCredit", Schema = "Credentials")]
public partial class CredentialAwardCreditEntity : EntityBase, ICredentialAwardCredit
{
    #region "ICredentialAwardCredit Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("CredentialAward")]
    public Guid CredentialAwardId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialCriteriaCourse"/> model
    /// </summary>
    [ForeignKey("CredentialCriteriaCourse")]
    public Guid? CredentialCriteriaCourseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [ForeignKey("OrganizationPersonRole")]
    public Guid? OrganizationPersonRoleId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialAward"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CredentialAwardEntity CredentialAwardEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialCriteriaCourse"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CredentialCriteriaCourseEntity CredentialCriteriaCourseEntity { get; set; }

    #endregion
}
