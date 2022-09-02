//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAccountProgram file
/// </summary>
[Table("FinancialAccountProgram", Schema = "Common")]
public partial class FinancialAccountProgramEntity : EntityBase, IFinancialAccountProgram
{
    #region "IFinancialAccountProgram Properties"
    /// <summary>
    /// Financial Account Program Name
    /// <para>
    /// The name given to the program area in an educational institution's accounting system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20626">Financial Account Program Name</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(100,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("The name given to the program area in an educational institution's accounting system.")]
    public System.String Name { get; set; }

    /// <summary>
    /// Financial Account Program Number
    /// <para>
    /// A number given to a program area within an educational institution's accounting system.
    /// </para>
    /// <para>
    /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20627">Financial Account Program Number</a>
    /// </para>
    /// </summary>
    [Required(ErrorMessage="{0} is required.")]
    [StringLength(30,ErrorMessage="The {0} must be less then {1} characters.")]
    [Comment("A number given to a program area within an educational institution's accounting system.")]
    public System.String ProgramNumber { get; set; }

    #endregion

    #region "Virtual Properties for foreign keys"
    #endregion
}
