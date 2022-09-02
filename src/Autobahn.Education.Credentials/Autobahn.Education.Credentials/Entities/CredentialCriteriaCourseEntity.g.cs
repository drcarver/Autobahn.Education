//***************************************************************************
//* DomainName: Credentials
//* FileName:   CredentialCriteriaCourseEntity.g.cs
//***************************************************************************

/// <summary>
/// The ICredentialCriteriaCourse file
/// </summary>
[Table("CredentialCriteriaCourse", Schema = "Credentials")]
public partial class CredentialCriteriaCourseEntity : EntityBase, ICredentialCriteriaCourse
{
    #region "ICredentialCriteriaCourse Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Course")]
    public Guid CourseId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="ICredentialDefCriteria"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The CredentialDefCriteria property is obsolete and will be removed in a later version")]
    [ForeignKey("CredentialDefCriteria")]
    public Guid CredentialDefCriteriaId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="ICourse"/> implementation
    /// <remarks>
    /// This entity is in the Credentials domain
    /// </remarks>
    /// </summary>
    public virtual CourseEntity CourseEntity { get; set; }

    #endregion
}
