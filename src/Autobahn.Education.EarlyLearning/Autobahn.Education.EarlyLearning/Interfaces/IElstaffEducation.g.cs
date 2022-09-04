//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElstaffEducation.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEducation file
/// </summary>
public partial interface IElstaffEducation
{
    #region "IElstaffEducation Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? EcdegreeOrCertificateHolder { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElstaff"/> model
    /// </summary>
    Guid ElstaffId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEllevelOfSpecialization"/> model
    /// </summary>
    Guid? RefEllevelOfSpecializationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElprofessionalDevelopmentTopicArea"/> model
    /// </summary>
    Guid? RefElprofessionalDevelopmentTopicAreaId { get; set; }

    Decimal? SchoolAgeEducationPscredits { get; set; }

    Decimal? TotalApprovedEccreditsEarned { get; set; }

    Decimal? TotalCollegeCreditsEarned { get; set; }

    #endregion
}
