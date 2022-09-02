//***************************************************************************
//* DomainName: Common Models
//* FileName:   K12staffAssignmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffAssignment file
/// </summary>
public partial class K12staffAssignmentModel : AutobahnBaseModel, IK12staffAssignment
{
    #region "IK12staffAssignment Properties"
    public Decimal? ContributionPercentage { get; set; }

    public Decimal? FullTimeEquivalency { get; set; }

    public Boolean? HighlyQualifiedTeacherIndicator { get; set; }

    public Boolean? ItinerantTeacher { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    public Boolean? PrimaryAssignment { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
    /// </summary>
    public Guid? RefClassroomPositionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEdfactsTeacherInexperiencedStatus"/> model
    /// </summary>
    public Guid? RefEdfactsTeacherInexperiencedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
    /// </summary>
    public Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    public Guid? RefK12staffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
    /// </summary>
    public Guid? RefMepStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
    /// </summary>
    public Guid? RefOutOfFieldStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
    /// </summary>
    public Guid? RefProfessionalEducationJobClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
    /// </summary>
    public Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
    /// </summary>
    public Guid? RefSpecialEducationStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
    /// </summary>
    public Guid? RefTeachingAssignmentRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramStaffCategory"/> model
    /// </summary>
    public Guid? RefTitleIprogramStaffCategoryId { get; set; }

    public Boolean? SpecialEducationParaprofessional { get; set; }

    public Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

    public Boolean? SpecialEducationTeacher { get; set; }

    public Boolean? TeacherOfRecord { get; set; }

    #endregion
}
