//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefPreKeligibleAgesNonIdeaEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefPreKeligibleAgesNonIdea file
/// </summary>
[Table("RefPreKeligibleAgesNonIdea", Schema = "Common")]
public partial class RefPreKeligibleAgesNonIdeaEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefPreKeligibleAgesNonIdea Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 RefPreKeligibleAgesNonIdeaid { get; set; }

    #endregion
}
