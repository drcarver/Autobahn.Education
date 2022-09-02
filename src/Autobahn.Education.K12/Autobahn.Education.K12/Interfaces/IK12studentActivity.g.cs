//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12studentActivity.g.cs
//***************************************************************************

/// <summary>
/// The IK12studentActivity file
/// </summary>
public partial interface IK12studentActivity
{
    #region "IK12studentActivity Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Decimal? ActivityTimeInvolved { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
    /// </summary>
    Guid OrganizationPersonRoleId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementType"/> model
    /// </summary>
    Guid? RefActivityTimeMeasurementTypeId { get; set; }

    #endregion
}
