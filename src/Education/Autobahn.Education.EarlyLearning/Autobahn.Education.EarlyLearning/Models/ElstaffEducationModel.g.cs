//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElstaffEducationEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEducation file
/// </summary>
public partial class ElstaffEducationModel : AutobahnBaseModel, IElstaffEducation
{
    #region "IElstaffEducation Properties"
    public Boolean? EcdegreeOrCertificateHolder { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElstaff"/> model
    /// </summary>
    public Guid ElstaffId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEllevelOfSpecialization"/> model
    /// </summary>
    public Guid? RefEllevelOfSpecializationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprofessionalDevelopmentTopicArea"/> model
    /// </summary>
    public Guid? RefElprofessionalDevelopmentTopicAreaId { get; set; }

    public Decimal? SchoolAgeEducationPscredits { get; set; }

    public Decimal? TotalApprovedEccreditsEarned { get; set; }

    public Decimal? TotalCollegeCreditsEarned { get; set; }

    #endregion
}
