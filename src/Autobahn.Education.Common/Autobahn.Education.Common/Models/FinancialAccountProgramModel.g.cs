//***************************************************************************
//* DomainName: Common Models
//* FileName:   FinancialAccountProgramEntity.g.cs
//***************************************************************************

/// <summary>
/// The IFinancialAccountProgram file
/// </summary>
public partial class FinancialAccountProgramModel : AutobahnBaseModel, IFinancialAccountProgram
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
    public System.String ProgramNumber { get; set; }

    #endregion
}
