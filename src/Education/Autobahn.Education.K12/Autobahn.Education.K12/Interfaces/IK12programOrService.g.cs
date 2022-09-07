//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12programOrService.g.cs
//***************************************************************************

/// <summary>
/// The IK12programOrService file
/// </summary>
public partial interface IK12programOrService
{
    #region "IK12programOrService Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    Boolean? ProgramInMultiplePurposeFacility { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
    /// </summary>
    Guid? RefKindergartenDailyLengthId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
    /// </summary>
    Guid? RefMepProjectTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
    /// </summary>
    Guid? RefMepSessionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
    /// </summary>
    Guid? RefPrekindergartenDailyLengthId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
    /// </summary>
    Guid? RefProgramGiftedEligibilityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIinstructionalServices"/> model
    /// </summary>
    Guid? RefTitleIinstructionalServicesId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramType"/> model
    /// </summary>
    Guid? RefTitleIprogramTypeId { get; set; }

    #endregion
}
