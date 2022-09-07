//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12studentActivityEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentActivity file
/// </summary>
public partial class K12studentActivityModel : AutobahnBaseModel, IK12studentActivity
{
    #region "IK12studentActivity Properties"
    public Decimal? ActivityTimeInvolved { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    public Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
    /// </summary>
    public Guid? RefActivityTimeMeasurementTypeId { get; set; }

    #endregion
}
