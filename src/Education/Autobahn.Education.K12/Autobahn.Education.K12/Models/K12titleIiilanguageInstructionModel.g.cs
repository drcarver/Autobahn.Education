//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12titleIiilanguageInstructionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12titleIiilanguageInstruction file
/// </summary>
public partial class K12titleIiilanguageInstructionModel : AutobahnBaseModel, IK12titleIiilanguageInstruction
{
    #region "IK12titleIiilanguageInstruction Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
    /// </summary>
    public Guid RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    #endregion
}
