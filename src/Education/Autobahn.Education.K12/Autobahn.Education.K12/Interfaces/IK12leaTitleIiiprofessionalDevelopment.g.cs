//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   IK12leaTitleIiiprofessionalDevelopment.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaTitleIiiprofessionalDevelopment file
/// </summary>
public partial interface IK12leaTitleIiiprofessionalDevelopment
{
    #region "IK12leaTitleIiiprofessionalDevelopment Properties"
    /// <summary>
    /// The Id of the Model
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leatitleIiiprofessionalDevelopment"/> model
    /// </summary>
    Guid K12leatitleIiiprofessionalDevelopmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiiprofessionalDevelopmentType"/> model
    /// </summary>
    Guid RefTitleIiiprofessionalDevelopmentTypeId { get; set; }

    #endregion
}
