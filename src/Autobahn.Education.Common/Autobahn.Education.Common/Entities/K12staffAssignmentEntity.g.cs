//***************************************************************************
//* DomainName: Common Models
//* FileName:   K12staffAssignmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffAssignment file
/// </summary>
[Table("K12staffAssignment", Schema = "Common")]
public partial class K12staffAssignmentEntity : EntityBase, IK12staffAssignment
{
    #region "IK12staffAssignment Properties"
    public Decimal? ContributionPercentage { get; set; }

    public Decimal? FullTimeEquivalency { get; set; }

    public Boolean? HighlyQualifiedTeacherIndicator { get; set; }

    public Boolean? ItinerantTeacher { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("OrganizationPersonRole")]
    public Guid OrganizationPersonRoleId { get; set; }

    public Boolean? PrimaryAssignment { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
    /// </summary>
    [ForeignKey("RefClassroomPositionType")]
    public Guid? RefClassroomPositionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEdfactsTeacherInexperiencedStatus"/> model
    /// </summary>
    [ForeignKey("RefEdfactsTeacherInexperiencedStatus")]
    public Guid? RefEdfactsTeacherInexperiencedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
    /// </summary>
    [ForeignKey("RefEmergencyOrProvisionalCredentialStatus")]
    public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    [ForeignKey("RefK12staffClassification")]
    public Guid? RefK12staffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
    /// </summary>
    [ForeignKey("RefMepStaffCategory")]
    public Guid? RefMepStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
    /// </summary>
    [ForeignKey("RefOutOfFieldStatus")]
    public Guid? RefOutOfFieldStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
    /// </summary>
    [ForeignKey("RefProfessionalEducationJobClassification")]
    public Guid? RefProfessionalEducationJobClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
    /// </summary>
    [ForeignKey("RefSpecialEducationAgeGroupTaught")]
    public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
    /// </summary>
    [ForeignKey("RefSpecialEducationStaffCategory")]
    public Guid? RefSpecialEducationStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
    /// </summary>
    [ForeignKey("RefTeachingAssignmentRole")]
    public Guid? RefTeachingAssignmentRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramStaffCategory"/> model
    /// </summary>
    [ForeignKey("RefTitleIprogramStaffCategory")]
    public Guid? RefTitleIprogramStaffCategoryId { get; set; }

    public Boolean? SpecialEducationParaprofessional { get; set; }

    public Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

    public Boolean? SpecialEducationTeacher { get; set; }

    public Boolean? TeacherOfRecord { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefK12staffClassification"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefK12staffClassificationEntity RefK12staffClassificationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefProfessionalEducationJobClassification"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefProfessionalEducationJobClassificationEntity RefProfessionalEducationJobClassificationEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTeachingAssignmentRole"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTeachingAssignmentRoleEntity RefTeachingAssignmentRoleEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefClassroomPositionType"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefClassroomPositionTypeEntity RefClassroomPositionTypeEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefSpecialEducationStaffCategory"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefSpecialEducationStaffCategoryEntity RefSpecialEducationStaffCategoryEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefSpecialEducationAgeGroupTaught"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefSpecialEducationAgeGroupTaughtEntity RefSpecialEducationAgeGroupTaughtEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefMepStaffCategory"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefMepStaffCategoryEntity RefMepStaffCategoryEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefTitleIprogramStaffCategory"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefTitleIprogramStaffCategoryEntity RefTitleIprogramStaffCategoryEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEdfactsTeacherInexperiencedStatus"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEdfactsTeacherInexperiencedStatusEntity RefEdfactsTeacherInexperiencedStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefEmergencyOrProvisionalCredentialStatus"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefEmergencyOrProvisionalCredentialStatusEntity RefEmergencyOrProvisionalCredentialStatusEntity { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IRefOutOfFieldStatus"/> implementation
    /// <remarks>
    /// This entity is in the Common domain
    /// </remarks>
    /// </summary>
    public virtual RefOutOfFieldStatusEntity RefOutOfFieldStatusEntity { get; set; }

    #endregion
}
