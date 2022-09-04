//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12staffAssignment.g.cs
//***************************************************************************

/// <summary>
/// The IK12staffAssignment file
/// </summary>
public partial interface IK12staffAssignment
{
    #region "IK12staffAssignment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? ContributionPercentage { get; set; }

    Decimal? FullTimeEquivalency { get; set; }

    Boolean? HighlyQualifiedTeacherIndicator { get; set; }

    Boolean? ItinerantTeacher { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    Boolean? PrimaryAssignment { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefClassroomPositionType"/> model
    /// </summary>
    Guid? RefClassroomPositionTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEdfactsTeacherInexperiencedStatus"/> model
    /// </summary>
    Guid? RefEdfactsTeacherInexperiencedStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmergencyOrProvisionalCredentialStatus"/> model
    /// </summary>
    Guid? RefEmergencyOrProvisionalCredentialStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefK12staffClassification"/> model
    /// </summary>
    Guid? RefK12staffClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefMepStaffCategory"/> model
    /// </summary>
    Guid? RefMepStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefOutOfFieldStatus"/> model
    /// </summary>
    Guid? RefOutOfFieldStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefProfessionalEducationJobClassification"/> model
    /// </summary>
    Guid? RefProfessionalEducationJobClassificationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationAgeGroupTaught"/> model
    /// </summary>
    Guid? RefSpecialEducationAgeGroupTaughtId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
    /// </summary>
    Guid? RefSpecialEducationStaffCategoryId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTeachingAssignmentRole"/> model
    /// </summary>
    Guid? RefTeachingAssignmentRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIprogramStaffCategory"/> model
    /// </summary>
    Guid? RefTitleIprogramStaffCategoryId { get; set; }

    Boolean? SpecialEducationParaprofessional { get; set; }

    Boolean? SpecialEducationRelatedServicesPersonnel { get; set; }

    Boolean? SpecialEducationTeacher { get; set; }

    Boolean? TeacherOfRecord { get; set; }

    #endregion
}
