//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12staffEmployment.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffEmployment file
/// </summary>
public partial interface IK12staffEmployment
{
    #region "IK12staffEmployment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? ContractDaysOfServicePerYear { get; set; }

    Boolean? MepPersonnelIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
    /// </summary>
    Guid? RefEmploymentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    Guid? RefK12staffClassificationId { get; set; }

    Boolean? SalaryForTeachingAssignmentOnlyIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    Guid StaffEmploymentId { get; set; }

    Boolean? TitleItargetedAssistanceStaffFunded { get; set; }

    #endregion
}
