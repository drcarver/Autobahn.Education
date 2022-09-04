//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   RefDisciplineMethodFirearmEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefDisciplineMethodFirearm file
/// </summary>
[Table("RefDisciplineMethodFirearm", Schema = "Invalid")]
public partial class RefDisciplineMethodFirearmEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefDisciplineMethodFirearm Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [ForeignKey("RefDisciplineMethodFirearms")]
    public Guid RefDisciplineMethodFirearmsId { get; set; }

    #endregion
}
