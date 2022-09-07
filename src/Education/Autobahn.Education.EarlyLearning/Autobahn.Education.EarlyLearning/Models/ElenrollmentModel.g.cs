//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ElenrollmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollment file
/// </summary>
public partial class ElenrollmentModel : AutobahnBaseModel, IElenrollment
{
    #region "IElenrollment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> model
    /// </summary>
    public Guid? ElclassSectionId { get; set; }

    public DateTime? EnrollmentDate { get; set; }

    public Decimal? NumberOfDaysInAttendance { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfederalFundingType"/> model
    /// </summary>
    public Guid? RefElfederalFundingTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceParticipation"/> model
    /// </summary>
    public Guid? RefFoodServiceParticipationId { get; set; }

    public Int32? RefIdeaenvironmentElid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    public Guid? RefServiceOptionId { get; set; }

    #endregion
}
