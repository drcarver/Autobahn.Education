//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IElstaffEmployment.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEmployment file
/// </summary>
public partial interface IElstaffEmployment
{
    #region "IElstaffEmployment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? HourlyWage { get; set; }

    Decimal? HoursWorkedPerWeek { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEleducationStaffClassification"/> model
    /// </summary>
    Guid? RefEleducationStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElemploymentSeparationReason"/> model
    /// </summary>
    Guid? RefElemploymentSeparationReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceProfessionalStaffClassification"/> model
    /// </summary>
    Guid? RefElserviceProfessionalStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
    /// </summary>
    Guid? RefEmploymentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageCollectionMethod"/> model
    /// </summary>
    Guid? RefWageCollectionMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageVerification"/> model
    /// </summary>
    Guid? RefWageVerificationId { get; set; }

    Boolean? StaffApprovalIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    Guid StaffEmploymentId { get; set; }

    Boolean? UnionMembershipStatus { get; set; }

    #endregion
}
