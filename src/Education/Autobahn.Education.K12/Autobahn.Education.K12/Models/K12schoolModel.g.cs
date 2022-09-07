//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12schoolEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12school file
/// </summary>
public partial class K12schoolModel : AutobahnBaseModel, IK12school
{
    #region "IK12school Properties"
    public System.String AccreditationAgencyName { get; set; }

    public System.String CharterSchoolApprovalYear { get; set; }

    public DateTime? CharterSchoolContractApprovalDate { get; set; }

    public System.String CharterSchoolContractIdNumber { get; set; }

    public DateTime? CharterSchoolContractRenewalDate { get; set; }

    public Boolean? CharterSchoolIndicator { get; set; }

    public Boolean? CharterSchoolOpenEnrollmentIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolAuthorizerAgency"/> model
    /// </summary>
    public Guid? K12charterSchoolAuthorizerAgencyId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12charterSchoolManagementOrganization"/> model
    /// </summary>
    public Guid? K12charterSchoolManagementOrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAdministrativeFundingControl"/> model
    /// </summary>
    public Guid? RefAdministrativeFundingControlId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterSchoolType"/> model
    /// </summary>
    public Guid? RefCharterSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefIncreasedLearningTimeType"/> model
    /// </summary>
    public Guid? RefIncreasedLearningTimeTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolLevel"/> model
    /// </summary>
    public Guid? RefSchoolLevelId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefSchoolType"/> model
    /// </summary>
    public Guid? RefSchoolTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefStatePovertyDesignation"/> model
    /// </summary>
    public Guid? RefStatePovertyDesignationId { get; set; }

    #endregion
}
