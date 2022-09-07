//***************************************************************************
//* DomainName: Unknown Models
//* FileName:   IdsversionEntity.g.cs
//***************************************************************************

/// <summary>
/// The IIdsversion file
/// </summary>
[Table("Idsversion", Schema = "Invalid")]
public partial class IdsversionEntity : EntityBase, IIdsversion
{
    #region "IIdsversion Properties"
    [Required(ErrorMessage="{0} is required.")]
    public System.Boolean CurrentVersion { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    public System.DateTime IdsversionDate { get; set; }

    [Required(ErrorMessage="{0} is required.")]
    [StringLength(10,ErrorMessage="The {0} must be less then {1} characters.")]
    public System.String IdsversionNumber { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
