//***************************************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12leaTitleIiiprofessionalDevelopmentEntity.g.cs
//***************************************************************************

/// <summary>
/// The IK12leaTitleIiiprofessionalDevelopment file
/// </summary>
public partial class K12leaTitleIiiprofessionalDevelopmentModel : AutobahnBaseModel, IK12leaTitleIiiprofessionalDevelopment
{
    #region "IK12leaTitleIiiprofessionalDevelopment Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12lea"/> model
    /// </summary>
    public Guid K12leaId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="IK12leatitleIiiprofessionalDevelopment"/> model
    /// </summary>
    public Guid K12leatitleIiiprofessionalDevelopmentId { get; set; }

    /// <summary>
    /// Reference to an optional instance of the <see cref="RefTitleIiiprofessionalDevelopmentType"/> model
    /// </summary>
    public Guid RefTitleIiiprofessionalDevelopmentTypeId { get; set; }

    #endregion
}
