//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12lea file
/// </summary>
public partial class K12leaModel : AutobahnBaseModel, IK12lea
{
    #region "IK12lea Properties"
    public Boolean? CharterSchoolIndicator { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
    /// </summary>
    public Guid? RefCharterLeaStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
    /// </summary>
    public Guid? RefLeaImprovementStatusId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefLeaType"/> model
    /// </summary>
    public Guid? RefLeaTypeId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
    /// </summary>
    public Guid? RefPublicSchoolChoiceStatusId { get; set; }

    public System.String SupervisoryUnionIdentificationNumber { get; set; }

    #endregion
}
