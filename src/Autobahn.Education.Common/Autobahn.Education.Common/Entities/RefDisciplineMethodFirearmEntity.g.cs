//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefDisciplineMethodFirearmEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefDisciplineMethodFirearm file
/// </summary>
[Table("RefDisciplineMethodFirearm", Schema = "Common")]
public partial class RefDisciplineMethodFirearmEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefDisciplineMethodFirearm Properties"
    /// <summary>
    /// Reference to an optional instance of the <see cref="RefDisciplineMethodFirearms"/> model
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [Obsolete("The RefDisciplineMethodFirearms property is obsolete and will be removed in a later version")]
    [ForeignKey("RefDisciplineMethodFirearms")]
    public Guid RefDisciplineMethodFirearmsId { get; set; }

    #endregion
}
