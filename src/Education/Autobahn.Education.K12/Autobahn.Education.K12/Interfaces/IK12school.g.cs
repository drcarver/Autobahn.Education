//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12school.g.cs
//***************************************************************************

/// <summary>
/// The IK12school file
/// </summary>
public partial interface IK12school
{
    #region "IK12school Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String AccreditationAgencyName { get; set; }

    System.String CharterSchoolApprovalYear { get; set; }

    DateTime? CharterSchoolContractApprovalDate { get; set; }

    System.String CharterSchoolContractIdNumber { get; set; }

    DateTime? CharterSchoolContractRenewalDate { get; set; }

    Boolean? CharterSchoolIndicator { get; set; }

    Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolAuthorizerAgency"/> model
    /// </summary>
    Guid? K12charterSchoolAuthorizerAgencyId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolManagementOrganization"/> model
    /// </summary>
    Guid? K12charterSchoolManagementOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
    /// </summary>
    Guid? RefAdministrativeFundingControlId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
    /// </summary>
    Guid? RefCharterSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
    /// </summary>
    Guid? RefIncreasedLearningTimeTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
    /// </summary>
    Guid? RefSchoolLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
    /// </summary>
    Guid? RefSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
    /// </summary>
    Guid? RefStatePovertyDesignationId { get; set; }

    #endregion
}
