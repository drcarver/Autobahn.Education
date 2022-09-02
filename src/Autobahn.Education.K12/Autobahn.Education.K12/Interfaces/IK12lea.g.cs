//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12lea.g.cs
//***************************************************************************

/// <summary>
/// The IK12lea file
/// </summary>
public partial interface IK12lea
{
    #region "IK12lea Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    Boolean? CharterSchoolIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
    /// </summary>
    Guid? RefCharterLeaStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
    /// </summary>
    Guid? RefLeaImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaType"/> model
    /// </summary>
    Guid? RefLeaTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
    /// </summary>
    Guid? RefPublicSchoolChoiceStatusId { get; set; }

    System.String SupervisoryUnionIdentificationNumber { get; set; }

    #endregion
}
