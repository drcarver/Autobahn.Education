//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12titleIiilanguageInstruction.g.cs
//***************************************************************************

/// <summary>
/// The IK12titleIiilanguageInstruction file
/// </summary>
public partial interface IK12titleIiilanguageInstruction
{
    #region "IK12titleIiilanguageInstruction Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IOrganization"/> model
    /// </summary>
    Guid OrganizationId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiilanguageInstructionProgramType"/> model
    /// </summary>
    Guid RefTitleIiilanguageInstructionProgramTypeId { get; set; }

    #endregion
}
