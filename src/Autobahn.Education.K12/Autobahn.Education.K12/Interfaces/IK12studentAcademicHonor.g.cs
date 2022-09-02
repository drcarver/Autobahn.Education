//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentAcademicHonor.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentAcademicHonor file
/// </summary>
public partial interface IK12studentAcademicHonor
{
    #region "IK12studentAcademicHonor Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    System.String HonorDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
    /// </summary>
    Guid? RefAcademicHonorTypeId { get; set; }

    #endregion
}
