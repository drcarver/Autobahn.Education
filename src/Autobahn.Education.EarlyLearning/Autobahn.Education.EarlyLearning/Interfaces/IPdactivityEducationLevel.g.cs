//***************************************************************************
//* DomainName: Early Learning (EL)
//* FileName:   IPdactivityEducationLevel.g.cs
//***************************************************************************

/// <summary>
/// The IPdactivityEducationLevel file
/// </summary>
public partial interface IPdactivityEducationLevel
{
    #region "IPdactivityEducationLevel Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IProfessionalDevelopmentActivity"/> model
    /// </summary>
    Guid ProfessionalDevelopmentActivityId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefPdactivityEducationLevelsAddressed"/> model
    /// </summary>
    Guid RefPdactivityEducationLevelsAddressedId { get; set; }

    #endregion
}
