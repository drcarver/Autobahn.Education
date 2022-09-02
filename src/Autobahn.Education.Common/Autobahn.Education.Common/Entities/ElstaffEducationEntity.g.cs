//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElstaffEducationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEducation file
/// </summary>
[Table("ElstaffEducation", Schema = "Common")]
public partial class ElstaffEducationEntity : EntityBase, IElstaffEducation
{
    #region "IElstaffEducation Properties"
    public Boolean? EcdegreeOrCertificateHolder { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElstaff"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("Elstaff")]
    public Guid ElstaffId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEllevelOfSpecialization"/> model
    /// </summary>
    [ForeignKey("RefEllevelOfSpecialization")]
    public Guid? RefEllevelOfSpecializationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprofessionalDevelopmentTopicArea"/> model
    /// </summary>
    [ForeignKey("RefElprofessionalDevelopmentTopicArea")]
    public Guid? RefElprofessionalDevelopmentTopicAreaId { get; set; }

    public Decimal? SchoolAgeEducationPscredits { get; set; }

    public Decimal? TotalApprovedEccreditsEarned { get; set; }

    public Decimal? TotalCollegeCreditsEarned { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IElstaff"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual ElstaffEntity ElstaffEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEllevelOfSpecialization"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEllevelOfSpecializationEntity RefEllevelOfSpecializationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElprofessionalDevelopmentTopicArea"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElprofessionalDevelopmentTopicAreaEntity RefElprofessionalDevelopmentTopicAreaEntity { get; set; }

    #endregion
}
