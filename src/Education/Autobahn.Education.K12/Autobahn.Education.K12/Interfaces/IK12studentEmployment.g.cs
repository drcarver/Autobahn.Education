//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentEmployment.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentEmployment file
/// </summary>
public partial interface IK12studentEmployment
{
    #region "IK12studentEmployment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String EmploymentNaicsCode { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedAfterExit"/> model
    /// </summary>
    Guid? RefEmployedAfterExitId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefEmployedWhileEnrolled"/> model
    /// </summary>
    Guid? RefEmployedWhileEnrolledId { get; set; }

    #endregion
}
