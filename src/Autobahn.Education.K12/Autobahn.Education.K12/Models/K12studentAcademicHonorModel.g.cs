//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentAcademicHonorEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentAcademicHonor file
/// </summary>
public partial class K12studentAcademicHonorModel : AutobahnBaseModel, IK12studentAcademicHonor
{
    #region "IK12studentAcademicHonor Properties"
    public System.String HonorDescription { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefAcademicHonorType"/> model
    /// </summary>
    public Guid? RefAcademicHonorTypeId { get; set; }

    #endregion
}
