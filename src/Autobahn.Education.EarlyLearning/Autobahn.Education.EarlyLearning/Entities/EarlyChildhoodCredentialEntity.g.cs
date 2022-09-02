//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   EarlyChildhoodCredentialEntity.g.cs
//***************************************************************************

/// <summary>
/// The IEarlyChildhoodCredential file
/// </summary>
[Table("EarlyChildhoodCredential", Schema = "EarlyLearning")]
public partial class EarlyChildhoodCredentialEntity : EntityBase, IEarlyChildhoodCredential
{
    #region "IEarlyChildhoodCredential Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("PersonCredential")]
    public Guid PersonCredentialId { get; set; }

    /// <summary>
    /// Early Childhood Credential
    /// <para>
    /// The credential related to early childhood education or development held by a person.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefEarlyChildhoodCredential")]
    [Comment("The credential related to early childhood education or development held by a person.")]
    public Guid RefEarlyChildhoodCredentialId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IPersonCredential"/> implementation
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual PersonCredentialEntity PersonCredentialEntity { get; set; }

    /// <summary>
    /// The credential related to early childhood education or development held by a person.
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19344">Early Childhood Credential</a>
    /// </para>
    /// <remarks>
    /// This entity is in the EarlyLearning domain
    /// </remarks>
    /// </summary>
    public virtual RefEarlyChildhoodCredentialEntity RefEarlyChildhoodCredentialEntity { get; set; }

    #endregion
}
