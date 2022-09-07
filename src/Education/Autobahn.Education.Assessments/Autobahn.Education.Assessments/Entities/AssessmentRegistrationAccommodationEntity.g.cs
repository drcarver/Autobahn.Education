//***************************************************************************
//* DomainName: Assessments
//* FileName:   AssessmentRegistrationAccommodationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IAssessmentRegistrationAccommodation file
/// </summary>
[Table("AssessmentRegistrationAccommodation", Schema = "Assessments")]
public partial class AssessmentRegistrationAccommodationEntity : EntityBase, IAssessmentRegistrationAccommodation
{
    #region "IAssessmentRegistrationAccommodation Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentAccommodation")]
    public Guid AssessmentAccommodationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("AssessmentRegistration")]
    public Guid AssessmentRegistrationId { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentRegistration"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentRegistrationEntity AssessmentRegistrationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IAssessmentAccommodation"/> implementation
    /// <remarks>
    /// This entity is in the Assessments domain
    /// </remarks>
    /// </summary>
    public virtual AssessmentAccommodationEntity AssessmentAccommodationEntity { get; set; }

    #endregion
}
