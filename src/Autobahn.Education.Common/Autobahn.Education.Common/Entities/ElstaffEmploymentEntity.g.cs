//***************************************************************************
//* DomainName: Common Models
//* FileName:   ElstaffEmploymentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IElstaffEmployment file
/// </summary>
[Table("ElstaffEmployment", Schema = "Common")]
public partial class ElstaffEmploymentEntity : EntityBase, IElstaffEmployment
{
    #region "IElstaffEmployment Properties"
    public Decimal? HourlyWage { get; set; }

    public Decimal? HoursWorkedPerWeek { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEleducationStaffClassification"/> model
    /// </summary>
    [ForeignKey("RefEleducationStaffClassification")]
    public Guid? RefEleducationStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElemploymentSeparationReason"/> model
    /// </summary>
    [ForeignKey("RefElemploymentSeparationReason")]
    public Guid? RefElemploymentSeparationReasonId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefElserviceProfessionalStaffClassification"/> model
    /// </summary>
    [ForeignKey("RefElserviceProfessionalStaffClassification")]
    public Guid? RefElserviceProfessionalStaffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmploymentStatus"/> model
    /// </summary>
    [ForeignKey("RefEmploymentStatus")]
    public Guid? RefEmploymentStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageCollectionMethod"/> model
    /// </summary>
    [ForeignKey("RefWageCollectionMethod")]
    public Guid? RefWageCollectionMethodId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefWageVerification"/> model
    /// </summary>
    [ForeignKey("RefWageVerification")]
    public Guid? RefWageVerificationId { get; set; }

    public Boolean? StaffApprovalIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("StaffEmployment")]
    public Guid StaffEmploymentId { get; set; }

    public Boolean? UnionMembershipStatus { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IStaffEmployment"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual StaffEmploymentEntity StaffEmploymentEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEmploymentStatus"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEmploymentStatusEntity RefEmploymentStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefWageCollectionMethod"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefWageCollectionMethodEntity RefWageCollectionMethodEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefWageVerification"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefWageVerificationEntity RefWageVerificationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEleducationStaffClassification"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEleducationStaffClassificationEntity RefEleducationStaffClassificationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElemploymentSeparationReason"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElemploymentSeparationReasonEntity RefElemploymentSeparationReasonEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefElserviceProfessionalStaffClassification"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefElserviceProfessionalStaffClassificationEntity RefElserviceProfessionalStaffClassificationEntity { get; set; }

    #endregion
}
