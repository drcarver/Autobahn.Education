//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElstaffEmploymentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEmployment file
/// </summary>
public partial class ElstaffEmploymentModel : AutobahnBaseModel, IElstaffEmployment
{
    #region "IElstaffEmployment Properties"
    public Decimal? HourlyWage { get; set; }

    public Decimal? HoursWorkedPerWeek { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEleducationStaffClassification"/> model
    /// </summary>
    public Guid? RefEleducationStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElemploymentSeparationReason"/> model
    /// </summary>
    public Guid? RefElemploymentSeparationReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceProfessionalStaffClassification"/> model
    /// </summary>
    public Guid? RefElserviceProfessionalStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
    /// </summary>
    public Guid? RefEmploymentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageCollectionMethod"/> model
    /// </summary>
    public Guid? RefWageCollectionMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageVerification"/> model
    /// </summary>
    public Guid? RefWageVerificationId { get; set; }

    public Boolean? StaffApprovalIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    public Guid StaffEmploymentId { get; set; }

    public Boolean? UnionMembershipStatus { get; set; }

    #endregion
}
