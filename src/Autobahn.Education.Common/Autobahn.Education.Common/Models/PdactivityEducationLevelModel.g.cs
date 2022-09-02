//***************************************************************************
//* DomainName: Common Models
//* FileName:   PdactivityEducationLevelEntity.g.cs
//***************************************************************************

/// <summary>
/// The IPdactivityEducationLevel file
/// </summary>
public partial class PdactivityEducationLevelModel : AutobahnBaseModel, IPdactivityEducationLevel
{
    #region "IPdactivityEducationLevel Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    public Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityEducationLevelsAddressed"/> model
    /// </summary>
    public Guid RefPdactivityEducationLevelsAddressedId { get; set; }

    #endregion
}
