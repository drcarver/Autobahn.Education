//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentEmploymentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentEmployment file
/// </summary>
public partial class K12studentEmploymentModel : AutobahnBaseModel, IK12studentEmployment
{
    #region "IK12studentEmployment Properties"
    public System.String EmploymentNaicsCode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    public Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    public Guid? RefEmployedWhileEnrolledId { get; set; }

    #endregion
}
