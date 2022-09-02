//***************************************************************************
//* DomainName: Common Models
//* FileName:   IElenrollment.g.cs
//***************************************************************************

/// <summary>
/// The IElenrollment file
/// </summary>
public partial interface IElenrollment
{
    #region "IElenrollment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IElclassSection"/> model
    /// </summary>
    Guid? ElclassSectionId { get; set; }

    DateTime? EnrollmentDate { get; set; }

    Decimal? NumberOfDaysInAttendance { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElfederalFundingType"/> model
    /// </summary>
    Guid? RefElfederalFundingTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefFoodServiceParticipation"/> model
    /// </summary>
    Guid? RefFoodServiceParticipationId { get; set; }

    Int32? RefIdeaenvironmentElid { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefServiceOption"/> model
    /// </summary>
    Guid? RefServiceOptionId { get; set; }

    #endregion
}
