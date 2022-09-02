//***************************************************************************
//* DomainName: Common Models
//* FileName:   RefIdeaenvironmentElEntity.g.cs
//***************************************************************************

/// <summary>
/// The IRefIdeaenvironmentEl file
/// </summary>
[Table("RefIdeaenvironmentEl", Schema = "Common")]
public partial class RefIdeaenvironmentElEntity : ReferenceBaseEntity, IReferenceBase
{
    #region "IRefIdeaenvironmentEl Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Int32 RefIdeaenvironmentElid { get; set; }

    #endregion
}
